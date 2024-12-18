namespace OrisonMIS.Server.Contract.General
{
    public interface IOrisonManager
    {
        public Task<List<object>> Get(string head, string schoolCode, int branchId, string key);
        public Task<List<object>> Get(string Head, string SchoolCode, DateTime fromdate, DateTime todate, int branchId, string key);
        public Task<List<object>> Get(String Head, String SchoolCode, DateTime fromdate, DateTime todate, int Branchid, int AccountID, string key);
    }
}
