using OrisonMIS.Shared.Entities.General;

namespace OrisonMIS.Client.Logics.Contract.Inventory
{
    public interface IInvAccountManager
    {
        Task<HttpResponseMessage> SaveAdd(dtInvAccounts Acc);
        public Task<List<dtInvAccounts>> ListAll();
        public Task<List<dtInvAccounts>> ListAllByCategory(string Category);
        public Task<List<string>> GetCompanyName();
        public Task<List<string>> GetCurrency();
        public void EditRemark(int id, string Remarks);
        public Task<string> NextCode(string Category);



    }
}
