using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Client.Logics.Contract.Inventory;
using OrisonMIS.Shared.Entities.Inventory;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Inventory
{
    public class InvGroupItemsManager : IInvGroupItemsManager
    {

        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        string? key;
        public InvGroupItemsManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;

        }

        public async Task<IEnumerable<dtInvGroupItems>> GetGroupItems(int id)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<dtInvGroupItems[]>("api/dtInvGroupItem?id=" + id.ToString() + "&key=" + key);
        }
    }
}
