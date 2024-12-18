using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Client.Logics.Contract.Financial.Main;
using OrisonMIS.Shared.Entities.Financial;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Financial.Main
{
    public class AccountAllocationManager : IAccountAllocation
    {
        private string? key;
        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;

        public AccountAllocationManager(HttpClient httpClient , ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;

        }
        public async Task<IEnumerable<VoucherAllocation>> AccountAllocation(long AccId, long VID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<VoucherAllocation[]>("api/AccountAllocation?AccId=" + AccId + "&VID=" + VID + "&key=" + key);
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
