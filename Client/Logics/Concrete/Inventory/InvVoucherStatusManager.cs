using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Client.Logics.Contract.Inventory;
using OrisonMIS.Shared.Entities.Inventory;
using System.Data;
using System.Web;


namespace OrisonMIS.Client.Logics.Concrete.Inventory
{
    public class InvVoucherStatusManager : IInvVoucherStatusManager
    {
       
        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        string? key;
        public InvVoucherStatusManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;
          
        }
        public async Task<long> InsertApprovals(dtInvVoucherStatus voucherStatus, IDbConnection db, IDbTransaction tran)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
        public async Task<int> Approved(int vid, string substatus, string status, int userid, string approverid, string remarks, string keyword)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            dtInvVoucherStatus vs = new dtInvVoucherStatus();
            vs.VID = vid;
            vs.SubStatus = substatus;
            vs.Status = status;
            vs.UserID = userid;
            vs.ApproverID = approverid;
            vs.Remarks = remarks;
            vs.Keyword = keyword;
            return await httpClient.PostJsonAsync<int>("api/MyApprovals?key=" + key, vs);
        }
        public async Task<int> NextApprover(int vid, string substatus, string status, int userid, string approverid, string branchid, string keyword)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            dtInvVoucherStatus vs = new dtInvVoucherStatus();
            vs.VID = vid;
            vs.SubStatus = substatus;
            vs.Status = status;
            vs.UserID = userid;
            vs.ApproverID = approverid;
            vs.BranchID = branchid;
            vs.Keyword = keyword;
            vs.Remarks = "NA";
            return await httpClient.PostJsonAsync<int>("api/MyApprovals?key=" + key, vs);
        }
    }
}
