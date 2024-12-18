using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Client.Logics.Contract.Financial.Main;
using OrisonMIS.Shared.Entities.Financial;
using Syncfusion.Blazor.Diagrams;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Financial.Main
{
    public class VEntryManager : IVEntry
    {
        string? key;
        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;

        public VEntryManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;

        }
        public async Task<IEnumerable<VEntry>> Show(long VId)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<VEntry[]>("api/VEntry?VId=" + VId + "&key=" + key);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
