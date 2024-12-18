using Dapper;
using OrisonMIS.Server.Contract.Financial;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.Financial;
using System.Data;

namespace OrisonMIS.Server.Concrete.Financial
{
    public class PartyRegisterManager:IPartyRegister
    {
        private readonly IDapperManager _dapperManager;
        public PartyRegisterManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public void Dispose()
        {

        }

        public async Task<List<PartyRegister>> Show(string AccCategory, long BranchId, string key)
        {
            var dbPara = new DynamicParameters();
            string ProcName = "PartyListSP";
            dbPara.Add("AccCategory", AccCategory, DbType.String);
            dbPara.Add("BranchId", BranchId, DbType.Int32);
            //dtInvVoucher voucher = new dtInvVoucher();
            var PartyRegister = Task.FromResult(_dapperManager.GetAll<PartyRegister>
                                (ProcName,key, dbPara, commandType: CommandType.StoredProcedure));
            return await PartyRegister;
        }
    }
}
