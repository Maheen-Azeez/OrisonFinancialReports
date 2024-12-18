
using OrisonMIS.Shared.Entities.General;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrisonMIS.Logics.Contracts.General
{
   public  interface IVoucherMasterManager
    {
        Task<IEnumerable<dtVoucherMaster>> ListAll(int vtype,int userid, int BranchID);
        Task<IEnumerable<dtVoucherMaster>> Register(int vtype, int userid, string FDate, string TDate, int BranchID,string Criteria);
        Task<IEnumerable<dtVoucherMaster>> ImportVoucher(int User, string SBasicType, string DBasicType, int BranchID);
        Task<IEnumerable<dtVoucherMaster>> ImportVoucher(string SBasicType, string DBasicType, int BranchID, string Criteria,int user);
        Task<long> ListById(int vtype, int userid, int BranchID);
        Task<long> ListByVNo(int vtype, int userid, string VNo, int BranchID);
        public Task<int> Count(int BranchID);
    }
}
