using Dapper;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.General;
using System.Data;

namespace OrisonMIS.Server.Concrete.General
{

        public class UserLoginManager : IUserLoginManager
        {
            private readonly IDapperManager _dapperManager;

            public UserLoginManager(IDapperManager dapperManager)
            {
                this._dapperManager = dapperManager;
            }
            public async Task<List<UserLogin>> GetUserData(int UserID, int BranchID, string key)
            {
                try
                {
                    var dbPara = new DynamicParameters();
                    dbPara.Add("userid", UserID, DbType.Int32);
                    dbPara.Add("BranchId", BranchID, DbType.Int32);
                    dbPara.Add("Criteria", "UserLoginData", DbType.String);
                    //dtInvVoucher voucher = new dtInvVoucher();
                    var UserData = Task.FromResult(_dapperManager.GetAll<UserLogin>
                                        ("[FinRep_InventoryVoucherSP]", key, dbPara,
                                        commandType: CommandType.StoredProcedure));
                    return await UserData;
                }
                catch (Exception e)
                {

                    throw e;
                }
            }
            public async Task<List<UserLogin>> GetUserDataAllBranches(int UserID, string key)
            {
                var dbPara = new DynamicParameters();
                dbPara.Add("userid", UserID, DbType.Int32);
                dbPara.Add("Criteria", "UserLoginDataAllBranches", DbType.String);
                //dtInvVoucher voucher = new dtInvVoucher();
                var UserData = Task.FromResult(_dapperManager.GetAll<UserLogin>
                                    ("[FinRep_InventoryVoucherSP]", key, dbPara,
                                    commandType: CommandType.StoredProcedure));
                return await UserData;
            }
            public async Task<string> UserPhoto(int id, string key)
            {
                object path = Task.FromResult(_dapperManager.Get<string>("select CONVERT(VARCHAR(1000), CAST( Photo AS varbinary), 2) from HREmpPhoto where EmpID=" + id, key,null, commandType: CommandType.Text)).ToString();

                //byte[] binaryString = (byte[])path;
                //string p = Encoding.ASCII.GetString(binaryString);
                return path.ToString();
            }

            public async Task<List<MenuMasterData>> GetMenuData(int UserID, string BranchID, string key)
            {
                var dbPara = new DynamicParameters();
                dbPara.Add("userid", UserID, DbType.Int32);
                dbPara.Add("BranchID", BranchID, DbType.String);
                dbPara.Add("Criteria", "MISMenuMaster", DbType.String);
                //dtInvVoucher voucher = new dtInvVoucher();
                var UserData = Task.FromResult(_dapperManager.GetAll<MenuMasterData>
                                    ("[FinRep_InventoryVoucherSP]", key, dbPara,
                                    commandType: CommandType.StoredProcedure));
                return await UserData;
            }
            public void Dispose()
            {
                //throw new NotImplementedException();
            }
        }

}
