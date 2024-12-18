using OrisonMIS.Shared.Entities.General;

namespace OrisonMIS.Server.Contract.General
{
    public interface IDBOperation : IDisposable
    {
        Task<int> GetVtype(string vtype, string key);
        Task<int> GetApprovalID(int k, string vtype, int user, string key);
        Task<int> GetBranchID(int vid, string key);
        Task<VtypeTrans> GetVtypeTran(int ID, string key);
        Task<WarehouseMaster> GetWarehouse(int ID, string key);
        Task<List<string>> GetMasterMisc(string Source, string key);
        Task<List<WarehouseMaster>> GetWarehouse(string key);
        Task<List<BranchMaster>> GetSchoolBranch(string key);
        Task<List<BranchMaster>> GetUserBranch(int userid, string key);
        Task<Salesman> GetSalesman(int ID, string key);
        Task<List<FormLabel>> GetFormLabels(string FormName, string key);
        Task<int> GetNextNo(int vtype, int branchId, string key);
        Task<object> GetScalar(string cmd, string key);
        string IsSchool(string key);
        object GetScalarValue(string cmd, string key);
        Task<string> GetBalance(long AccId, int branchId, string key);
        Task<List<Budget>> GetBudget(long AccId, string Fiancialyear, int branchId, string key);
        Task<List<string>> GetFinYear(string key);

        public string PasswordDecode(string Pwd, string key);
        public string PasswordEncode(string Pwd, string key);
        Task<string> getHomeUrl(int AccountID, string key);
        Task<string> getLogoutUrl(int AccountID, string key);
        Task<List<string>> GetList(string cmd, string key);
    }
}
