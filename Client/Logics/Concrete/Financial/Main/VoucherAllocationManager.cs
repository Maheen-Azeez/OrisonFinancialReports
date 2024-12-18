using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Client.Logics.Contract.Financial.Main;
using OrisonMIS.Shared.Entities.Financial;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Financial.Main
{
    public class VoucherAllocationManager : IVoucherAllocation
    {

        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        string? key;

        public VoucherAllocationManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;

        }
        public async Task<IEnumerable<VoucherAllocation>> ShowAllocation(long AccId, long VID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<VoucherAllocation[]>("api/VoucherAllocation?AccId=" + AccId + "&VID=" + VID + "&key=" + key);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
