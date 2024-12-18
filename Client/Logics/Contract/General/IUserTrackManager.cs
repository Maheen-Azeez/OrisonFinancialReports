using OrisonMIS.Client.Logics.Contract.General;
using OrisonMIS.Shared.Models;
using System.Data;

namespace OrisonMIS.Logics.Contracts.General
{
    public interface IUserTrackManager
    {
       public Task<string> GetLocalIPAddress();
       public Task<HttpResponseMessage> SetUserTrack(UserTrack Track,IDBOperation db,IDbTransaction tran);
    }
}
