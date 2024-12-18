using System.Data;

namespace OrisonMIS.Client.Logics.Contract.General
{
    public interface IDBOperation
    {
        public DataTable GetTable(string CommandText);
        public DataTable GetTable(string CommandText, String ConnectionString);
        public DataTable GetTable(string CommandText, DataTable dt);
        public Object GetScalar(string CommandText);
        public void ExecuteQuery(string CommandText);
        public int Query(string CommandText);
        Task<int> GetVtype(string vtype);
        Task<int> GetApprovalID(int k, string vtype, int AccountID);
        Task<int> GetBranchID(int vid);
        public DataTable GetUserInfo(String UserName, String ConnectionString);
        Task<int> GetNextNo(int vtype, int branchId);
        public String GetUserAuthenticated(String UserName, String Password, String ConnectionString);

        Task<string> GetBudget(long AccId, string Fiancialyear, int branchId);
        public String NewNumber(int vtype, DateTime d, int _BranchId);

        public String PasswordDecode(string Pwd);
        public String PasswordEncode(string Pwd);
    }
}
