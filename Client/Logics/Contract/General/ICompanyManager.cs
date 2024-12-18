using System.Dynamic;

namespace OrisonMIS.Client.Logics.Contract.General
{
    public interface ICompanyManager
    {
        Task<string> getLogo(int BranchID);
        Task<string> getLogoUrl();
        public Task<List<ExpandoObject>> GetCompanyDetails(int BranchID);

    }
}
