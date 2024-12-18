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
    public class InvTransactionsManager : IInvTransactionsManager
    {
        private readonly IDapperManager _dapperManager;

        public InvTransactionsManager(IDapperManager dapperManager)
        {
            _dapperManager = dapperManager;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
        public async Task<long> TransactionsEvents(dtInvTransactions trans, IDbConnection db, IDbTransaction tran)
        {
            long newID = 0;
            var dbPara = new DynamicParameters();
            if (trans.RowState == "Insert")
            {
                dbPara.Add("VId", trans.VID, DbType.Int64);
                dbPara.Add("Active", trans.Active, DbType.Boolean);
                dbPara.Add("ItemID", trans.ItemID, DbType.Int32);
                dbPara.Add("Description", trans.Description, DbType.String);
                dbPara.Add("Factor", trans.Factor, DbType.Decimal);
                dbPara.Add("RefID", trans.RefID, DbType.Int32);
                dbPara.Add("WHID", trans.WHID, DbType.Int32);
                dbPara.Add("Qty", trans.Qty, DbType.String);
                dbPara.Add("BasicQty", trans.BasicQty, DbType.Decimal);
                dbPara.Add("IsComplex", trans.IsComplex, DbType.Boolean);
                dbPara.Add("Unit", trans.Unit, DbType.String);
                dbPara.Add("Rate", trans.Rate, DbType.Decimal);
                dbPara.Add("VAT", trans.VAT, DbType.Decimal);
                dbPara.Add("VRate", trans.VRate, DbType.Decimal);
                dbPara.Add("Amount", trans.NetAmount, DbType.Decimal);
                dbPara.Add("VATPerItem", trans.VATPerItem, DbType.Decimal);
                dbPara.Add("VATPer", trans.VATPer, DbType.Decimal);
                dbPara.Add("Discount", trans.Discount, DbType.String);
                dbPara.Add("DrAccountID", trans.DrAccountID, DbType.Int32);
                dbPara.Add("RowType", trans.RowType, DbType.Int32);
                dbPara.Add("InvoiceType", trans.InvoiceType, DbType.Int32);
                dbPara.Add("IsReturn", trans.IsReturn, DbType.Boolean);
                dbPara.Add("CrAccountID", trans.CrAccountID, DbType.Int32);
                dbPara.Add("PostAccountID", trans.PostAccountID, DbType.Int32);
                dbPara.Add("Criteria", "Insert", DbType.String);
                dbPara.Add("NewID", dbType: DbType.Int64, direction: ParameterDirection.Output);

                newID = _dapperManager.Insert("[FINWEB_DMLTRANSACTIONSSP]", dbPara, db, tran, commandType: CommandType.StoredProcedure);
            }
            else if (trans.RowState == "Update")
            {
                dbPara.Add("SlNo", trans.SlNo, DbType.Int64);
                dbPara.Add("VId", trans.VID, DbType.Int64);
                dbPara.Add("ItemID", trans.ItemID, DbType.Int32);
                dbPara.Add("Description", trans.Description, DbType.String);
                dbPara.Add("Factor", trans.Factor, DbType.Int32);
                dbPara.Add("Qty", trans.Qty, DbType.String);
                dbPara.Add("RefID", trans.RefID, DbType.Int32);
                dbPara.Add("BasicQty", trans.BasicQty, DbType.Decimal);
                dbPara.Add("Unit", trans.Unit, DbType.String);
                dbPara.Add("Rate", trans.Rate, DbType.Decimal);
                dbPara.Add("VAT", trans.VAT, DbType.Decimal);
                dbPara.Add("VRate", trans.VRate, DbType.Decimal);
                dbPara.Add("Amount", trans.NetAmount, DbType.Decimal);
                dbPara.Add("VATPer", trans.VATPer, DbType.Decimal);
                dbPara.Add("VarField3", trans.VarField3, DbType.String);
                dbPara.Add("Discount", trans.Discount, DbType.String);
                dbPara.Add("DrAccountID", trans.DrAccountID, DbType.Int32);
                dbPara.Add("CrAccountID", trans.CrAccountID, DbType.Int32);
                dbPara.Add("PostAccountID", trans.PostAccountID, DbType.Int32);
                dbPara.Add("Criteria", "Update", DbType.String);
                dbPara.Add("NewID", dbType: DbType.Int64, direction: ParameterDirection.Output);
                dbPara.Add("ID", trans.ID, DbType.Int32);

                //newID = _dapperManager.UpdateTableValue("[FINWEB_DMLTRANSACTIONSSP]", dbPara, db, tran, commandType: CommandType.StoredProcedure);
                newID = trans.ID;
            }
            else if (trans.RowState == "Delete")
            {
                newID = trans.ID;
                dbPara.Add("Id", trans.ID, DbType.Int64);
                //_dapperManager.Execute("delete from Inv.Transactions where ID=@Id", key,dbPara, commandType: CommandType.Text);
                //dbPara.Add("ID", trans.ID, DbType.Int32);
                //dbPara.Add("Criteria", "Delete", DbType.String);
                //_dapperManager.UpdateTable("[FINWEB_DMLTRANSACTIONSSP]", dbPara, db, tran, commandType: CommandType.StoredProcedure);
            }
            return newID;
        }
        public async Task<long> CreateTransactions(dtInvTransactions trans, IDbConnection db, IDbTransaction tran)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("SlNo", trans.SlNo, DbType.Int64);
            dbPara.Add("VId", trans.VID, DbType.Int64);
            dbPara.Add("ItemID", trans.ItemID, DbType.Int32);
            dbPara.Add("Description", trans.Description, DbType.String);
            dbPara.Add("Factor", trans.Factor, DbType.Decimal);
            dbPara.Add("RefID", trans.RefID, DbType.Int32);
            dbPara.Add("WHID", trans.WHID, DbType.Int32);
            dbPara.Add("Qty", trans.Qty, DbType.String);
            dbPara.Add("BasicQty", trans.BasicQty, DbType.Decimal);
            dbPara.Add("IsComplex", trans.IsComplex, DbType.Boolean);
            dbPara.Add("Unit", trans.Unit, DbType.String);
            dbPara.Add("Rate", trans.Rate, DbType.Decimal);
            dbPara.Add("VAT", trans.VAT, DbType.Decimal);
            dbPara.Add("VRate", trans.VRate, DbType.Decimal);
            dbPara.Add("Amount", trans.NetAmount, DbType.Decimal);
            dbPara.Add("VATPerItem", trans.VATPerItem, DbType.Decimal);
            dbPara.Add("VATPer", trans.VATPer, DbType.Decimal);
            dbPara.Add("Discount", trans.Discount, DbType.String);
            dbPara.Add("DrAccountID", trans.DrAccountID, DbType.Int32);
            dbPara.Add("RowType", trans.RowType, DbType.Int32);
            dbPara.Add("InvoiceType", trans.InvoiceType, DbType.Int32);
            dbPara.Add("IsReturn", trans.IsReturn, DbType.Boolean);
            dbPara.Add("VarField3", trans.VarField3, DbType.String);
            dbPara.Add("CrAccountID", trans.CrAccountID, DbType.Int32);
            dbPara.Add("PostAccountID", trans.PostAccountID, DbType.Int32);
            dbPara.Add("Criteria", "Insert", DbType.String);
            dbPara.Add("NewID", dbType: DbType.Int64, direction: ParameterDirection.Output);

            long newID = _dapperManager.Insert("[FINWEB_DMLTRANSACTIONSSP]", dbPara, db, tran, commandType: CommandType.StoredProcedure);
            return newID;
        }

        public void UpdateTransactions(dtInvTransactions trans, IDbConnection db, IDbTransaction tran)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("SlNo", trans.SlNo, DbType.Int64);
            dbPara.Add("VId", trans.VID, DbType.Int64);
            dbPara.Add("ItemID", trans.ItemID, DbType.Int32);
            dbPara.Add("Description", trans.Description, DbType.String);
            dbPara.Add("Factor", trans.Factor, DbType.Int32);
            dbPara.Add("Qty", trans.Qty, DbType.String);
            dbPara.Add("RefID", trans.RefID, DbType.Int32);
            dbPara.Add("BasicQty", trans.BasicQty, DbType.Decimal);
            dbPara.Add("Unit", trans.Unit, DbType.String);
            dbPara.Add("Rate", trans.Rate, DbType.Decimal);
            dbPara.Add("VAT", trans.VAT, DbType.Decimal);
            dbPara.Add("VRate", trans.VRate, DbType.Decimal);
            dbPara.Add("Amount", trans.NetAmount, DbType.Decimal);
            dbPara.Add("VATPer", trans.VATPer, DbType.Decimal);
            dbPara.Add("VarField3", trans.VarField3, DbType.String);
            dbPara.Add("Discount", trans.Discount, DbType.String);
            dbPara.Add("DrAccountID", trans.DrAccountID, DbType.Int32);
            dbPara.Add("CrAccountID", trans.CrAccountID, DbType.Int32);
            dbPara.Add("PostAccountID", trans.PostAccountID, DbType.Int32);
            dbPara.Add("Criteria", "Update", DbType.String);
            dbPara.Add("ID", trans.ID, DbType.Int32);

            _dapperManager.UpdateTable("[FINWEB_DMLTRANSACTIONSSP]", dbPara, db, tran, commandType: CommandType.StoredProcedure);
        }
        public void DeleteTransactions(dtInvTransactions trans, IDbConnection db, IDbTransaction tran)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ID", trans.ID, DbType.Int32);
            dbPara.Add("Criteria", "Delete", DbType.String);
            _dapperManager.UpdateTable("[FINWEB_DMLTRANSACTIONSSP]", dbPara, db, tran, commandType: CommandType.StoredProcedure);
        }
        //{

        //}

        public async Task<List<dtInvTransactions>> GetTransactions(long vid, string Criteria, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("VId", vid, DbType.Int32);
            dbPara.Add("Criteria", Criteria, DbType.String); //"Transactions"
            //dtInvVoucher voucher = new dtInvVoucher();
            var voucherentry = Task.FromResult(_dapperManager.GetAll<dtInvTransactions>
                                ("[FINWEB_INVENTORYVoucherSP]", key, dbPara,
                                commandType: CommandType.StoredProcedure));
            //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return await voucherentry;

        }
        public async Task<List<dtInvTransactions>> GetImportTransactions(long vid, string SBasicType, string DBasicType, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("VId", vid, DbType.Int32);
            dbPara.Add("SBasicType", SBasicType, DbType.String);
            dbPara.Add("DBasicType", DBasicType, DbType.String);
            var voucherentry = Task.FromResult(_dapperManager.GetAll<dtInvTransactions>
                                ("[FinWeb_ImportTransactionsSP]", key, dbPara,
                                commandType: CommandType.StoredProcedure));
            //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return await voucherentry;

        }
    }
}
