using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Client.Logics.Contract.Financial;
using OrisonMIS.Shared.Entities.Financial;
using Syncfusion.Blazor.Diagrams;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Financial
{
    public class BillWiseStmtManager : IBillWiseStmt
    {

        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        string? key;
        public BillWiseStmtManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;

        }

        public async Task<IEnumerable<BillwiseStmt>> Show(long BranchId, string DateFrom, string DateTo, object AccountID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<BillwiseStmt[]>("api/BillwiseStmt?AccountID=" + AccountID + "&BranchId=" + BranchId + "&_FD=" + DateFrom + "&_TD=" + DateTo + "&key=" + key);
        }

        public void Dispose()
        {
            // throw new NotImplementedException();
        }
    }
}
