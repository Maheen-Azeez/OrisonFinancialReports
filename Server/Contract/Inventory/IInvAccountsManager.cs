using OrisonMIS.Shared.Entities.General;

namespace OrisonMIS.Server.Contract.Inventory
{
    public interface IInvAccountsManager : IDisposable
    {
        public Task<List<string>> GetCompanyName(string key);
        public Task<List<string>> GetCurrency(string key);
        public void SetRemarks(int id, string Remarks, string key);
        Task<List<dtInvAccounts>> GetCustomers(string key);
        Task<bool> SaveAdd(dtInvAccounts Customer, string key);
        bool saveAccounts(ref dtInvAccounts Customer, string key);
        bool savePersonal(ref dtInvAccounts Customer, string key);
        Task<string> GetAccountCode(string Category, string key);
        string GetNextNumFn(string Catgeory, string key);
    }
}
