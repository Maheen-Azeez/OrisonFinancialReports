using Blazored.SessionStorage;
using OrisonMIS.Client.Logics.Contract.General;
using OrisonMIS.Shared.Entities.General;
using System.Net.Http.Json;

namespace OrisonMIS.Client.Logics.Concrete.General
{
    public class Account : IAccounts
    {
       
        private readonly HttpClient httpClient;
        private readonly ISessionStorageService SessionStorage;
        public Account(HttpClient httpClient, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            this.SessionStorage = SessionStorage;
          
        }
        public async Task<IEnumerable<LoginModel>> LoginUserNew(LoginModel obj)
        {
            //return await httpClient.PostAsJsonAsync<LoginModel[]>("api/Login/LoginUserNew", obj);
            IEnumerable<LoginModel> result = new List<LoginModel>();
            return result;
        }
    }
}
