
using OrisonMIS.Logics.Contracts.General;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Shared.Entities.Inventory;
using Blazored.SessionStorage;
using System.Web;

namespace OrisonMIS.Concrete.General
{
    public class MyApprovalsManager:IMyApprovalsManager
    {
        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        string? key;

        public MyApprovalsManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;
            
        }
        public async Task<IList<dtInvVoucherStatus>> MyApprovals(int ID,int BranchID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<dtInvVoucherStatus[]>( "api/MyApprovals?ID=" + ID + "&BranchId=" + BranchID + "&key=" + key);
        }
        public async Task<IList<dtInvVoucherStatus>> Approvals( int BranchID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<dtInvVoucherStatus[]>("api/MyApprovals/Approvals?BranchID=" + BranchID + "&key=" + key);
        }
        public async Task<IList<dtInvVoucherStatus>> MyApprovalsStatus(int ID, long VID, int BranchID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<dtInvVoucherStatus[]>("api/MyApprovals/MyApprovalsStatus?ID=" + ID + "&VID=" + VID + "&BranchID=" + BranchID + "&key=" + key);
        }
            public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
