using Dapper;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.Financial;

namespace OrisonMIS.Server.Contract.Financial
{
    public interface IAccountStatement
    {
        Task<List<AcctStmt>> GetAccountStatement(string key, DynamicParameters parameters,IDapperManager dapperManager);
    }
}
