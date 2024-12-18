using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Client.Logics.Contract.Financial.Main;
using OrisonMIS.Shared.Entities.Financial.Main;
using Syncfusion.Blazor.Diagrams;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Financial.Main
{
    public class VoucherManager : IVoucher
    {

        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        string? key;
        public VoucherManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;
        }
        public async Task<Voucher> ShowVoucher(long VId)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<Voucher>("api/Voucher?VId=" + VId + "&key=" + key);
        }
        public async Task<Voucher> VoucherImport(long VId)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<Voucher>("api/Voucher?VId=" + VId + "&key=" + key);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
