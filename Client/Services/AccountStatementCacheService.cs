using OrisonMIS.Shared.Entities.Financial;
using OrisonMIS.Shared.Entities.General;
using System.Collections.ObjectModel;

namespace OrisonMIS.Client.Services
{
    public class AccountStatementCacheService
    {

        private string _accountCode;
        private string _accountName;
        private ObservableCollection<AccStmt> _statement;
        private StatementType _statementType;
        private dtInvAccounts _selectedAccount = new dtInvAccounts();
        public IEnumerable<StatementType> TypesOfStatements;

        public AccountStatementCacheService()
        {
            this.TypesOfStatements = Enum.GetValues(typeof(StatementType))
                                .Cast<StatementType>().AsEnumerable();
        }

        public string AccountCode
        {
            get => _accountCode;
            set
            {
                if (_accountCode != value)
                {
                    _accountCode = value;
                }
            }
        }
        public string AccountName
        {
            get => _accountName;
            set
            {
                if (_accountName != value)
                {
                    _accountName = value;
                }
            }
        }
        public ObservableCollection<AccStmt> Statement 
        {
            get => _statement;
            set
            {
                if (_statement != value)
                {
                    _statement = value;
                }
            }
        }
        public StatementType StatementType 
        {
            get => _statementType;
            set
            {
                if (_statementType != value)
                {
                    _statementType = value;
                }
            }
        }
        public dtInvAccounts SelectedAccount 
        {
            get => _selectedAccount;
            set
            {
                if (_selectedAccount != value)
                {
                    _selectedAccount = value;
                    AccountName = value.AccountName;
                    AccountCode = value.AccountCode;
                }
            }
        } 
    }
}
