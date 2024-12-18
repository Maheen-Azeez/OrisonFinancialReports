using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Client.Logics.Contract.Financial;
using OrisonMIS.Shared.Entities.Financial;
using Syncfusion.Blazor.Diagrams;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Financial
{
    public class PartyRegisterManager : IPartyRegister
    {

        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        string? key;
        public PartyRegisterManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;

        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
        public async Task<IEnumerable<PartyRegister>> Show(string AccCategory, long BranchId)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<PartyRegister[]>("api/PartyRegister?AccCategory=" + AccCategory + "&BranchId=" + BranchId + "&key=" + key);
        }
    }
}
