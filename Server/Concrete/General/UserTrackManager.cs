using Dapper;
using System.Security.Principal;
using System.Data;
using System.Net;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Models;

namespace OrisonMIS.Server.Concrete.General
{
    public class UserTrackManager : IUserTrackManager
    {
        private readonly IDapperManager _dapperManager;
        private readonly IConfiguration _config;

        public UserTrackManager(IDapperManager dapperManager)
        {
            _dapperManager = dapperManager;
        }
        public async Task<string> GetLocalIPAddress(string key)
        {
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST  
            Console.WriteLine(hostName);
            // Get the IP  
            string myIP = Dns.GetHostByName(hostName).AddressList[1].ToString();
            return myIP;


        }
        public async Task<long> SetUserTrack(UserTrack userTrack, IDbConnection db, IDbTransaction tran)
        {
            long newID;
            try
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                try
                {

                    UserTrack user = userTrack;
                    string hostName = Dns.GetHostName(); // Retrive the Name of HOST  
                    // Get the IP  
                    string myIP = Dns.GetHostByName(hostName).AddressList[1].ToString();
                    user.MachineName = WindowsIdentity.GetCurrent().Name.ToString() + " IP : " + myIP;

                    if (userTrack.ActionId == 1)
                        userTrack.Vdate = DateTime.Now;

                    var dbPara = new DynamicParameters();
                    dbPara.Add("UserId", userTrack.UserId, DbType.Int64);
                    dbPara.Add("TableName", userTrack.TableName, DbType.String);
                    dbPara.Add("Vdate", userTrack.Vdate, DbType.DateTime);
                    dbPara.Add("AccountID", userTrack.AccountId, DbType.Int64);
                    dbPara.Add("accountcode", userTrack.Accountcode, DbType.String);
                    dbPara.Add("partyname", userTrack.PartyName, DbType.String);
                    dbPara.Add("Reason", userTrack.Reason, DbType.String);
                    dbPara.Add("ActionID", userTrack.ActionId, DbType.Int64);
                    dbPara.Add("RowID", userTrack.RowId, DbType.Int64);
                    dbPara.Add("MachineName", userTrack.MachineName, DbType.String);
                    dbPara.Add("ModuleName", userTrack.ModuleName, DbType.String);
                    dbPara.Add("Reference", userTrack.Reference, DbType.String);
                    dbPara.Add("Amount", userTrack.Amount, DbType.Decimal);
                    dbPara.Add("NetAmount", userTrack.NetAmount, DbType.Decimal);
                    dbPara.Add("Version", "Web", DbType.String);
                    dbPara.Add("NewID", dbType: DbType.Int64, direction: ParameterDirection.Output);

                    newID = _dapperManager.Insert("[FinWeb_UserTrackSP]", dbPara, db, tran, commandType: CommandType.StoredProcedure);

                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return newID;
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
