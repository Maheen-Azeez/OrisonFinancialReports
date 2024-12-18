using Microsoft.AspNetCore.Components;
using System.Data;
using System.Collections.ObjectModel;
using OrisonMIS.Shared.Entities.Inventory;
using OrisonMIS.Client.Logics.Contract.Inventory;
using Blazored.SessionStorage;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Inventory
{
    public class InvTransactionsManager : IInvTransactionsManager
    {

        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        string? key;
        public InvTransactionsManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.SessionStorage = SessionStorage;
            this.httpClient = httpClient;

        }

        public Task<long> CreateTransactions(dtInvTransactions trans, IDbConnection db, IDbTransaction tran)
        {
            throw new NotImplementedException();
        }
        public void UpdateTransactions(dtInvTransactions trans, IDbConnection db, IDbTransaction tran)
        {
            throw new NotImplementedException();
        }

        public async Task<ObservableCollection<dtInvTransactions>> GetTransactions(long vid, string Criteria)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<ObservableCollection<dtInvTransactions>>("api/dtInvTransactions?VId=" + vid + "&Criteria=" + Criteria + "&key=" + key);
        }
        public async Task<ObservableCollection<dtInvTransactions>> GetImportTransactions(long vid, string SBasicType, string DBasicType)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<ObservableCollection<dtInvTransactions>>("api/dtInvTransactions/" + vid + "/" + SBasicType + "/" + DBasicType + "/" + key);
        }
    }
}
