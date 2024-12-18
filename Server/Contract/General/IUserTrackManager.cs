using System.Data;
using OrisonMIS.Shared.Models;

namespace OrisonMIS.Server.Contract.General
{
    public interface IUserTrackManager
    {
        Task<string> GetLocalIPAddress(string key);
        Task<long> SetUserTrack(UserTrack Track, IDbConnection db, IDbTransaction tran);
    }
}
