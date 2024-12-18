using OrisonMIS.Logics.Contracts.General;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Shared.Entities.General;
using Blazored.SessionStorage;
using System.Web;

namespace OrisonMIS.Concrete.General
{
    public class EntryModeManager:IEntryModeManager
    {
        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        string? key;
        public EntryModeManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;
            
        }
        public async Task<IList<EntryModeMaster>> GetAllEntryMode()
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<EntryModeMaster[]>("api/EntryMode?key=" + key);
        }
        public async Task<EntryModeMaster> GetEntryMode(string type)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<EntryModeMaster>("api/EntryMode?type=" + type + "&key=" + key);
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
