using Dapper;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.General;
using System.Data;

namespace OrisonMIS.Server.Concrete.General
{
    public class UserRightsManager : IUserRightsManager
    {
        private readonly IDapperManager _dapperManager;

        public UserRightsManager(IDapperManager dapperManager)
        {
            _dapperManager = dapperManager;
        }
        public async Task<UserRights> GetUserRights(int ID, string Keyword, string Module, int BranchID, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("userid", ID, DbType.Int32);
            dbPara.Add("Keyword", Keyword, DbType.String);
            dbPara.Add("Module", Module, DbType.String);
            dbPara.Add("BranchId", BranchID, DbType.Int32);
            //dbPara.Add("type", "UserRights", DbType.String);
            //var _UserRights = Task.FromResult(_dapperManager.Get<UserRights>
            //                    ("[FINWEB_INVENTORYVoucherSP]", key, dbPara,
            //                    commandType: CommandType.StoredProcedure));
            var _UserRights = Task.FromResult(_dapperManager.Get<UserRights>
                                ("[FINWEB_PortalUserKeywordPermission]", key, dbPara,
                                commandType: CommandType.StoredProcedure));
            return await _UserRights;
        }
        public async Task<bool> GetMenuRight(string Criteria, string Keyword, string Module, int BranchID, int UserID, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("UserID", UserID, DbType.Int32);
            dbPara.Add("Keyword", Keyword, DbType.String);
            dbPara.Add("Module", Module, DbType.String);
            dbPara.Add("BranchID", BranchID, DbType.Int32);
            dbPara.Add("Criteria", Criteria, DbType.String);
            var _MenuRight = Task.FromResult(_dapperManager.Get<bool>
                                ("[FinRep_MIS_GetSP]", key,dbPara,
                                commandType: CommandType.StoredProcedure));
            return await _MenuRight;
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
