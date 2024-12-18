using OrisonMIS.Shared.Entities.General;

namespace OrisonMIS.Server.Contract.General
{
    public interface IUserLoginManager
    {
        public Task<List<UserLogin>> GetUserData(int AccountID, int BranchID, string key);
        public Task<List<UserLogin>> GetUserDataAllBranches(int UserID, string key);
        public Task<List<MenuMasterData>> GetMenuData(int UserID, string BranchID, string key);
        Task<string> UserPhoto(int id, string key);
    }
}
