using Dapper;
using Microsoft.Identity.Client;
using OrisonMIS.Server.Contract.General;
using Syncfusion.XlsIO.Implementation;
using System.Data;
using System.Net.Http.Headers;

namespace OrisonMIS.Server.Concrete.General
{
    public class OrisonManager : IOrisonManager
    {
        private readonly IDapperManager dapperManager;

        public OrisonManager(IDapperManager dapperManager)
        {
            this.dapperManager = dapperManager;
        }
        public async Task<List<object>> Get(string head, string schoolCode, int branchId, string key)
        {
            try
            {
                var dbPara = new DynamicParameters();
                string currentdate = DateTime.Now.ToString();
                switch (head)
                {
                    case "Transport":
                        return  dapperManager.GetAll<object>("Select '" + schoolCode + "' as SchoolCode, Make, VehicleType,Max(AvailableSeats) Capacity,count(VehicleType) TotalCount  from hrtransportationmast where status = 'Active' group by VehicleType, Make",
                                                             key,null, commandType: CommandType.Text);
                    case "Staff":
                        return dapperManager.GetAll<object>("Select '" + schoolCode + "' as SchoolCode,isnull(Description,'OTHER')  Designation,count(EmpID) TotalCount from Hremployee h inner join PersonnelDetailsTran p on h.empid=p.accountid left join MastDesignation m on m.id=p.DesignationID  and  h.status='Active' group by Description",
                                                            key, null, commandType: CommandType.Text);
                        
                    case "StaffDepartment":
                        return dapperManager.GetAll<object>("Select '" + schoolCode + "' as SchoolCode, case when Shift='Teaching' then 'Teaching' else 'NonTeaching' end Department,count(empID) TotalCount from Hremployee h inner join PersonnelDetailsTran p on h.empid=p.accountid left join MastDesignation m on m.id=p.DesignationID  and  h.status='Active' group by case when Shift='Teaching' then 'Teaching' else 'NonTeaching' end",
                                                            key, null, commandType: CommandType.Text);
                        
                    case "NewAdmissionCount":
                        return dapperManager.GetAll<object>("Select st.branchid,CompanyCode as Branch,count(Accountcode) RegNo from school_Studenttrans st inner join accounts s on st.accountid=s.id " +
                                "  inner join company b on  b.id = s.BranchID where academicyear = (select academicyear from school_academicyear where status = 'current' " +
                                " and branchid = st.branchid) and prevStatus = 'New' group by st.branchid,CompanyCode order by Branch", 
                                key, null, commandType: CommandType.Text);
                       
                    case "Students":
                        return dapperManager.GetAll<object>("select branchid,Class,Sex,Religion,Nationality,Status,Branch  from API_StudentsVW ",
                                                            key, null, commandType: CommandType.Text);

                    case "AgeWiseAnalysis":

                        return dapperManager.GetAll<object>("select 'Age'+cast(Age as nvarchar(50)) Age,Count(accountid) as Count from(" +
                                " SELECT  s.accountid,  ROUND(DATEDIFF(day, Cast(DateOfBirth as Date),Cast(getdate() as Date)) / 365, 0) as age " +
                                " FROM School_students s inner join school_studenttrans st on s.accountid=st.accountid and branchid=" + branchId + " and " +
                                "academicyear=(select academicyear from school_academicyear where status='current'  and branchid=" + branchId + ")  and " +
                                "status='studying')x group by age ", key, null, commandType: CommandType.Text);
                    case "Attendance":

                        dbPara.Add("Branchid", branchId, DbType.Int32);
                        dbPara.Add("Criteria", "Revenue", DbType.String);
                        dbPara.Add("fromDate", currentdate, DbType.String);
                        dbPara.Add("toDate", "", DbType.String);
                        dbPara.Add("BasicType", "" , DbType.String);
                        dbPara.Add("AccountID", "", DbType.String);
                        return dapperManager.GetAll<object>("School_BranchwiseAttendanceRegisterDashboard",key, dbPara, commandType: CommandType.StoredProcedure);
                   
                    case "Student":
                        return dapperManager.GetAll<object>("select * from API_StudentdetailstVW ", key, null, commandType: CommandType.Text);

                    case "StudentCount":
                        return dapperManager.GetAll<object>("select * from API_ClassCountVW ", key, null, commandType: CommandType.Text);

                    case "StaffData":
                        return dapperManager.GetAll<object>("select * from API_StaffVW ", key, null, commandType: CommandType.Text);
                        
                    case "ClasswiseStudentCount":
                        dbPara.Add("Branchid", branchId, DbType.Int32);
                        dbPara.Add("Criteria", "Attendance", DbType.String);
                        dbPara.Add("fromDate", currentdate, DbType.String);
                        dbPara.Add("toDate", currentdate, DbType.String);
                        dbPara.Add("BasicType", "", DbType.String);
                        return dapperManager.GetAll<object>("School_ClasswiseStudentCountSP", key, dbPara, commandType: CommandType.StoredProcedure);

                    case "HRAttendance":
                        dbPara.Add("Branchid", branchId, DbType.Int32);
                        dbPara.Add("Criteria", "Attendance", DbType.String);
                        dbPara.Add("fromDate", currentdate, DbType.String);
                        dbPara.Add("toDate", currentdate, DbType.String);
                        dbPara.Add("BasicType", "", DbType.String);
                        return dapperManager.GetAll<object>("HR_MISReports", key, dbPara, commandType: CommandType.StoredProcedure);

                    case "Branches":
                        return dapperManager.GetAll<object>("select id as Code,companycode as Name,connectionurl  from company", key, null, commandType: CommandType.Text);
                    case "Logo":
                        return dapperManager.GetAll<object>("Select Abbr as Logo from Company where ID=" + branchId + " ", key, null, commandType: CommandType.Text);
                    case "Weblink":

                        return dapperManager.GetAll<object>("select top 1 Description,source from mastermisc where source='DashLogout' " +
                        " union all select top 1 Description,source from mastermisc where source = 'DashHomeURL' " +
                        "  union all select top 1 Description,source from mastermisc where source = 'DashLogoPath'  ", key, null, commandType: CommandType.Text);

                    case "Revenue":
                        dbPara.Add("Branchid", branchId, DbType.Int32);
                        dbPara.Add("Criteria", "Revenue", DbType.String);
                        dbPara.Add("fromDate", currentdate, DbType.String);
                        dbPara.Add("toDate", currentdate, DbType.String);
                        dbPara.Add("BasicType", "", DbType.String);
                        return dapperManager.GetAll<object>("Fin_MISReports", key, dbPara, commandType: CommandType.StoredProcedure);

                    case "BankBalance":
                        dbPara.Add("Branchid", branchId, DbType.Int32);
                        dbPara.Add("Criteria", "BankBalance", DbType.String);
                        dbPara.Add("fromDate", currentdate, DbType.String);
                        dbPara.Add("toDate", currentdate, DbType.String);
                        dbPara.Add("BasicType", "", DbType.String);
                        return dapperManager.GetAll<object>("Fin_MISReports", key, dbPara, commandType: CommandType.StoredProcedure);
                    case "Age":
                        dbPara.Add("Branchid", branchId, DbType.Int32);
                        dbPara.Add("Criteria", "Age", DbType.String);
                        dbPara.Add("fromDate", currentdate, DbType.String);
                        dbPara.Add("toDate", currentdate, DbType.String);
                        dbPara.Add("BasicType", "", DbType.String);
                        return dapperManager.GetAll<object>("School_MISReports", key, dbPara, commandType: CommandType.StoredProcedure);
                    default:
                        return new List<object>();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<object>> Get(string Head, string SchoolCode, DateTime fromdate, DateTime todate, int branchId, string key)
        {
           
            string from = fromdate.ToString("MM/dd/yyyy hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            string to = todate.ToString("MM/dd/yyyy hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            var dbPara = new DynamicParameters();
            try
            {
                switch (Head)
                {

                    case "PDCReport":
                        dbPara.Add("Branchid", branchId, DbType.Int32);
                        dbPara.Add("Criteria", "PDCReport", DbType.String);
                        dbPara.Add("fromDate", from, DbType.String);
                        dbPara.Add("toDate", to, DbType.String);
                        dbPara.Add("BasicType", "", DbType.String);
                        return  dapperManager.GetAll<object>("Fin_MISReports", key, dbPara, commandType: CommandType.StoredProcedure);

                    case "Payment":
                        dbPara.Add("Branchid", branchId, DbType.Int32);
                        dbPara.Add("Criteria", "EntrySearch", DbType.String);
                        dbPara.Add("fromDate", from, DbType.String);
                        dbPara.Add("toDate", to, DbType.String);
                        dbPara.Add("BasicType", "Payment", DbType.String);
                        return dapperManager.GetAll<object>("Fin_MISReports", key, dbPara, commandType: CommandType.StoredProcedure);

                    case "Receipt":
                        dbPara.Add("Branchid", branchId, DbType.Int32);
                        dbPara.Add("Criteria", "EntrySearch", DbType.String);
                        dbPara.Add("fromDate", from, DbType.String);
                        dbPara.Add("toDate", to, DbType.String);
                        dbPara.Add("BasicType", "Receipt", DbType.String);
                        return dapperManager.GetAll<object>("Fin_MISReports", key, dbPara, commandType: CommandType.StoredProcedure);

                    case "FUNDFLOW":
                        dbPara.Add("Branchid", branchId, DbType.Int32);
                        dbPara.Add("Criteria", "FUNDFLOW", DbType.String);
                        dbPara.Add("fromDate", from, DbType.String);
                        dbPara.Add("toDate", to, DbType.String);
                        dbPara.Add("BasicType", "", DbType.String);
                        return dapperManager.GetAll<object>("Fin_MISReports", key, dbPara, commandType: CommandType.StoredProcedure);

                    case "NetProfit":
                        dbPara.Add("Branchid", branchId, DbType.Int32);
                        dbPara.Add("Criteria", "NetProfit", DbType.String);
                        dbPara.Add("fromDate", from, DbType.String);
                        dbPara.Add("toDate", to, DbType.String);
                        dbPara.Add("BasicType", "", DbType.String);
                        return dapperManager.GetAll<object>("Fin_MISReports", key, dbPara, commandType: CommandType.StoredProcedure);
                    case "RegistrationsAndEnquiries":
                        dbPara.Add("Branchid", branchId, DbType.Int32);
                        dbPara.Add("Criteria", "NetProfit", DbType.String);
                        dbPara.Add("fromDate", from, DbType.String);
                        dbPara.Add("toDate", to, DbType.String);
                        dbPara.Add("BasicType", "", DbType.String);
                        return dapperManager.GetAll<object>("School_GetEnqRegDashboardDetailsAllSchool", key, dbPara, commandType: CommandType.StoredProcedure);
                    default:
                        return new List<object>();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<List<object>> Get(String Head, String SchoolCode, DateTime fromdate, DateTime todate, int Branchid, int AccountID, string key)
        {

            string from = fromdate.ToString("MM/dd/yyyy hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            string to = todate.ToString("MM/dd/yyyy hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            var dbPara = new DynamicParameters();
            try
            {
                switch (Head)
                {

                    case "AccBalance":
                        dbPara.Add("Branchid", Branchid, DbType.Int32);
                        dbPara.Add("Criteria", "AccBalance", DbType.String);
                        dbPara.Add("fromDate", from, DbType.String);
                        dbPara.Add("toDate", to, DbType.String);
                        dbPara.Add("BasicType", "", DbType.String);
                        return dapperManager.GetAll<object>("Fin_MISReports", key, dbPara, commandType: CommandType.StoredProcedure);
                    default:
                        return new List<object>();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
