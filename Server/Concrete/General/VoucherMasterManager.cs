using Dapper;
using System.Data;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.General;

namespace OrisonMIS.Server.Concrete.General
{
    public class VoucherMasterManager : IVoucherMasterManager
    {
        private readonly IDapperManager _dapperManager;

        public VoucherMasterManager(IDapperManager dapperManager)
        {
            _dapperManager = dapperManager;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public async Task<List<dtVoucherMaster>> ListAll(int vtype, int userid, int BranchID, string key)
        //(int skip, int take, string orderBy, string direction = "DESC", string search = "")
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("VType", vtype, DbType.Int32);
            dbPara.Add("BranchId", BranchID, DbType.Int32);
            dbPara.Add("userId", userid, DbType.Int32);
            dbPara.Add("Criteria", "VoucherMaster", DbType.String);
            var vouchermaster = Task.FromResult(_dapperManager.GetAll<dtVoucherMaster>
                                ("[FINWEB_INVENTORYVoucherSP]", key,dbPara,
                                commandType: CommandType.StoredProcedure));
            //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return await vouchermaster;
        }

        public async Task<List<dtVoucherMaster>> Register(int vtype, int userid, DateTime FDate, DateTime TDate, int BranchID, string Criteria, string key)
        {

            var dbPara = new DynamicParameters();
            dbPara.Add("VType", vtype, DbType.Int32);
            dbPara.Add("BranchId", BranchID, DbType.Int32);
            dbPara.Add("userId", userid, DbType.Int32);
            dbPara.Add("DateFrom", FDate, DbType.DateTime);
            dbPara.Add("DateTo", TDate, DbType.DateTime);
            dbPara.Add("Criteria", Criteria, DbType.String);
            var vouchermaster = Task.FromResult(_dapperManager.GetAll<dtVoucherMaster>
                                ("[FINWEB_INVENTORYVoucherSP]",key, dbPara,
                                commandType: CommandType.StoredProcedure));
            //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return await vouchermaster;
        }

        public async Task<List<dtVoucherMaster>> ImportVoucher(string SBasicType, string DBasicType, int BranchID, string Criteria, int User, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("SBasicType", SBasicType, DbType.String);
            dbPara.Add("DBasicType", DBasicType, DbType.String);
            dbPara.Add("BranchID", BranchID, DbType.Int32);
            dbPara.Add("AccountID", User, DbType.Int32);
            dbPara.Add("Criteria", Criteria, DbType.String);
            var vouchermaster = Task.FromResult(_dapperManager.GetAll<dtVoucherMaster>
                                ("[dbo].[ImportVouchersSP]",key, dbPara,
                                commandType: CommandType.StoredProcedure));
            return await vouchermaster;
        }

        public async Task<long> ListById(int vtype, int userid, int BranchID, string key)
        //(int skip, int take, string orderBy, string direction = "DESC", string search = "")
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("VType", vtype, DbType.Int32);
            dbPara.Add("BranchId", BranchID, DbType.Int32);
            dbPara.Add("userId", userid, DbType.Int32);
            dbPara.Add("Criteria", "VoucherMasterByID", DbType.String);
            var id = Task.FromResult(_dapperManager.Get<long>
                                ("[FINWEB_INVENTORYVoucherSP]",key, dbPara,
                                commandType: CommandType.StoredProcedure));
            //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return await id;
        }

        public async Task<long> ListByVNo(int vtype, int userid, string vNo, int BranchID, string key)
        //(int skip, int take, string orderBy, string direction = "DESC", string search = "")
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("VType", vtype, DbType.Int32);
            dbPara.Add("BranchId", BranchID, DbType.Int32);
            dbPara.Add("userId", userid, DbType.Int32);
            dbPara.Add("vNo", vNo, DbType.String);
            dbPara.Add("Criteria", "VoucherMasterByVNo", DbType.String);
            var id = Task.FromResult(_dapperManager.Execute
                                ("[FINWEB_INVENTORYVoucherSP]",key, dbPara,
                                commandType: CommandType.StoredProcedure));
            //SELECT top 1 Voucher.ID FROM Voucher WHERE (Voucher.VType = @VType) AND (Voucher.BranchID = @BranchId) and (voucher.CreatedUserID =@userId) and voucher.vno=@vNo ORDER BY Voucher.VNoInt DESC
            return await id;
        }

        public Task<int> Count(int BranchID, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("VType", 5, DbType.Int32);
            dbPara.Add("BranchId", BranchID, DbType.Int32);
            var totArticle = Task.FromResult(_dapperManager.Get<int>($"select COUNT(*) from [voucher] WHERE Vtype=@VType and branchid=@BranchId", key,dbPara,
                    commandType: CommandType.Text));
            return totArticle;
        }
        //public async Task<List<dtVoucherMaster>> ReceiptList(int vtype, int userid)
        //{
        //    var dbPara = new DynamicParameters();
        //    dbPara.Add("VType", vtype, DbType.Int32);
        //    dbPara.Add("BranchId", 31, DbType.Int32);
        //    dbPara.Add("userId", userid, DbType.Int32);
        //    dbPara.Add("Criteria", "ReceiptList", DbType.String);
        //    var receiptmaster = Task.FromResult(_dapperManager.GetAll<dtVoucherMaster>
        //                        ("[FINWEB_INVENTORYVoucherSP]", dbPara,
        //                        commandType: CommandType.StoredProcedure));
        //    //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
        //    return await receiptmaster;
        //}
        //public async Task<List<dtVoucherMaster>> ReceiptList(int vtype, int userid, DateTime FDate, DateTime TDate)
        //{
        //    var dbPara = new DynamicParameters();
        //    dbPara.Add("VType", vtype, DbType.Int32);
        //    dbPara.Add("BranchId", 31, DbType.Int32);
        //    dbPara.Add("userId", userid, DbType.Int32);
        //    dbPara.Add("DateFrom", FDate, DbType.DateTime);
        //    dbPara.Add("DateTo", TDate, DbType.DateTime);
        //    dbPara.Add("Criteria", "ReceiptList", DbType.String);
        //    var receiptmaster = Task.FromResult(_dapperManager.GetAll<dtVoucherMaster>
        //                        ("[FINWEB_INVENTORYVoucherSP]", dbPara,
        //                        commandType: CommandType.StoredProcedure));
        //    //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
        //    return await receiptmaster;
        //}
    }
}
