using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Client.Logics.Contract.Financial.Main;
using OrisonMIS.Shared.Entities.General;
using Syncfusion.Blazor.Diagrams;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Financial.Main
{
    public class ReceiptManager : IReceiptManager
    {

        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        private string? key;

        public ReceiptManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;

        }


        public async Task<IEnumerable<dtVoucherMaster>> ReceiptList(int vtype, int Id)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<dtVoucherMaster[]>("api/receipt?vtype=" + vtype + "&Id=" + Id + "&key=" + key);
        }
    }
}
