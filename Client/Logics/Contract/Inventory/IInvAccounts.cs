using OrisonMIS.Shared.Entities.General;

namespace OrisonMIS.Client.Logics.Contract.Inventory
{
    public interface IInvAccounts
    {
        public Task<IEnumerable<dtInvAccounts>> GetAccounts(string AccCategory);
        public Task<IEnumerable<ParentLevel>> GetLevels();
        public Task<IEnumerable<dtInvAccounts>> GetAccountsByDesignation(string AccCategory, string Designation, string BranchID);
        public Task<IEnumerable<dtInvAccounts>> GetAccountsbyID(int id, string Category);
    }
}
