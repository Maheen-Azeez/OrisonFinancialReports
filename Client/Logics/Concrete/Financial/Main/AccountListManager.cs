using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Client.Logics.Contract.Financial.Main;
using OrisonMIS.Shared.Entities.Financial.Main;
using System.Collections.Specialized;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Financial.Main
{
    public class AccountListManager : IAccountList
    {
        string? key;
        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;

        public AccountListManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;

        }
        public async Task<IEnumerable<AccountList>> GetAccounts(string AccList, long BranchID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<AccountList[]>("api/AccountList?AccList=" + AccList + "&BranchId=" + BranchID + "&key=" + key);
        }

    }
}
