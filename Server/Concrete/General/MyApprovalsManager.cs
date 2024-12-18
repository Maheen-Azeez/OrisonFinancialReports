using Dapper;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.Inventory;
using System.Data;

namespace OrisonMIS.Server.Concrete.General
{
    public class MyApprovalsManager : IMyApprovalsManager
    {
        private readonly IDapperManager _dapperManager;

        public MyApprovalsManager(IDapperManager dapperManager)
        {
            _dapperManager = dapperManager;
        }
        public async Task<IList<dtInvVoucherStatus>> MyApprovals(int ID, int BranchID, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("userid", ID, DbType.Int32);
            dbPara.Add("BranchId", BranchID, DbType.Int32);
            dbPara.Add("Criteria", "MyApprovals", DbType.String);
            var _MyApprovals = Task.FromResult(_dapperManager.GetAll<dtInvVoucherStatus>
                                ("[FINWEB_INVENTORYVoucherSP]", key,dbPara,
                                commandType: CommandType.StoredProcedure));
            return await _MyApprovals;
        }
        public async Task<IList<dtInvVoucherStatus>> Approvals(int BranchID, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("BranchId", BranchID, DbType.Int32);
            dbPara.Add("Criteria", "Approvals", DbType.String);
            var _MyApprovals = Task.FromResult(_dapperManager.GetAll<dtInvVoucherStatus>
                                ("[FINWEB_INVENTORYVoucherSP]", key, dbPara,
                                commandType: CommandType.StoredProcedure));
            return await _MyApprovals;
        }
        public async Task<IList<dtInvVoucherStatus>> MyApprovalsStatus(int ID, long VID, int BranchID, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("userid", ID, DbType.Int32);
            dbPara.Add("VID", VID, DbType.Int32);
            dbPara.Add("BranchId", BranchID, DbType.Int32);
            dbPara.Add("Criteria", "MyApprovalsStatus", DbType.String);
            var _MyApprovalStatus = Task.FromResult(_dapperManager.GetAll<dtInvVoucherStatus>
                                ("[FINWEB_INVENTORYVoucherSP]",key, dbPara,
                                commandType: CommandType.StoredProcedure));
            return await _MyApprovalStatus;
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
