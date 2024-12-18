using Dapper;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Server.Contract.Inventory;
using OrisonMIS.Shared.Entities.Inventory;
using System.Data;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Concrete.Inventory
{
    public class InvVoucherStatusManager : IInvVoucherStatusManager
    {
        private readonly IDapperManager _dapperManager;

        public InvVoucherStatusManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
            
        }

        public async Task<long> InsertApprovals(dtInvVoucherStatus voucherStatus, IDbConnection db, IDbTransaction tran)
        {
            int AID;
            var dbPara = new DynamicParameters();
            dbPara.Add("VID", voucherStatus.VID, DbType.Int32);
            dbPara.Add("vtype", voucherStatus.SubStatus, DbType.String);
            dbPara.Add("Status", voucherStatus.Status, DbType.String);
            dbPara.Add("AccID", voucherStatus.UserID, DbType.Int32);
            dbPara.Add("Keyword", voucherStatus.Keyword, DbType.String);
            long newID = _dapperManager.Insert("[FinWeb_SetApprovalsSP]", dbPara, db, tran, commandType: CommandType.StoredProcedure);
            return newID;
        }
        public async Task<int> Approved(long vid,string substatus,string status,int userid,string approverid,string remarks, string keyword, string key)
        {
            int newID = 0;
            var dbPara = new DynamicParameters();
            dbPara.Add("VID", vid, DbType.Int32);
            dbPara.Add("vtype",substatus, DbType.String);
            dbPara.Add("Status", status, DbType.String);
            dbPara.Add("AccID", userid, DbType.Int32);
            dbPara.Add("AID", approverid, DbType.String);
            dbPara.Add("Remarks", remarks, DbType.String);
            dbPara.Add("keyword", keyword, DbType.String);
            //int newID = _dapperManager.GetValue("[FinWeb_SetApprovalsSP]", dbPara, commandType: CommandType.StoredProcedure);
            //MailRequest mr = new MailRequest();
            //mr = await _MailSettings.getMailRequestSettings(newID.ToString());
            //await _MailSettings.SendEmailAsync(mr);
            return newID;
        }
        public async Task<int> NextApprover(long vid, string substatus, string status, int userid, string approverid, string branchid,string keyword, string key)
        {
            int newID = 0;
            var dbPara = new DynamicParameters();
            dbPara.Add("VID", vid, DbType.Int32);
            dbPara.Add("vtype", substatus, DbType.String);
            dbPara.Add("Status", status, DbType.String);
            dbPara.Add("AccID", userid, DbType.Int32);
            dbPara.Add("AID", approverid, DbType.String);
            dbPara.Add("keyword", keyword, DbType.String);
            dbPara.Add("branchID", branchid, DbType.String);
            //int newID = _dapperManager.GetValue("[FinWeb_SetNextApproverSP]", dbPara, commandType: CommandType.StoredProcedure);
            return newID;
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

    }
}
