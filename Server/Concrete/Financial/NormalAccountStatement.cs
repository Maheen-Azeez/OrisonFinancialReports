using Dapper;
using OrisonMIS.Server.Contract.Financial;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Server.Exceptions;
using OrisonMIS.Shared.Entities.Financial;
using System.Data;

namespace OrisonMIS.Server.Concrete.Financial
{
    public class NormalAccountStatement : IAccountStatement
    {
        
        Task<List<AcctStmt>> IAccountStatement.GetAccountStatement(string key, DynamicParameters parameters, IDapperManager dapperManager)
        {


            long allBranch = parameters.Get<long>("BranchId") == 0 ? 1 : 0;
            parameters.Add("AllBranch", allBranch, DbType.Int32);
            try
            {
                var AcctStmt = Task.FromResult(dapperManager.GetAll<AcctStmt>
                                    ("FinRep_AccountStmtSP", key, parameters, commandType: CommandType.StoredProcedure));
                return AcctStmt;
            }
            catch (StoredProcedureRelatedException e)
            {
                throw new StoredProcedureRelatedException("The procedures need to be configured. Please reach out to the administrator.", e.InnerException);
            }
        }
    }
}
