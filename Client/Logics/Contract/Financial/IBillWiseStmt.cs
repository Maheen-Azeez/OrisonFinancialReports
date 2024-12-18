using OrisonMIS.Shared.Entities.Financial;

namespace OrisonMIS.Client.Logics.Contract.Financial
{
    public interface IBillWiseStmt
    {
        Task<IEnumerable<BillwiseStmt>> Show(long BranchId, string DateFrom, string DateTo, object AccountID);
    }
}
