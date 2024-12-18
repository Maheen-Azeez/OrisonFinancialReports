using OrisonMIS.Shared.Entities.Financial;
using OrisonMIS.Shared.Entities.General;

namespace OrisonMIS.Server.Contract.Financial
{
    public interface IConsolidated:IDisposable
    {
        Task<List<Consolidated>> Show(long BranchId, DateTime DateFrom, DateTime DateTo, object AccountID, object Group, string AccYear, string SP, string selectedCriteria, string key);
        Task<List<AgingDetail>> GetAgingDetails(string key);
        //Task<List<ConsolidatedBranchWise>> GetConsolidatedBranchWise(long branchId, DateTime fDate, DateTime tDate, long accountID, int group, string? accYear, string sP, string? selectedCriteria, string key);
        Task<List<object>> GetConsolidatedBranchWise(long branchId, DateTime fDate, DateTime tDate, long accountID, int group, string? accYear, string sP, string? selectedCriteria, string key);
    }
}
