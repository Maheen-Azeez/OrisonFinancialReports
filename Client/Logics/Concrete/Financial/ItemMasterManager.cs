
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Client.Logics.Contract.Financial;
using OrisonMIS.Shared.Entities.Financial;
using OrisonMIS.Shared.Entities.General;
using Syncfusion.Blazor.Diagrams;
using System.Net.Http.Json;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Financial
{
    public class ItemMasterManager : IItemMasterManager
    {

        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        string? key;
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
        public ItemMasterManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;

        }
        public async Task<IEnumerable<string>> GetCombo(string Criteria)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<IEnumerable<string>>("api/ItemMaster/GetCombo?Criteria=" + Criteria + "&key=" + key);
        }

        public async Task<HttpResponseMessage> CreateItemMaster(dtItemMaster ItemMaster)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.PostAsJsonAsync("api/ItemMaster?key=" + key, ItemMaster);
        }
        public async Task<IEnumerable<dtItemMaster>> GetItemMaster(string ID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            if (ID.ToString() == "")
                return await httpClient.GetJsonAsync<IEnumerable<dtItemMaster>>("api/ItemMaster/GetItemMaster?ItemID=" + null + "&key=" + key);
            else
                return await httpClient.GetJsonAsync<IEnumerable<dtItemMaster>>("api/ItemMaster/GetItemMaster?ItemID=" + ID + "&key=" + key);
        }

        public async Task<List<dtInvAccounts>> GetAccountsCombo(string Description, string Criteria)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<List<dtInvAccounts>>("api/ItemMaster/GetAccountsCombo?Description=" + Description + "&Criteria=" + Criteria + "&key=" + key);
        }
    }
}
