using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Server.Contract.Inventory;
using OrisonMIS.Shared.Entities.Inventory;


namespace OrisonMIS.Server.Concrete.Inventory
{
    public class InvVoucherManager : IInvVoucherManager
    {
        private readonly IDapperManager _dapperManager;

        public InvVoucherManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }
public async Task<long> VoucherEvent(dtInvVoucher InvVoucher, IDbConnection db, IDbTransaction tran)
        {
            long newID = 0;
            var dbPara = new DynamicParameters();
            if (InvVoucher.RowState=="Insert")
            {
                dbPara.Add("VType", InvVoucher.VType, DbType.Int32);
                dbPara.Add("BranchID", InvVoucher.BranchID, DbType.Int32);
                dbPara.Add("AccountID", InvVoucher.AccountID, DbType.Int32);
                dbPara.Add("StaffId", InvVoucher.StaffID, DbType.Int32);
                dbPara.Add("VDate", InvVoucher.VDate.Date, DbType.DateTime);
                dbPara.Add("RefNo", InvVoucher.RefNo, DbType.String);
                dbPara.Add("EffectiveDate", InvVoucher.EffectiveDate.Date, DbType.DateTime);
                dbPara.Add("DueDate", InvVoucher.DueDate.Date, DbType.DateTime);
                dbPara.Add("CommonNarration", InvVoucher.CommonNarration, DbType.String);
                dbPara.Add("Remark", "Mobile App", DbType.String);
                dbPara.Add("UserID", InvVoucher.ModifiedUserID, DbType.Int32);
                dbPara.Add("Posted", InvVoucher.Posted, DbType.Boolean);
                dbPara.Add("Currency", InvVoucher.Currency, DbType.Int32);
                dbPara.Add("CreatedUserID", InvVoucher.CreatedUserID, DbType.Int32);
                dbPara.Add("ModifiedUserID", InvVoucher.ModifiedUserID, DbType.Int32);
                dbPara.Add("VATAmt", InvVoucher.VATAmt, DbType.Decimal);
                dbPara.Add("VATPaid", InvVoucher.VATPaid, DbType.Decimal);
                dbPara.Add("VRound", InvVoucher.VRound, DbType.Decimal);
                dbPara.Add("Amount", InvVoucher.Amount, DbType.Decimal);
                dbPara.Add("SubTotal", InvVoucher.SubTotal, DbType.Decimal);
                dbPara.Add("ExchangeRate", InvVoucher.ExchangeRate, DbType.Decimal);
                dbPara.Add("Criteria", "Insert", DbType.String);
                dbPara.Add("NewID", dbType: DbType.Int64, direction: ParameterDirection.Output);

                newID = _dapperManager.Insert("[FINWEB_DMLVoucherSP]", dbPara, db, tran, commandType: CommandType.StoredProcedure);
            }
            else if(InvVoucher.RowState == "Update")
            {
                dbPara.Add("VType", InvVoucher.VType, DbType.Int32);
                dbPara.Add("BranchID", InvVoucher.BranchID, DbType.Int32);
                dbPara.Add("AccountID", InvVoucher.AccountID, DbType.Int32);
                dbPara.Add("StaffId", InvVoucher.StaffID, DbType.Int32);
                dbPara.Add("VDate", InvVoucher.VDate, DbType.DateTime);
                dbPara.Add("RefNo", InvVoucher.RefNo, DbType.String);
                dbPara.Add("EffectiveDate", InvVoucher.EffectiveDate, DbType.DateTime);
                dbPara.Add("ModifiedDate", InvVoucher.ModifiedDate, DbType.DateTime);
                dbPara.Add("DueDate", InvVoucher.DueDate, DbType.DateTime);
                dbPara.Add("CommonNarration", InvVoucher.CommonNarration, DbType.String);
                dbPara.Add("UserID", InvVoucher.ModifiedUserID, DbType.Int32);
                dbPara.Add("Posted", InvVoucher.Posted, DbType.Boolean);
                dbPara.Add("Currency", InvVoucher.Currency, DbType.Int32);
                dbPara.Add("CreatedUserID", InvVoucher.CreatedUserID, DbType.Int32);
                dbPara.Add("ModifiedUserID", InvVoucher.ModifiedUserID, DbType.Int32);
                dbPara.Add("VATAmt", InvVoucher.VATAmt, DbType.Decimal);
                dbPara.Add("VATPaid", InvVoucher.VATPaid, DbType.Decimal);
                dbPara.Add("VRound", InvVoucher.VRound, DbType.Decimal);
                dbPara.Add("Amount", InvVoucher.Amount, DbType.Decimal);
                dbPara.Add("SubTotal", InvVoucher.SubTotal, DbType.Decimal);
                dbPara.Add("ExchangeRate", InvVoucher.ExchangeRate, DbType.Decimal);
                dbPara.Add("RefNo", InvVoucher.RefNo, DbType.String);
                dbPara.Add("Criteria", "Update", DbType.String);
                dbPara.Add("ID", InvVoucher.ID, DbType.Int32);

                _dapperManager.UpdateTable("[FINWEB_DMLVoucherSP]", dbPara, db, tran, commandType: CommandType.StoredProcedure);
                newID = InvVoucher.ID;
            }
            else if(InvVoucher.RowState == "Update")
            {
                dbPara.Add("Vid", InvVoucher.ID, DbType.Int64);
                //_dapperManager.Execute("delete from voucher where id=@Vid", dbPara, commandType: CommandType.Text);
            }
            return newID;

        }
        public async Task<long> CreateVoucher(dtInvVoucher InvVoucher, IDbConnection db, IDbTransaction tran)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("VType", InvVoucher.VType, DbType.Int32);
            dbPara.Add("BranchID", InvVoucher.BranchID, DbType.Int32);
            dbPara.Add("AccountID", InvVoucher.AccountID, DbType.Int32);
            dbPara.Add("StaffId", InvVoucher.StaffID, DbType.Int32);
            dbPara.Add("VDate", InvVoucher.VDate, DbType.DateTime);
            dbPara.Add("EffectiveDate", InvVoucher.EffectiveDate, DbType.DateTime);
            dbPara.Add("DueDate", InvVoucher.DueDate, DbType.DateTime);
            dbPara.Add("CommonNarration", InvVoucher.CommonNarration, DbType.String);
            dbPara.Add("Remark", "WebProcurement", DbType.String);
            dbPara.Add("UserID", InvVoucher.ModifiedUserID, DbType.Int32);
            dbPara.Add("Posted", InvVoucher.Posted, DbType.Boolean);
            dbPara.Add("Currency", InvVoucher.Currency, DbType.Int32);
            dbPara.Add("CreatedUserID", InvVoucher.CreatedUserID, DbType.Int32);
            dbPara.Add("ModifiedUserID", InvVoucher.ModifiedUserID, DbType.Int32);
            dbPara.Add("VATAmt", InvVoucher.VATAmt, DbType.Decimal);
            dbPara.Add("VATPaid", InvVoucher.VATPaid, DbType.Decimal);
            dbPara.Add("VRound", InvVoucher.VRound, DbType.Decimal);
            dbPara.Add("Amount", InvVoucher.Amount, DbType.Decimal);
            dbPara.Add("SubTotal", InvVoucher.SubTotal, DbType.Decimal);
            dbPara.Add("ExchangeRate", InvVoucher.ExchangeRate, DbType.Decimal);
            dbPara.Add("RefNo", InvVoucher.RefNo, DbType.String);
            dbPara.Add("Criteria", "Insert", DbType.String);
            dbPara.Add("NewID", dbType: DbType.Int64, direction: ParameterDirection.Output);

            long newID = _dapperManager.Insert("[FINWEB_DMLVoucherSP]", dbPara, db, tran, commandType: CommandType.StoredProcedure);
            return newID;

        }
        public void CancelVoucher(long vID, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID", vID, DbType.Int64);
            dbPara.Add("Criteria", "Cancel", DbType.String);
            _dapperManager.Execute("[FINWEB_DMLVoucherSP]", key, dbPara, commandType: CommandType.StoredProcedure);

        }
        public void DeleteVoucher(long vID, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Vid", vID, DbType.Int64);
            _dapperManager.Execute("delete from voucher where id=@Vid", key, dbPara, commandType: CommandType.StoredProcedure);

        }
        public void UpdateVoucher(dtInvVoucher InvVoucher, IDbConnection db, IDbTransaction tran)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("VType", InvVoucher.VType, DbType.Int32);
            dbPara.Add("BranchID", InvVoucher.BranchID, DbType.Int32);
            dbPara.Add("AccountID", InvVoucher.AccountID, DbType.Int32);
            dbPara.Add("StaffId", InvVoucher.StaffID, DbType.Int32);
            dbPara.Add("VDate", InvVoucher.VDate, DbType.DateTime);
            dbPara.Add("EffectiveDate", InvVoucher.EffectiveDate, DbType.DateTime);
            dbPara.Add("ModifiedDate", InvVoucher.ModifiedDate, DbType.DateTime);
            dbPara.Add("DueDate", InvVoucher.DueDate, DbType.DateTime);
            dbPara.Add("CommonNarration", InvVoucher.CommonNarration, DbType.String);
            dbPara.Add("UserID", InvVoucher.ModifiedUserID, DbType.Int32);
            dbPara.Add("Posted", InvVoucher.Posted, DbType.Boolean);
            dbPara.Add("Currency", InvVoucher.Currency, DbType.Int32);
            dbPara.Add("CreatedUserID", InvVoucher.CreatedUserID, DbType.Int32);
            dbPara.Add("ModifiedUserID", InvVoucher.ModifiedUserID, DbType.Int32);
            dbPara.Add("VATAmt", InvVoucher.VATAmt, DbType.Decimal);
            dbPara.Add("VATPaid", InvVoucher.VATPaid, DbType.Decimal);
            dbPara.Add("VRound", InvVoucher.VRound, DbType.Decimal);
            dbPara.Add("Amount", InvVoucher.Amount, DbType.Decimal);
            dbPara.Add("SubTotal", InvVoucher.SubTotal, DbType.Decimal);
            dbPara.Add("ExchangeRate", InvVoucher.ExchangeRate, DbType.Decimal);
            dbPara.Add("RefNo", InvVoucher.RefNo, DbType.String);
            dbPara.Add("Criteria", "Update", DbType.String);
            dbPara.Add("ID", InvVoucher.ID,DbType.Int32);

            _dapperManager.UpdateTable("[FINWEB_DMLVoucherSP]", dbPara, db, tran, commandType: CommandType.StoredProcedure);
            

        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        //public async Task<dtVoucher> GetVoucher(int vid)
        public async Task<dtInvVoucher> GetVoucher(long VId, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("VId", VId, DbType.Int32);
            dbPara.Add("Criteria", "Voucher", DbType.String);
            //dtInvVoucher voucher = new dtInvVoucher();
            var voucher = Task.FromResult(_dapperManager.Get<dtInvVoucher>
                                ("[FINWEB_INVENTORYVoucherSP]", key, dbPara,
                                commandType: CommandType.StoredProcedure));
            //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return await voucher;
        }
    }
}
