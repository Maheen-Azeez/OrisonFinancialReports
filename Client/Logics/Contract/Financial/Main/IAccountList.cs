using OrisonMIS.Shared.Entities.Financial.Main;

namespace OrisonMIS.Client.Logics.Contract.Financial.Main
{
    public interface IAccountList
    {
        public Task<IEnumerable<AccountList>> GetAccounts(string AccList, long BranchId);
    }
}
