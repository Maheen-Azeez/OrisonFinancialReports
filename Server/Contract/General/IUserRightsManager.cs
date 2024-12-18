using OrisonMIS.Shared.Entities.General;

namespace OrisonMIS.Server.Contract.General
{
    public interface IUserRightsManager
    {
        public Task<UserRights> GetUserRights(int ID, string Keyword, string Module, int BranchID, string key);
        public Task<bool> GetMenuRight(string Criteria, string Keyword, string Module, int BranchID, int UserID, string key);
    }
}
