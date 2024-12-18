using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Client.Logics.Contract.Inventory;
using OrisonMIS.Shared.Entities.General;
using OrisonMIS.Shared.Models;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Inventory
{
    public class InvAccounts : IInvAccounts
    {
       
        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        string? key;
        public InvAccounts(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;
           
        }

        public async Task<IEnumerable<dtInvAccounts>> GetAccounts(string AccCategory)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<IEnumerable<dtInvAccounts>>("api/dtInvAccounts?AccCategory=" + AccCategory + "&key=" + key);
            //throw new NotImplementedException();
        }
      
        public async Task<IEnumerable<dtInvAccounts>> GetAccountsByDesignation(string AccCategory, string Designation, string BranchID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<dtInvAccounts[]>("api/dtInvAccounts/"+ AccCategory + "/" + Designation+"/"+ BranchID + "/" + key);
            //throw new NotImplementedException();
        }
        public async Task<IEnumerable<dtInvAccounts>> GetAccountsbyID(int id,string Category)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<List<dtInvAccounts>>("api/dtInvAccounts/" + id +"/"+Category + "/" + key);
        }

        public async Task<IEnumerable<ParentLevel>> GetLevels()
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<List<ParentLevel>>("api/dtInvAccounts/GetLevel?key=" + key);
        }
    }
}
