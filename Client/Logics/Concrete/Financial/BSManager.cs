using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Client.Logics.Contract.Financial;
using OrisonMIS.Shared.Entities.Financial;
using Syncfusion.Blazor.Diagrams;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Financial
{
    public class BSManager : IBS

    {

        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        string? key;
        public BSManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;

        }
        public void Dispose()
        {
            // throw new NotImplementedException();
        }
        public async Task<IEnumerable<BalanceSheet>> Show(long BranchId, string DateFrom, string DateTo, string SP)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<BalanceSheet[]>("api/BalanceSheet?BranchId=" + BranchId + "&_FD=" + DateFrom + "&_TD=" + DateTo + "&_SP=" + SP + "&key=" + key);
        }

    }
}
