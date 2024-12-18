using Microsoft.AspNetCore.Components;
using System.Data;
using OrisonMIS.Shared.Entities.Inventory;
using OrisonMIS.Client.Logics.Contract.Inventory;
using Blazored.SessionStorage;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Inventory
{
    public class InvVoucherAdditionalsManager : IInvVoucherAdditionalsManager
    {

        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        string? key;
        public InvVoucherAdditionalsManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;

        }

        public Task<long> CreateVoucherAdditionals(dtInvVoucherAdditionals dtInvVoucherAdditionals, IDbConnection db, IDbTransaction tran)
        {
            throw new NotImplementedException();
        }
        public void UpdateVoucherAdditionals(dtInvVoucherAdditionals dtInvVoucherAdditionals, IDbConnection db, IDbTransaction tran)
        {
            throw new NotImplementedException();
        }

        public async Task<dtInvVoucherAdditionals> GetVoucherAdditionals(long VId)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<dtInvVoucherAdditionals>("api/dtInvVoucherAdditionals?VId=" + VId + "&key=" + key);
        }
    }
}
