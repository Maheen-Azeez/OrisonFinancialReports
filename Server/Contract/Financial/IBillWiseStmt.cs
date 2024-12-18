using OrisonMIS.Shared.Entities.Financial;

namespace OrisonMIS.Server.Contract.Financial
{
    public interface IBillWiseStmt:IDisposable
    {
        Task<List<BillwiseStmt>> Show(long BranchId, DateTime DateFrom, DateTime DateTo, object AccountID, string key);
    }
}
