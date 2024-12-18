using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Client.Logics.Contract.Inventory;
using OrisonMIS.Shared.Entities.General;
using Syncfusion.Blazor.Diagrams;
using System.Net.Http.Json;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Inventory
{
    public class InvAccountManager : IInvAccountManager
    {

        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        string? key;
        public InvAccountManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;


        }
        public async Task<List<dtInvAccounts>> ListAll()
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            var Employee = await httpClient.GetJsonAsync<List<dtInvAccounts>>("api/InvAccounts?key=" + key);
            return Employee;
        }
        public async Task<List<dtInvAccounts>> ListAllByCategory(string Category)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            var Employee = await httpClient.GetJsonAsync<List<dtInvAccounts>>("api/dtInvAccounts?AccCategory=" + Category + "&key=" + key);
            return Employee;
        }

        public async Task<HttpResponseMessage> SaveAdd(dtInvAccounts Acc)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.PostAsJsonAsync("api/InvAccounts?key=" + key, Acc);
        }

        public async Task<List<string>> GetCompanyName()
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            var CompanyName = await httpClient.GetJsonAsync<List<string>>("api/InvAccounts/getCompany?key=" + key);
            return CompanyName;
        }
        public async Task<List<string>> GetCurrency()
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            var Currency = await httpClient.GetJsonAsync<List<string>>("api/InvAccounts/getCurrency?key=" + key);
            return Currency;
        }

        public async void EditRemark(int id, string Remarks)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            await httpClient.PutJsonAsync("api/InvAccounts/" + id.ToString() + "/" + key, Remarks);

        }
        public async Task<string> NextCode(string Category)
        {
            string s = "0";
            try
            {
                key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
                s = await httpClient.GetStringAsync("api/InvAccounts/" + Category + "/" + key);
                return s;
            }
            catch (Exception ex)
            { }
            return s;

        }

    }
}
