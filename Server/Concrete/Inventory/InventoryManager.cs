using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Server.Contract.Inventory;
using OrisonMIS.Shared.Entities.Inventory;
using OrisonMIS.Shared.Models;


namespace OrisonMIS.Server.Concrete.Inventory
{
    public class InventoryManager :IInventoryManager
    {
        private readonly IDapperManager _dapperManager;
        private readonly IConfiguration _config;
        private IDBOperation _Db;
        private IInvVoucherManager _Vrepository;
        private IInvVoucherEntryManager _VErepository;
        private IInvTransactionsManager _trepository;
        private IInvVoucherAdditionalsManager _VArepository;
        private IInvVoucherStatusManager _VSrepository;
        private IUserTrackManager _UTrepository;
        public InventoryManager(IDapperManager dapperManager, IConfiguration config,IDBOperation db, IInvVoucherManager vrepository, IInvVoucherEntryManager VErepository, IInvTransactionsManager trepository, IInvVoucherAdditionalsManager VArepository,IInvVoucherStatusManager VSrepository,IUserTrackManager UTrepository)
        {
            this._dapperManager = dapperManager;
            _config = config;
            _Vrepository = vrepository;
            _VErepository = VErepository;
            _trepository = trepository;
            _VArepository = VArepository;
            _VSrepository = VSrepository;
            _UTrepository = UTrepository;
            _Db = db;
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public async Task<long> CreateInventory(dtsInventory inv, string key)
        {
            long newID=0; long appID = 0;
            using IDbConnection db = new SqlConnection(_config.GetConnectionString(key));
            try
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                using var tran = db.BeginTransaction();
                try
                {
                    if (inv.Action == "Insert")
                    {
                        dtInvVoucher v = inv.voucher;
                        newID = await _Vrepository.CreateVoucher(v, db, tran);
                        dtInvVoucherAdditionals va = inv.voucheradditionals;//.ToList().ToArray().First();
                        va.VID = newID;
                        newID = await _VArepository.CreateVoucherAdditionals(va, db, tran);
                        foreach (dtInvTransactions dt in inv.transaction) // Loop through List with foreach
                        {
                            dt.VID = newID;
                            newID = await _trepository.CreateTransactions(dt, db, tran);
                        }
                            if (inv.DocType == 0 || inv.DocType == 1)
                            {
                                foreach (dtInvVoucherEntry dt in inv.voucherentry)
                                {
                                    dt.VID = newID;
                                    newID = await _VErepository.VoucherEntryEvents(dt, db, tran);
                                }
                            }
                           
                        long vid = newID;
                        if (inv.ApprovalType == 1)
                        {
                            dtInvVoucherStatus vs = inv.voucherStatus;
                            vs.VID = newID;
                            appID = await _VSrepository.InsertApprovals(vs, db, tran);
                            
                        }
                        UserTrack track = inv.UserTrack;
                        track.RowId = vid;
                        newID = await _UTrepository.SetUserTrack(track, db, tran);
                    }
                    else if(inv.Action=="Update")
                    {
                        dtInvVoucher v = inv.voucher;
                        _Vrepository.UpdateVoucher(v, db, tran);
                        dtInvVoucherAdditionals va = inv.voucheradditionals;
                        _VArepository.UpdateVoucherAdditionals(va, db, tran);
                        foreach (dtInvTransactions dt in inv.transaction)
                        {
                            if (dt.ID == 0)
                                newID = await _trepository.CreateTransactions(dt, db, tran);
                            else
                            {
                                if(dt.RowState=="Delete")
                                    _trepository.DeleteTransactions(dt, db, tran);
                                else if(dt.RowState=="Insert")
                                    _trepository.CreateTransactions(dt, db, tran);
                                else if(dt.RowState=="Update")
                                    _trepository.UpdateTransactions(dt, db, tran);
                            }
                                
                        }

                            if (inv.DocType == 0 || inv.DocType == 1)
                            {
                                foreach (dtInvVoucherEntry dt in inv.voucherentry)
                                {
                                    _VErepository.VoucherEntryEvents(dt, db, tran);
                                }
                            }
                        
                        
                        UserTrack track = inv.UserTrack;
                        newID = await _UTrepository.SetUserTrack(track, db, tran);
                        newID = v.ID;
                    }
                    else if(inv.Action=="Cancel")
                    {
                        dtInvVoucher v = inv.voucher;
                        _Vrepository.CancelVoucher(v.ID, key);
                    }
                    tran.Commit();
                    //if (inv.Action == "Insert" && inv.ApprovalType == 1)
                    //{
                    //    MailRequest mr = new MailRequest();
                    //    mr = await _MailSettings.getMailRequestSettings(appID.ToString());
                    //    await _MailSettings.SendEmailAsync(mr);
                    //}
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (db.State == ConnectionState.Open)
                    db.Close();
            }

            return newID;
        }

        //public async void UpdateInventory(dtsInventory inv)
        //{
        //    long newID;
        //    using IDbConnection db = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
        //    try
        //    {
        //        if (db.State == ConnectionState.Closed)
        //            db.Open();

        //        using var tran = db.BeginTransaction();
        //        try
        //        {
        //            dtInvVoucher v = inv.voucher;
        //             _Vrepository.UpdateVoucher(v, db, tran);
        //            dtInvVoucherAdditionals va = inv.voucheradditionals;
        //            _VArepository.UpdateVoucherAdditionals(va, db, tran);
        //            foreach (dtInvTransactions dt in inv.transaction)
        //            {
        //                _trepository.UpdateTransactions(dt, db, tran);
        //            }
        //            if (inv.DocType == 0 || inv.DocType == 1)
        //            {
        //                foreach (dtInvVoucherEntry dt in inv.voucherentry)
        //                {
        //                    _VErepository.UpdateVoucherEntry(dt, db, tran);
        //                }
        //            }
        //            tran.Commit();

        //        }
        //        catch (Exception ex)
        //        {
        //            tran.Rollback();
        //            throw ex;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (db.State == ConnectionState.Open)
        //            db.Close();
        //    }
        //}
    }
}
