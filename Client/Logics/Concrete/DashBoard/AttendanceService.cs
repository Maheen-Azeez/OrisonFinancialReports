using System.Net.Http.Json;
using System.Web;
using Blazored.SessionStorage;
using Newtonsoft.Json;
using OrisonMIS.Client.Logics.Contract.DashBoard;
using OrisonMIS.Shared.Entities.DashBoard;
using Syncfusion.Blazor.Diagrams;

namespace OrisonMIS.Client.Logics.Concrete.DashBoard
{
    public class AttendanceService : IAttendanceService
    {
        private readonly HttpClient httpClient;
        private readonly ISessionStorageService sessionStorage;
        private readonly IConfiguration _config;
        private string UrlStart;
        private string SchoolCode;
        private string? key = "";
        public IEnumerable<AbsentParent> abparent { get; private set; }

        public AttendanceService(HttpClient httpClient, IConfiguration config, ISessionStorageService SessionStorage)
        {
            this.httpClient = httpClient;
            sessionStorage = SessionStorage;
            UrlStart = "http://185.241.124.133/OrisonFinanceDashboardAPI/";
        }
        public async Task<IEnumerable<AbsentParent>> GetUrl()
        {
            SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<AbsentParent[]>("api/OrisonData/GetDashBoardData?Head=Weblink&SchoolCode=" + SchoolCode + "&Branchid=31" + "&key=" + key);
        }
        public async Task<IEnumerable<clsLoginInfo>> GetLogo(string branchid)
        {
            SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<clsLoginInfo[]>("api/OrisonData/GetDashBoardData?Head=Logo&SchoolCode= " + SchoolCode + "&Branchid=" + branchid + "&key=" + key);
        }
        public async Task<IEnumerable<AbsentParent>> GetTeacherWiseDivision(string userid, string classname)
        {
            SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<AbsentParent[]>("api/master/GetTeacherWiseDivision/?userid=" + userid + "&classname=" + classname + "&key=" + key);
        }
        public async Task<IEnumerable<AbsentParent>> FillStudents(string Division, string Classname, string Year, string branchid)
        {
            SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<AbsentParent[]>("api/master/FillStudents/?Division=" + Division + "&Classname=" + Classname + "&Year=" + Year + "&branchid=" + branchid + "&key=" + key);
        }
        public async Task<IEnumerable<AbsentParent>> GetTeacherWiseClass(string userid)
        {
            SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<AbsentParent[]>("api/master/GetTeacherWiseClass/?userid=" + userid + "&key=" + key);
        }
        public async Task<IEnumerable<AbsentParent>> GetEmployees(string branchid)
        {
            SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<AbsentParent[]>("api/master/GetClasses/?branchid=" + branchid + "&key=" + key);
        }
        public async Task<List<AbsentParent>> GetStatus()
        {
            SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<List<AbsentParent>>("api/master/GetStatus");
        }

        public async Task<List<AbsentParent>> GetStatusdesc()
        {
            SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<List<AbsentParent>>("api/master/GetStatusdesc");
        }
        public async Task<IEnumerable<AbsentParent>> GetDivision(string id)
        {
            SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<AbsentParent[]>("api/master/GetDivision/?id=" + id + "");
        }
        public async Task<List<AbsentParent>> GetCurrAcademicYear(string branchid)
        {
            SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<List<AbsentParent>>("api/master/GetCurrAcademicYear/?branchid=" + branchid + "");
        }
        public async Task<IEnumerable<AbsentParent>> School_StudentwiseAttendance(AbsentParent absentParent)
        {
            SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            var response = await httpClient.PostAsJsonAsync("api/master/School_StudentwiseAttendance", absentParent);
            return await response.Content.ReadFromJsonAsync<AbsentParent[]>();
        }

        public async Task<IEnumerable<AbsentParent>> GetStayBackStudents(AbsentParent absentParent)
        {
            SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            var response = await httpClient.PostAsJsonAsync( "api/master/GetStayBackStudents/", absentParent);
            return await response.Content.ReadFromJsonAsync<AbsentParent[]>();

        }
        public async Task<IEnumerable<AbsentParent>> GetStudents(AbsentParent absentParent)
        {
            SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            var response = await httpClient.PostAsJsonAsync("api/master/GetStudents/", absentParent);
            return await response.Content.ReadFromJsonAsync<AbsentParent[]>();
        }
        public async Task<IEnumerable<AbsentParent>> GetAcYear()
        {
            SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<List<AbsentParent>>("api/master/GetAcYear");
        }
        public async Task<IEnumerable<AbsentParent>> GetAllDivision()
        {
            SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<AbsentParent[]>("api/master/GetAllDivision");
        }
        public async Task<IEnumerable<ChartDataNew>> GetNationality()
        {
            SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<ChartDataNew[]>("api/OrisonData/GetDashBoardData?Head=StudentNationality&Schoolcode=" + SchoolCode + "&Branchid=31" +"&key=" + key);
        }
        public async Task<List<clsNetProfit>> GetNetProfit(AbsentParent absentParent)
        {
            SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            string fromddate = absentParent.Datestr;
            string todate = absentParent.DateTo;
            int branchid = absentParent.branchid;
            return await httpClient.GetFromJsonAsync<List<clsNetProfit>>("api/OrisonData/GetDashBoardDataFT?Head=NetProfit&SchoolCode=" + SchoolCode + "&fromdate=" + fromddate + "&todate=" + todate + "&Branchid=" + branchid + "&key=" + key);

        }
        public async Task<List<clsAccBalance>> GetAccReceivable(AbsentParent absentParent)
        {
            SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            string fromddate = absentParent.Datestr;
            string todate = absentParent.DateTo;
            int branchid = absentParent.branchid;
            int AccountID = 32;
            return await httpClient.GetFromJsonAsync<List<clsAccBalance>>("api/OrisonData/GetDashBoardDataFTA?Head=AccBalance&SchoolCode=" + SchoolCode + "&fromdate=" + fromddate + "&todate=" + todate + "&Branchid=" + branchid + "&AccountID=" + AccountID + "&key=" + key);

        }
        public async Task<List<clsAccBalance>> GetAccPayable(AbsentParent absentParent)
        {
            SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            string fromddate = absentParent.Datestr;
            string todate = absentParent.DateTo;
            int branchid = absentParent.branchid;
            int AccountID = 213010;
            return await httpClient.GetFromJsonAsync<List<clsAccBalance>>("api/OrisonData/GetDashBoardDataFTA?Head=AccBalance&SchoolCode=" + SchoolCode + "&fromdate=" + fromddate + "&todate=" + todate + "&Branchid=" + branchid + "&AccountID=" + AccountID + "&key=" + key);

        }

        public async Task<List<Branch>> GetBranches()
        {
            try
            {
                SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
                key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
                return await httpClient.GetFromJsonAsync<List<Branch>>("api/OrisonData/GetDashBoardData?Head=Branches&SchoolCode=" + SchoolCode + "&Branchid=31" + "&key=" + key);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public async Task<List<Revenue>> GetRevenue(AbsentParent absentParent)
        {
            SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            int branchid = absentParent.branchid;
            return await httpClient.GetFromJsonAsync<List<Revenue>>("api/OrisonData/GetDashBoardData?Head=Revenue&SchoolCode=" + SchoolCode + "&Branchid=" + branchid + "&key=" + key);
        }
        public async Task<List<BankBalance>> GetBankBalance(AbsentParent absentParent)
        {
            SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            int branchid = absentParent.branchid;
            return await httpClient.GetFromJsonAsync<List<BankBalance>>("api/OrisonData/GetDashBoardData?Head=BankBalance&SchoolCode=" + SchoolCode + "&Branchid=" + branchid + "&key=" + key);
        }

        public async Task<List<FundFlow>> GetFundFlow(AbsentParent absentParent)
        {
            SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            string fromddate = absentParent.Datestr;
            string todate = absentParent.DateTo;
            int branchid = absentParent.branchid;
            return await httpClient.GetFromJsonAsync<List<FundFlow>>("api/OrisonData/GetDashBoardDataFT?Head=FUNDFLOW&SchoolCode=" + SchoolCode + "&fromdate=" + fromddate + "&todate=" + todate + "&Branchid=" + branchid + "&key=" + key);

        }

        public async Task<IEnumerable<AbsentParent>> GetDashboard(AbsentParent absentParent)
        {
            int branchid = absentParent.branchid;
            SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<AbsentParent[]>("api/OrisonData/GetDashBoardData?Head=Students&Schoolcode=" + SchoolCode + "&Branchid=" + branchid + "&key=" + key);
        }
        public async Task<AbsentParent> SaveStayBack(IEnumerable<AbsentParent> absentParent)
        {
            SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            var response = await httpClient.PostAsJsonAsync("api/master/SaveStayBack/", absentParent);
            Console.WriteLine(response);
            try
            {

                response.EnsureSuccessStatusCode();
                if (response.ReasonPhrase == "OK")
                {

                }
            }
            catch (Exception ex)
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                Console.WriteLine(errorMessage);
                throw;
            }
            string result = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<AbsentParent>(result);
        }
        public async Task<IEnumerable<AbsentParent>> SaveAttendanceTime(string time)
        {
            SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            return await httpClient.GetFromJsonAsync<AbsentParent[]>("api/master/SaveAttendanceTime/?time=" + time + "");
        }

        public async Task<AbsentParent> SaveMany(IEnumerable<AbsentParent> absentParent)
        {
            SchoolCode = await sessionStorage.GetItemAsync<string>("CompanyCode");
            key = HttpUtility.UrlEncode(await sessionStorage.GetItemAsync<string>("token_key"));
            var response = await httpClient.PostAsJsonAsync("api/master/SaveMany/", absentParent);
            Console.WriteLine(response);
            
            try
            {

                response.EnsureSuccessStatusCode();
                if (response.ReasonPhrase == "OK")
                {

                }
            }
            catch (Exception ex)
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                Console.WriteLine(errorMessage);
                throw;
            }
            string result = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<AbsentParent>(result);
        }
    }
}
