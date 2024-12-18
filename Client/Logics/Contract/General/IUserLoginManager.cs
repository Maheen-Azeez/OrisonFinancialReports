using OrisonMIS.Shared.Entities.General;

namespace OrisonMIS.Client.Logics.Contract.General
{
    public interface IUserLoginManager
    {
        public Task<IEnumerable<UserLogin>> GetUserData(int UserID, int BranchID);
        public Task<IEnumerable<UserLogin>> GetUserDataAllBranches(int UserID);
        public Task<IEnumerable<MenuMasterData>> GetMenuData(int UserID, string BranchID);
    }
}
