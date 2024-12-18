using OrisonMIS.Server.Contract.Financial;
using OrisonMIS.Shared.Entities.Financial;

namespace OrisonMIS.Server.Concrete.Financial.Main
{
    public class AccountStatementFactory
    {
        public static IAccountStatement GetAccountStatementInstance(StatementType statementType)
        {
            return statementType switch
            {
                StatementType.Monthly => new MonthlyAccountStatement(),
                StatementType.Yearly => new AnnualAccountStatement(),
                StatementType.Detailed => new DetailedAccountStatement(),
                StatementType.Normal => new NormalAccountStatement(),
                
                // Default case for unsupported types
                _ => throw new ArgumentException($"Invalid StatementType: {statementType}", nameof(statementType)),
            };
        }
    }
}
