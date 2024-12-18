using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities;


namespace OrisonMIS.Server.Controllers.General
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IDBOperation _repository;

        private readonly IConfiguration _configuration;

        public LoginController(IConfiguration configuration, IDBOperation repository)
        {
            _configuration = configuration;
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        [Route("LoginUserNew")]
        //[HttpGet()]
        public async Task<IEnumerable<Login>> LoginUserNew(Login User, string key)
        {

            // return Ok(await _repository.GetVoucherAdditionals(User));

            IEnumerable<Login> enumUser;
            var parameters = new DynamicParameters();
            parameters.Add("@UserName", User.Username, DbType.String);
            parameters.Add("@Password", User.Password, DbType.String);


            using (var conn = new SqlConnection(_configuration.GetValue<string>(key)))         

            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    conn.Open();
               
                    enumUser = await conn.QueryAsync<Login>("FINWEB_UserLoginSP", parameters, commandType: CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }

            return enumUser;
        }
        [HttpGet("{vid}/{key}")]
        public async Task<int> GetBranchID(int vid, string key)
        {
            return await _repository.GetBranchID(vid,key);
        }
       
    }
}
