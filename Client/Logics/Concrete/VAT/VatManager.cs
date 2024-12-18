using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Client.Logics.Contract.VAT;
using OrisonMIS.Shared.Entities.Inventory;
using OrisonMIS.Shared.Entities.VAT;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.VAT
{
    public class VatManager : IVatManager
    {
        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        string? key;
        public VatManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.SessionStorage = SessionStorage;
            this.httpClient = httpClient;

        }
        public async Task<VatReportsDto> GetReports(string dateFrom, string dateTo, int branchId)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<VatReportsDto>($"api/Vat/VatReport?dateFrom={dateFrom}&dateTo={dateTo}&branchid={branchId}&key={key}");
        }
    }
}
