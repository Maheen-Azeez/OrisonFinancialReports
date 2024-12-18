using Dapper;
using OrisonMIS.Server.Contract.Financial;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Server.Exceptions;
using OrisonMIS.Shared.Dtos.Statement;
using OrisonMIS.Shared.Entities.Financial;
using System.Data;

namespace OrisonMIS.Server.Concrete.Financial
{
    public class MonthlyAccountStatement : IAccountStatement
    {

        public async Task<List<AcctStmt>> GetAccountStatement(string key, DynamicParameters parameters, IDapperManager dapperManager)
        {
            try
            {
                parameters.Add("Criteria", "Month", DbType.String);

                var result = Task.Run(() =>
                {
                    var acctStmtDtos = dapperManager.GetAll<MonthlyStatementDto>(
                        "AccountStmtModifiedSP", key, parameters, CommandType.StoredProcedure);

                    if (acctStmtDtos == null || !acctStmtDtos.Any())
                    {
                        return new List<AcctStmt>(); // Return an empty list
                    }

                    var result = new List<AcctStmt>();
                    foreach (var item in acctStmtDtos)
                    {
                        result.Add(new AcctStmt
                        {
                            Description = item.Narration,
                            MainAccountName = item.AccountName,
                            Debit = item.Debit,
                            Credit = item.Credit,
                            VNo = item.VNo,
                            VID = item.VID,
                            EffectiveDate= item.Date
                        });
                    }

                    return result;
                });
                return await result;
            }
            catch (Exception ex)
            {
                throw new StoredProcedureRelatedException("Monthly statement configuration is still pending. Contact the administrator, please.", ex.InnerException);
            }
        }
    }
}
