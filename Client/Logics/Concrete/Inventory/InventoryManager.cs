using Blazored.SessionStorage;
using OrisonMIS.Client.Logics.Contract.Inventory;
using OrisonMIS.Shared.Entities.Inventory;
using System.Net.Http.Json;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Inventory
{
    public class InventoryManager : IInventoryManager
    {
       
        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        string? key;
        public InventoryManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;
            
        }

        public async Task<HttpResponseMessage> CreateInventory(dtsInventory Inventory)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.PostAsJsonAsync("api/Inventory?key" + key, Inventory);
        }

        //public async Task<HttpResponseMessage> UpdateInventory(dtsInventory Inventory)
        //{
        //    return await httpClient.PostAsJsonAsync(BaseUrl + "Inventory", Inventory);
        //}

    }
}
