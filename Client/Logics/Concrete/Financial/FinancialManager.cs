using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Client.Logics.Contract.Financial;
using OrisonMIS.Shared.Entities;
using OrisonMIS.Shared.Entities.Financial;
using System.Net.Http.Json;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Financial
{
    public class FinancialManager : IFinancialManager
    {
        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        string? key;
        public FinancialManager(HttpClient httpClient, ISessionStorageService SessionStorage) {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;
        }
        public async Task<dtFinancialRegisterPaging> GetData(int BranchId, string DateFrom, string DateTo, int pageNumber, int pageSize, string Search, string action, string? VType)
        {
            try
            {
                // Retrieve the token key from session storage
                var key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));

                // Make the API call with the updated parameters
                var response = await httpClient.GetJsonAsync<dtFinancialRegisterPaging>($"api/Financial?BranchId={BranchId}&_FD={DateFrom}&_TD={DateTo}&pageNumber={pageNumber}&pageSize={pageSize}&Search={Search}&action={action}&VType={VType}&key={key}");
                return response;
            }
            catch (Exception ex)
            {
                // Handle exceptions
                throw ex;
            }
        }
        public async Task<List<dtFinancialRegister>> GetData(int BranchId, string DateFrom, string DateTo)
        {
            try
            {
                key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
                return await httpClient.GetFromJsonAsync<List<dtFinancialRegister>>("api/Financial?BranchId=" + BranchId + "&_FD=" + DateFrom + "&_TD=" + DateTo + "&key=" + key);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<dtFinancialRegister>> GetDataByID(int BranchId, int VId)
        {
            try
            {
                key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
                return await httpClient.GetJsonAsync<List<dtFinancialRegister>>("api/Financial/GetDataByID?BranchId=" + BranchId + "&VId=" + VId + "&key=" + key);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<dtInvoiceWiseSales>> GetInvoiceWiseSales(int BranchId, string DateFrom, string DateTo, string? VType)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<List<dtInvoiceWiseSales>>("api/Financial/InvoiceWiseSales?BranchId=" + BranchId + "&_FD=" + DateFrom + "&_TD=" + DateTo + "&VType=" + VType + "&key=" + key);
        }

        public async Task<List<dtMonthwiseSales>> GetMonthWiseSales(int BranchId, string DateFrom, string DateTo, string? VType, int year)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<List<dtMonthwiseSales>>("api/Financial/MonthWiseSales?BranchId=" + BranchId + "&VType=" + VType + "&year=" + year +"&key=" + key);
        }

        public async Task<List<dtSalesAnalysis>> GetSalesDateWIse(int BranchId, string DateFrom, string DateTo, string? VType)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<List<dtSalesAnalysis>>("api/Financial/DateWiseSales?BranchId=" + BranchId + "&_FD=" + DateFrom + "&_TD=" + DateTo + "&VType=" + VType + "&key=" + key);
        }

        public async Task<List<dtTransaction>> GetTransaction(int BranchId, string DateFrom, string DateTo, string? VType)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<List<dtTransaction>>("api/Financial/GetTransaction?BranchId=" + BranchId + "&_FD=" + DateFrom + "&_TD=" + DateTo + "&VType=" + VType + "&key=" + key);
        }

        public async Task<List<dtFinancialRegister>> getVoucherEntry(long VID, int BranchID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<List<dtFinancialRegister>>($"api/Financial/GetVoucherEntry?VID={VID}&BranchID={BranchID}&key={key}");
        }

        public async Task<IList<string>> GetVType(int BranchId)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<string[]>("api/Financial/GetVType?BranchId=" + BranchId + "&key=" + key);
        }
    }
}
