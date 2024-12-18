using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using OrisonMIS.Logics.Contracts.General;
using OrisonMIS.Shared.Entities.General;
using OrisonMIS.Shared.Models;
using System.Web;

namespace OrisonMIS.Concrete.General
{
    public class VoucherMasterManager : IVoucherMasterManager
    {
       
        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        string? key;
        public VoucherMasterManager(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;
            
        }
        public async Task<IEnumerable<dtVoucherMaster>> ListAll(int vtype, int userid,int BranchID)
        {
            throw new NotImplementedException();
           
        }

        public async Task<IEnumerable<dtVoucherMaster>> Register(int vtype, int userid, string FDate, string TDate, int BranchID,string Criteria)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<dtVoucherMaster[]>("api/VoucherMasters/GetVoucherMaster?_vtype=" + vtype + "&_userid=" + userid + "&_FD=" + FDate+ "&_TD=" + TDate + "&BranchID=" + BranchID + "&Criteria=" + Criteria + "&key=" + key);
        }

        public async Task<IEnumerable<dtVoucherMaster>> ImportVoucher(int User,string SBasicType,string DBasicType, int BranchID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<dtVoucherMaster[]>("api/VoucherMasters/GetImportVoucher?SBasicType=" + SBasicType+ "&DBasicType=" + DBasicType + "&BranchID=" + BranchID + "&Criteria=" + "FillImportVouchersByAccId" + "&User=" + User + "&key=" + key);
        }

        public async Task<IEnumerable<dtVoucherMaster>> ImportVoucher(string SBasicType, string DBasicType, int BranchID, string Criteria,int user)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<dtVoucherMaster[]>("api/VoucherMasters/GetImportVoucher?SBasicType=" + SBasicType + "&DBasicType=" + DBasicType + "&BranchID=" + BranchID + "&Criteria=" + Criteria + "&User=" + user + "&key=" + key);
        }
        public async Task<long> ListById(int vtype, int userid, int BranchID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<long>("api/vouchermasters?vtype=" + vtype + "&userid+" + userid + "&BranchID=" + BranchID + "&key=" + key);
            // throw new NotImplementedException();
        }

        public async Task<long> ListByVNo(int vtype, int userid, string VNo, int BranchID)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetJsonAsync<long>("api/vouchermasters?id=" + vtype + "&userid=" + userid+ "&VNo=" + VNo + "&BranchID=" + BranchID + "&key=" + key);
           // throw new NotImplementedException();
        }

        public Task<int> Count( int BranchID)
        {
            throw new NotImplementedException();
        }
    }
}
