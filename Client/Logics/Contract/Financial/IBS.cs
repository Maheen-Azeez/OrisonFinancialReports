using OrisonMIS.Shared.Entities.Financial;

namespace OrisonMIS.Client.Logics.Contract.Financial
{
    public interface IBS
    {
        Task<IEnumerable<BalanceSheet>> Show(long BranchId, string DateFrom, string DateTo, string SP);
    }
}
