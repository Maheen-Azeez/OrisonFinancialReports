using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Client.Logics.Contract.Inventory;
using OrisonMIS.Shared.Entities.Inventory;
using Syncfusion.Blazor.Diagrams;
using System.Data;
using System.Web;

namespace OrisonMIS.Client.Logics.Concrete.Inventory
{
    public class InvVoucherManager : IInvVoucherManager
    {
       
        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        string? key;
        public InvVoucherManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;
            
        }

        public Task<long> CreateVoucher(dtInvVoucher InvVoucher, IDbConnection db, IDbTransaction tran)
        {
            throw new NotImplementedException();
        }
        public void UpdateVoucher(dtInvVoucher InvVoucher, IDbConnection db, IDbTransaction tran)
        {
            throw new NotImplementedException();
        }
        public void CancelVoucher(long VId)
        {
            throw new NotImplementedException();
        }
        public void DeleteVoucher(long VId)
        {
            throw new NotImplementedException();
        }

        public async Task<dtInvVoucher> GetVoucher(long VId)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<dtInvVoucher>("api/dtInvVouchers?VId=" + VId + "&key=" + key);
        }
    }
}
