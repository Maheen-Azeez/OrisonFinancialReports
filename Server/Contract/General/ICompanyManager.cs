namespace OrisonMIS.Server.Contract.General
{
    public interface ICompanyManager
    {
        Task<string> getLogo(int BranchID, string key);
        Task<string> getLogoUrl(string key);
        Task<List<object>> GetCompanyDetails(int BranchID, string key);

    }
}
