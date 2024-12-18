using OrisonMIS.Shared.Entities.Financial.Main;

namespace OrisonMIS.Server.Contract.Financial.Main
{
    public interface IAccountList : IDisposable
    {
        Task<List<AccountList>> Get(string AccList, long BranchId, string key);
    }
}
