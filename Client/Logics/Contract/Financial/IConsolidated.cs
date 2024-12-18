using OrisonMIS.Shared.Entities.Financial;
using OrisonMIS.Shared.Entities.General;
using System.Dynamic;

namespace OrisonMIS.Client.Logics.Contract.Financial
{
    public interface IConsolidated
    {
        Task<IEnumerable<Consolidated>> Show(long BranchId, string DateFrom, string DateTo, object AccountID, object Group, string AccYear, string SP, string selectedCriteria );
        //Task<IEnumerable<ConsolidatedBranchWise>> getConsolidatedBranchWise(long BranchId, string DateFrom, string DateTo, object AccountID, object Group, string AccYear, string SP, string selectedCriteria );
        Task<IEnumerable<ExpandoObject>> getConsolidatedBranchWise(long BranchId, string DateFrom, string DateTo, object AccountID, object Group, string AccYear, string SP, string selectedCriteria );
        Task<IEnumerable<AgingDetail>> GetAgingDetails();
    }
}
