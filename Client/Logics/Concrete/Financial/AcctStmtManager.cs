using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Client.Logics.Contract.Financial;
using OrisonMIS.Shared.Entities.Financial;
using OrisonMIS.Shared.Entities.General;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Financial
{
    public class AcctStmtManager : IAccStmt

    {

        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        string? key;
        public AcctStmtManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;

        }
        public void Dispose()
        {
        }
        public async Task<ObservableCollection<AcctStmt>> ShowStatementDetails(long BranchId, string DateFrom, string DateTo, int AccountID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<ObservableCollection<AcctStmt>>("api/AcctStmt?AccountID=" + AccountID + "&BranchId=" + BranchId + "&_FD=" + DateFrom + "&_TD=" + DateTo + "&key=" + key);
        }
        
        public async Task<HttpResponseMessage> Show(long BranchId, string DateFrom, string DateTo, object AccountID, StatementType statementType)
        {

            var key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            var apiUrl = $"api/AcctStmt?AccountID={AccountID}&BranchId={BranchId}&_FD={DateFrom}&_TD={DateTo}&statementType={statementType}&key={key}";

            return await httpClient.GetAsync(apiUrl);


        }

        public async Task<IEnumerable<BankDetails>> ShowBank(long BranchId)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<BankDetails[]>("api/AcctStmt/GetBank?BranchId=" + BranchId + "&key=" + key);
        }
        public async Task<IEnumerable<BankDetails>> ShowYearwise(string AccCategory, long BranchId)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<BankDetails[]>("api/AcctStmt/GetYearwise?AccCategory=" + AccCategory + "&BranchId=" + BranchId + "&key=" + key);
        }
        public async Task<IEnumerable<MonthlyProfit>> ShowProfit(long BranchId, string DateFrom, string DateTo)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<MonthlyProfit[]>("api/AcctStmt/GetMonthlyProfit?BranchId=" + BranchId + "&FD=" + DateFrom + "&TD=" + DateTo + "&key=" + key);
        }
        public async Task<IEnumerable<BudgetReg>> ShowBudget(long BranchId, string DateFrom, string DateTo, string finyear)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<BudgetReg[]>("api/AcctStmt/GetBudget?BranchId=" + BranchId + "&FD=" + DateFrom + "&TD=" + DateTo + "&finyear=" + finyear + "&key=" + key);
        }
        public async Task<ObservableCollection<TrialBal>> ShowTB(long BranchId, string DateFrom, string DateTo, string opening)
        {
            try
            {
                key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
                return await httpClient.GetJsonAsync<ObservableCollection<TrialBal>>("api/AcctStmt/GetTB?BranchId=" + BranchId + "&FD=" + DateFrom + "&TD=" + DateTo + "&opening=" + opening + "&SP=" + "TB" + "&key=" + key);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public async Task<ObservableCollection<TrialBal>> ShowTBDetailed(long BranchId, string DateFrom, string DateTo, string opening)
        {
            try
            {
                key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
                return await httpClient.GetJsonAsync<ObservableCollection<TrialBal>>("api/AcctStmt/GetTBDetailed?BranchId=" + BranchId + "&FD=" + DateFrom + "&TD=" + DateTo + "&opening=" + opening + "&SP=" + "TB" + "&key=" + key);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public async Task<IEnumerable<PDC>> ShowPDC(long BranchId, string status)
        {
            if (status == null)
                status = "All";
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<PDC[]>("api/PartyRegister?BranchId=" + BranchId + "&status=" + status + "&key=" + key);
        }

        public async Task<List<dtInvAccounts>> GetStaffAccounts(int branchId)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<List<dtInvAccounts>>("api/AcctStmt/StaffAccounts?branchId=" + branchId + "&key=" + key);
        } 
        public async Task<List<dtInvAccounts>> CheckPermissionAndGetStaffAccount(int userId, string keyWord, string module, int branchId, string userCategory)
        {
            string key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));

            string url = $"api/AcctStmt/check-permission-and-get-staff-account?" +
                         $"branchId={branchId}&key={key}&userId={userId}&keyWord={keyWord}&module={module}&userCategory={userCategory}&key={key}";

            return await httpClient.GetJsonAsync<List<dtInvAccounts>>(url);
        }
    }
}
