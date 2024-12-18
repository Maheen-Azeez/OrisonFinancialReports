using OrisonMIS.Shared.Entities.General;

namespace OrisonMIS.Server.Contract.General
{
    public interface IInvAccounts : IDisposable
    {
        public Task<List<dtInvAccounts>> GetAllAccounts(string key);
        public Task<List<dtInvAccounts>> GetAccounts(string AccCategory, string key);
        public Task<List<ParentLevel>> GetLevel(string key);
        public Task<List<dtInvAccounts>> GetAccountsByDesignation(string AccCategory, string Designation, string BranchID, string key);
        public Task<List<dtInvAccounts>> GetAccountsbyID(int id, string AccCategory, string key);
    }
}
