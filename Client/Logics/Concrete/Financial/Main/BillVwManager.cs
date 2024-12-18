using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Client.Logics.Contract.Financial.Main;
using OrisonMIS.Shared.Entities.Financial;
using Syncfusion.Blazor.Diagrams;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Financial.Main
{
    public class BillVwManager : IBillVw
    {
        string? key;
        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;

        public BillVwManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;

        }
        public async Task<IEnumerable<BillVw>> ShowBills(long AccID, long BranchID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<BillVw[]>("api/BillsVw?AccId=" + AccID + "&BranchId=" + BranchID + "&key=" + key);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
