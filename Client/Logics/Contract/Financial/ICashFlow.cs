using OrisonMIS.Shared.Entities.Financial;

namespace OrisonMIS.Client.Logics.Contract.Financial
{
    public interface ICashFlow
    {
        Task<IEnumerable<CashFlow>> Show(long BranchId, string DateFrom, string DateTo);

    }
}
