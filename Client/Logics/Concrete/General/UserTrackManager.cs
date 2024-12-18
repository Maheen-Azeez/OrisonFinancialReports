using OrisonMIS.Client.Logics.Contract.General;
using OrisonMIS.Logics.Contracts.General;
using OrisonMIS.Shared.Models;
using System.Data;

namespace OrisonMIS.Concrete.General
{
    public class UserTrackManager:IUserTrackManager
    {
        private string BaseUrl;
        private readonly IConfiguration _config;
        private readonly HttpClient httpClient;
        public UserTrackManager(HttpClient httpClient, IConfiguration config)
        {
            this.httpClient = httpClient;
            this._config = config;
            BaseUrl = _config.GetValue<string>("APIURL:MISBaseUrl");
        }

        public async Task<string> GetLocalIPAddress()
        {
           
           throw new NotImplementedException();
        }
        public async Task<HttpResponseMessage> SetUserTrack(UserTrack Track,IDBOperation db,IDbTransaction tran)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

    }
}
