using Blazored.SessionStorage;
using OrisonMIS.Shared.Entities.General;
using OrisonMIS.Shared.Models;
using System.Net.Http.Json;
using System.Web;

namespace OrisonMIS.Client.Services
{
    public class TaxInvoiceService
    {
        int vtype, AccID, AID;
        int vNo;
        HttpClient http = new HttpClient();
        private readonly ISessionStorageService SessionStorage;
        private string? key;
        public TaxInvoiceService(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            http = httpClient;
            this.SessionStorage = SessionStorage;
          
        }
        public async Task<int> getVtype(string type)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));

            vtype = await http.GetFromJsonAsync<int>("api/Values/" + type + "/" + key);
            return vtype;
        }
        public async Task<int> GetApprovalID(int k, string vtype, int AccountID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));

            AID = await http.GetFromJsonAsync<int>("api/Values/" + k + "/" + vtype + "/" + AccountID + "/" + key);
            return AID;
        }

        public async Task<VtypeTran> getVtypeTran(int ID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));

            VtypeTran VtypeTran = await http.GetFromJsonAsync<VtypeTran>("api/VtypeTran/" + ID + "/" + key);
            return VtypeTran;
        }
        public async Task<Salesman> getSalesman(int ID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));

            Salesman Salesman = await http.GetFromJsonAsync<Salesman>("api/Salesman/" + ID + "/" + key);
            return Salesman;
        }
        public async Task<WarehouseMaster> getWarehouse(int ID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));

            WarehouseMaster Warehouse = await http.GetFromJsonAsync<WarehouseMaster>("api/Warehouse/" + ID + "/" + key);
            return Warehouse;
        }
        public async Task<IList<WarehouseMaster>> getWarehouse()
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));

            return await http.GetFromJsonAsync<WarehouseMaster[]>("api/Warehouse/" + key);
            //return (IList<WarehouseMaster>)Warehouse;
        }
        //int vtype, DateTime d, int _BranchId
        //public async Task<int> GetNextNoAsync(int vtype, string d, int _BranchId)
        public async Task<int> GetNextNoAsync(int vtype, int _BranchId)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));

            vNo = await http.GetFromJsonAsync<int>("api/Values/" + vtype + "/" + _BranchId + "/" + key);
            return vNo;
        }
        public async Task<int> getUniqueAccID(string val)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));

            AccID = await http.GetFromJsonAsync<int>("api/Uniqueaccounts?acckeyword=" + val + "&key=" + key);
            return AccID;
        }
        public async Task<object> getscalar(string cmd)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));

            var val = await http.GetFromJsonAsync<object>("api/values?cmd=" + cmd + "&key=" + key);
            return val;
        }
        public async Task<IEnumerable<FormLabel>> getFormLabels(string FormName)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));

            var FormLabelMast = await http.GetFromJsonAsync<IEnumerable<FormLabel>>("api/FormLabel?FormName=" + FormName + "&key=" + key);
            return FormLabelMast;
        }
    }
}
