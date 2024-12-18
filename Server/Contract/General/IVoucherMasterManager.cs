using OrisonMIS.Shared.Entities.General;

namespace OrisonMIS.Server.Contract.General
{
    public interface IVoucherMasterManager : IDisposable
    {
        Task<List<dtVoucherMaster>> ListAll(int vtype, int userid, int BranchID, string key);
        Task<List<dtVoucherMaster>> Register(int vtype, int userid, DateTime FDate, DateTime TDate, int BranchID, string Criteria, string key);
        Task<List<dtVoucherMaster>> ImportVoucher(string SBasicType, string DBasicType, int BranchID, string Criteria, int User, string key);
        //Task<List<dtVoucherMaster>> ReceiptList(int vtype, int userid);
        //Task<List<dtVoucherMaster>> ReceiptList(int vtype, int userid, DateTime FDate, DateTime TDate);

        Task<long> ListById(int vtype, int userid, int branchID, string key);
        Task<long> ListByVNo(int vtype, int userid, string VNo, int BranchID, string key);
        public Task<int> Count(int BranchID, string key);
    }
}
