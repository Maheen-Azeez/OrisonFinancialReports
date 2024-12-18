using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using OrisonMIS.Client.Logics.Contract.Financial;
using OrisonMIS.Shared.Entities.Financial;
using OrisonMIS.Shared.Entities.General;
using System.Dynamic;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Financial
{
    public class ConsolidatedManager : IConsolidated

    {

        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        string? key;
        public ConsolidatedManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;

        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
        public async Task<IEnumerable<Consolidated>> Show(long BranchId, string DateFrom, string DateTo, object AccountID, object Group, string AccYear, string SP, string selectedCriteria)
        {
            try
            {
                key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
                return await httpClient.GetJsonAsync<Consolidated[]>("api/Consolidated?AccountID=" + AccountID + "&BranchId=" + BranchId + "&_FD=" + DateFrom + "&_TD=" + DateTo + "&Group=" + Group + "&AccYear=" + AccYear + "&SP=" + SP + "&selectedCriteria=" + selectedCriteria + "&key=" + key );

            }
            catch (Exception e)
            {

                throw e;
            }        
        }
        public async Task<IEnumerable<AgingDetail>> GetAgingDetails()
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<AgingDetail[]>("api/Consolidated/Aging?key=" + key);
        }

        //public async Task<IEnumerable<ConsolidatedBranchWise>> getConsolidatedBranchWise(long BranchId, string DateFrom, string DateTo, object AccountID, object Group, string AccYear, string SP, string selectedCriteria)
        //{
        //    key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
        //    return await httpClient.GetJsonAsync<ConsolidatedBranchWise[]>("api/Consolidated/ConsolidatedBranchWise?AccountID=" + AccountID + "&BranchId=" + BranchId + "&_FD=" + DateFrom + "&_TD=" + DateTo + "&Group=" + Group + "&AccYear=" + AccYear + "&SP=" + SP + "&selectedCriteria=" + selectedCriteria + "&key=" + key);
        //}
        public async Task<IEnumerable<ExpandoObject>> getConsolidatedBranchWise(long BranchId, string DateFrom, string DateTo, object AccountID, object Group, string AccYear, string SP, string selectedCriteria)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            try
            {
                List<ExpandoObject> Result = new List<ExpandoObject>();
                var report = await httpClient.GetJsonAsync<List<object>>("api/Consolidated/ConsolidatedBranchWise?AccountID=" + AccountID + "&BranchId=" + BranchId + "&_FD=" + DateFrom + "&_TD=" + DateTo + "&Group=" + Group + "&AccYear=" + AccYear + "&SP=" + SP + "&selectedCriteria=" + selectedCriteria + "&key=" + key);
                foreach (var d in report)
                {
                    Result.Add(JsonConvert.DeserializeObject<ExpandoObject>(d.ToString()));
                }
                return Result;
            }

            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
