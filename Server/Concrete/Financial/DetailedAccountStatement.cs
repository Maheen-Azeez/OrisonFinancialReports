using Dapper;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using OrisonMIS.Server.Contract.Financial;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Server.Exceptions;
using OrisonMIS.Shared.Dtos.Statement;
using OrisonMIS.Shared.Entities.Financial;
using System.Data;

namespace OrisonMIS.Server.Concrete.Financial
{
    public class DetailedAccountStatement : IAccountStatement
    {
        
        async Task<List<AcctStmt>> IAccountStatement.GetAccountStatement(string key, DynamicParameters parameters, IDapperManager dapperManager)
        {

            try
            {
                var result = Task.Run(() =>
                {
                    var acctStmtDtos = dapperManager.GetAll<DetailedStatementDto>(
                        "AccountStmtSPExpanded", key, parameters, CommandType.StoredProcedure);

                    if (acctStmtDtos == null || !acctStmtDtos.Any())
                    {
                        return new List<AcctStmt>(); // Return an empty list
                    }

                    var result = new List<AcctStmt>();
                    foreach (var item in acctStmtDtos)
                    {
                        if (item != null)
                        {
                            result.Add(new AcctStmt
                            {
                                AccountName = item.AccountName,
                                Description = item.MainRow == 0 ? "  " + item.Narration : item.Narration,
                                MainAccountName = item.MainAccountName,
                                Debit = item.Debit,
                                Credit = item.Credit,
                                VNo = item.VNo,
                                VID = item.VID,
                                EffectiveDate = item.EffectiveDate
                            });
                        }
                    }

                    return result;
                });
                return await result; ;
               
            }
            catch (Exception ex)
            {
                throw new StoredProcedureRelatedException("Detailed statement configuration is still pending. Contact the administrator, please.", ex.InnerException);
            }
        }
    }
}
