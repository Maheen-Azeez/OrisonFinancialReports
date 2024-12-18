using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Client.Logics.Contract.Inventory;
using OrisonMIS.Shared.Entities.Inventory;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Inventory
{
    public class InvItemsManager : IInvItemsManager
    {

        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        string? key;
        public InvItemsManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.SessionStorage = SessionStorage;
            this.httpClient = httpClient;

        }

        public async Task<IEnumerable<dtItems>> GetItems(int BranchID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<dtItems[]>("api/dtItems/" + BranchID + "/" + key);
        }

        public async Task<dtItems> GetItemsbyID(int BranchID, int ItemID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<dtItems>("api/dtItems/" + BranchID + "/" + ItemID + "/" + key);
        }
    }
}
