using Blazored.SessionStorage;
using OrisonMIS.Client.Logics.Contract.Inventory;
using OrisonMIS.Shared.Entities.Financial;
using OrisonMIS.Shared.Entities.Inventory;
using System.Net.Http.Json;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Inventory
{
    public class InventoryRegisterManager : IInventoryRegisterManager
    {
        private readonly HttpClient httpClient;
        private readonly ISessionStorageService sessionStorage;
        private string? key;
        public InventoryRegisterManager(HttpClient httpClient, ISessionStorageService sessionStorage)
        {
            this.httpClient = httpClient;
            this.sessionStorage = sessionStorage;
        }

        public async Task<List<InventoryRegisterDto>> FetchInventoryRegister(int branchId, string dateFrom, string dateUpTo, int itemId, int categoryId)
        {
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<List<InventoryRegisterDto>>("api/Inventory/GetInventoryRegister?branchId=" + branchId + "&dateFrom=" + dateFrom + "&dateUpTo=" + dateUpTo + "&itemId=" + itemId + "&categoryId=" + categoryId + "&key=" + key);
        }

        public async Task<List<InventoryItemMasterDto>> FetchItems(int branchId)
        {
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<List<InventoryItemMasterDto>>("api/Inventory/GetItems?branchId=" + branchId + "&key=" + key);
        }

        public async Task<List<StockRegisterDto>> FetchStockRegister(string dateUpTo, int branchId, int wareHouseId)
        {
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<List<StockRegisterDto>>("api/Inventory/GetStockRegister?branchId=" + branchId + "&dateUpTo=" + dateUpTo + "&wareHouseId=" + wareHouseId + "&key=" + key);
        }

        public async Task<List<WareHosueDto>> FetchWarehouses(int branchId)
        {
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<List<WareHosueDto>>("api/Inventory/GetWarehouses?branchId=" + branchId + "&key=" + key);
        }
        public async Task<List<CategoryDto>> FetchCategories(int branchId)
        {
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<List<CategoryDto>>("api/Inventory/GetCategories?branchId=" + branchId + "&key=" + key);
        }
    }
}
