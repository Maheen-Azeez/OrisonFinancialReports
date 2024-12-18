using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Client.Logics.Contract.Inventory;
using OrisonMIS.Shared.Entities.Inventory;
using Syncfusion.Blazor.Diagrams;
using System.Collections.ObjectModel;
using System.Data;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Inventory
{
    public class InvVoucherEntryManager : IInvVoucherEntryManager
    {
       
        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        string? key;
        public InvVoucherEntryManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;
            
        }

        public Task<long> CreateVoucherEntry(dtInvVoucherEntry dtInvVoucherEntry, IDbConnection db, IDbTransaction tran)
        {
            throw new NotImplementedException();
        }

        public async Task<ObservableCollection<dtInvVoucherEntry>> GetVoucherEntry(long vid)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<ObservableCollection<dtInvVoucherEntry>>( "api/dtInvVoucherEntries?VId=" + vid + "&key=" + key);
        }
    }
}
