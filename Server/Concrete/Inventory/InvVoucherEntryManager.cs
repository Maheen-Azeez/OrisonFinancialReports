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
    public class InvVoucherEntryManager : IInvVoucherEntryManager
    {
        private readonly IDapperManager _dapperManager;

        public InvVoucherEntryManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public async Task<List<dtInvVoucherEntry>> GetVoucherEntry(long vid, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("VId", vid, DbType.Int32);
            dbPara.Add("Criteria", "VoucherEntry", DbType.String);
            //dtInvVoucher voucher = new dtInvVoucher();
            var voucherentry = Task.FromResult(_dapperManager.GetAll<dtInvVoucherEntry>
                                ("[FINWEB_INVENTORYVoucherSP]", key, dbPara,
                                commandType: CommandType.StoredProcedure));
            //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return await voucherentry;
        }
        public async Task<long> VoucherEntryEvents(dtInvVoucherEntry dtInvVoucherEntry, IDbConnection db, IDbTransaction tran)
        {
            long newID = 0;
            var dbPara = new DynamicParameters();
            if (dtInvVoucherEntry.RowState == "Insert")
            {
                dbPara.Add("VId", dtInvVoucherEntry.VID, DbType.Int64);
                dbPara.Add("AccountID", dtInvVoucherEntry.AccountID, DbType.Decimal);
                dbPara.Add("RowType", dtInvVoucherEntry.RowType, DbType.String);
                dbPara.Add("Description", dtInvVoucherEntry.Description, DbType.String);
                dbPara.Add("Debit", dtInvVoucherEntry.Debit, DbType.Decimal);
                dbPara.Add("Credit", dtInvVoucherEntry.Credit, DbType.Decimal);
                dbPara.Add("VisibleonPrint", dtInvVoucherEntry.VisibleonPrint, DbType.Boolean);
                dbPara.Add("Reconciled", dtInvVoucherEntry.Reconciled, DbType.Boolean);
                dbPara.Add("Active", dtInvVoucherEntry.Active, DbType.Boolean);
                dbPara.Add("Criteria", "Insert", DbType.String);
                dbPara.Add("Action", dtInvVoucherEntry.Action, DbType.String);
                dbPara.Add("TranType", dtInvVoucherEntry.TranType, DbType.String);
                dbPara.Add("UserId", 62, DbType.String);
                dbPara.Add("NewID", dbType: DbType.Int64, direction: ParameterDirection.Output);

                newID = _dapperManager.Insert("[FINWEB_DMLVoucherEntrySP]", dbPara, db, tran, commandType: CommandType.StoredProcedure);
            }
            else if (dtInvVoucherEntry.RowState == "Update")
            {
                dbPara.Add("VId", dtInvVoucherEntry.VID, DbType.Int64);
                dbPara.Add("AccountID", dtInvVoucherEntry.AccountID, DbType.Decimal);
                dbPara.Add("RowType", dtInvVoucherEntry.RowType, DbType.String);
                dbPara.Add("Description", dtInvVoucherEntry.Description, DbType.String);
                dbPara.Add("Debit", dtInvVoucherEntry.Debit, DbType.Decimal);
                dbPara.Add("Credit", dtInvVoucherEntry.Credit, DbType.Decimal);
                dbPara.Add("VisibleonPrint", dtInvVoucherEntry.VisibleonPrint, DbType.Boolean);
                dbPara.Add("Reconciled", dtInvVoucherEntry.Reconciled, DbType.Boolean);
                dbPara.Add("Active", dtInvVoucherEntry.Active, DbType.Boolean);
                dbPara.Add("Action", dtInvVoucherEntry.Action, DbType.String);
                dbPara.Add("TranType", dtInvVoucherEntry.TranType, DbType.String);
                dbPara.Add("ID", dtInvVoucherEntry.ID, DbType.Int32);
                dbPara.Add("Criteria", "Update", DbType.String);
                dbPara.Add("NewID", dbType: DbType.Int64, direction: ParameterDirection.Output);

               // newID = _dapperManager.UpdateTableValue("[FINWEB_DMLVoucherEntrySP]", dbPara, db, tran, commandType: CommandType.StoredProcedure);
            }
            else if (dtInvVoucherEntry.RowState == "Delete")
            {
                dbPara.Add("VEID", dtInvVoucherEntry.ID, DbType.Int64);
                //_dapperManager.Execute("delete from VoucherEntry where id=@VEID", dbPara, commandType: CommandType.Text);
            }
            return newID;
        }
    }
}
