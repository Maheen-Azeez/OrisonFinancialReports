using OrisonMIS.Client.Logics.Contract.General;

namespace OrisonMIS.Client.Services
{
    public class AccountService
    {

        private IDBOperation idbopn;
        public AccountService()
        {
        }
        public string getPassword()
        {
            return (string)idbopn.GetScalar("Select Password from [dbo].[Users]");
        }
        public string PasswordDecode(string Pwd)
        {
            char[] PwdChar = Pwd.ToCharArray();
            string deCodedPwd = "";
            foreach (char c in PwdChar)
            {
                deCodedPwd = deCodedPwd + (char)(Convert.ToInt32(c) - 10);
            }
            return deCodedPwd;
        }
        public string PasswordEncode(string Pwd)
        {
            char[] PwdChar = Pwd.ToCharArray();
            string EnCodedPwd = "";
            foreach (char c in PwdChar)
            {
                EnCodedPwd = EnCodedPwd + (char)(Convert.ToInt32(c) + 10);
            }
            return EnCodedPwd;

        }
    }
}
