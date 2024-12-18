using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Client.Logics.Contract.Financial.Main;
using OrisonMIS.Shared.Entities.Financial.Main;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Financial.Main
{
    public class ChequeManager : ICheque
    {
        private string? key;
        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;

        public ChequeManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.SessionStorage = SessionStorage;

        }
        public async Task<IEnumerable<Cheque>> ShowCheque(long VID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<Cheque[]>("api/Cheque?VId=" + VID + "&key=" + key);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
