using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Shared.Entities.General;
using System.Data;
using System.Net.Http.Json;
using System.Web;

namespace OrisonMIS.Client.Services
{
    public class FinServices
    {
        int vtype, BranchID;
        Budget[] Budget;
        string[] FinYear;
        object id;
        private readonly ISessionStorageService SessionStorage;
        private readonly HttpClient http;
        private string? key;
        public FinServices(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            http = httpClient;
            this.SessionStorage = SessionStorage;
           
        }

        public async Task<int> getVtype(string val)
        {
            vtype = await http.GetFromJsonAsync<int>( "api/Values/" + val);
            return vtype;
        }
        public async Task<object> GetScalar(string cmd)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await http.GetFromJsonAsync<object>("api/Values?cmd=" + cmd + "&key=" + key);
        }
        public async Task<int> GetBranchID(int VID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            BranchID = await http.GetFromJsonAsync<int>( "api/Login/" + VID + "/" + key);
            return BranchID;
        }
        public async Task<IList<Budget>> GetBudget(int AccId, string Financialyear, int branchId)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            Budget = await http.GetFromJsonAsync<Budget[]>("api/Budget/" + AccId + "/" + Financialyear + "/" + branchId + "/" + key);
            return Budget;
        }
        public async Task<IList<string>> GetFinYear()
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            FinYear = await http.GetFromJsonAsync<string[]>( "api/Budget?key=" + key);
            return FinYear;
        }
        public async Task<IList<string>> GetStringTable(string cmd)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            FinYear = await http.GetFromJsonAsync<string[]>("api/ValueSettings?cmd=" + cmd + "&key=" + key);
            return FinYear;
        }
        public async Task<IList<string>> GetMasterMisc(string Source)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await http.GetFromJsonAsync<string[]>( "api/ValueSettings/" + Source + "/" + key);

        }
        public async Task<IList<BranchMaster>> getBranch()
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await http.GetFromJsonAsync<BranchMaster[]>( "api/Home/" + key);
            //return (IList<WarehouseMaster>)Warehouse;
        }

        public async Task<DateTime> GetEntryFromDateTimeAsync(int branchId)
        {
            try
            {
                key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
                var query = $"api/DateTime/getentryfromdatetime?branchId={branchId}&key={key}";
                return await http.GetFromJsonAsync<DateTime>(query);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public async Task<FinancialDateTime> GetFinancialDateTimeAsync(int branchId)
        {
            try
            {
                key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
                var query = $"api/DateTime/GetFinancialDateTime?branchId={branchId}&key={key}";
                return await http.GetFromJsonAsync<FinancialDateTime>(query);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public async Task<DateTime> GetVatDateTimeAsync(int branchId)
        {
            try
            {
                key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
                var query = $"api/DateTime/VatDateTime?branchId={branchId}&key={key}";
                return await http.GetJsonAsync<DateTime>(query);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
 }
