using ClosedXML.Excel;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Shared.Entities.Financial;
using System.Collections.Generic;
using System.Data;

namespace OrisonMIS.Server.Controllers.Excel
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcelExportController : ControllerBase
    {
        private readonly IDapperManager dapperManager;

        public ExcelExportController(IDapperManager dapperManager)
        {
            this.dapperManager = dapperManager;
        }

        [HttpGet("DownloadExcel")]
        public async Task<IActionResult> DownloadExcel(int BranchId, DateTime DateFrom, DateTime DateTo, string key)
        {
            try
            {
                var data = await GetDataFromDatabase(BranchId, DateFrom, DateTo, key);
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Sheet1");
                    var currentRow = 1;

                    var headers = new List<string>
                    {
                        "VType", "VDate", "VNO", "AccountCode", "AccountName",
                        "Debit", "Credit", "Description", "PAccountCode", "PAccountName",
                        "NameInArabic", "Currency", "RefNo", "Reference", "ChequeNo",
                        "ChequeDate", "CreatedDate", "CreatedUser", "ModifiededDate",
                        "ModifiedUser", "StaffName", "Voucheragainst", "CommonNarration",
                        "Alloted", "VID", "VEID"
                    };

                    for (int i = 0; i < headers.Count; i++)
                    {
                        worksheet.Cell(currentRow, i + 1).Value = headers[i];
                    }

                    decimal? totalDebit = 0;
                    decimal? totalCredit = 0;
                    foreach (var item in data)
                    {
                        currentRow++;
                        worksheet.Cell(currentRow, 1).Value = item.VType;
                        worksheet.Cell(currentRow, 2).Value = item.VDate;
                        worksheet.Cell(currentRow, 3).Value = item.VNO;
                        worksheet.Cell(currentRow, 4).Value = item.AccountCode;
                        worksheet.Cell(currentRow, 5).Value = item.AccountName;
                        worksheet.Cell(currentRow, 6).Value = item.Debit;
                        worksheet.Cell(currentRow, 7).Value = item.Credit;
                        worksheet.Cell(currentRow, 8).Value = item.Description;
                        worksheet.Cell(currentRow, 9).Value = item.PAccountCode;
                        worksheet.Cell(currentRow, 10).Value = item.PAccountName;
                        worksheet.Cell(currentRow, 11).Value = item.NameInArabic;
                        worksheet.Cell(currentRow, 12).Value = item.Currency;
                        worksheet.Cell(currentRow, 13).Value = item.RefNo;
                        worksheet.Cell(currentRow, 14).Value = item.Reference;
                        worksheet.Cell(currentRow, 15).Value = item.ChequeNo;
                        worksheet.Cell(currentRow, 16).Value = item.ChequeDate;
                        worksheet.Cell(currentRow, 17).Value = item.CreatedDate;
                        worksheet.Cell(currentRow, 18).Value = item.CreatedUser;
                        worksheet.Cell(currentRow, 19).Value = item.ModifiededDate;
                        worksheet.Cell(currentRow, 20).Value = item.ModifiedUser;
                        worksheet.Cell(currentRow, 21).Value = item.StaffName;
                        worksheet.Cell(currentRow, 22).Value = item.Voucheragainst;
                        worksheet.Cell(currentRow, 23).Value = item.CommonNarration;
                        worksheet.Cell(currentRow, 24).Value = item.Alloted;
                        worksheet.Cell(currentRow, 25).Value = item.VID;
                        worksheet.Cell(currentRow, 26).Value = item.VEID;

                        totalDebit += item.Debit;
                        totalCredit += item.Credit;
                    }

                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = "Total";
                    worksheet.Cell(currentRow, 6).Value = totalDebit;
                    worksheet.Cell(currentRow, 7).Value = totalCredit;

                    worksheet.Columns().AdjustToContents();

                    using (var stream = new MemoryStream())
                    {
                        workbook.SaveAs(stream);
                        stream.Position = 0;
                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "FinancialRegister.xlsx");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        private async Task<IEnumerable<dtFinancialRegister>> GetDataFromDatabase(int BranchId, DateTime DateFrom, DateTime DateTo, string key)
        {
            try
            {
                var dbPara = new DynamicParameters();
                dbPara.Add("BranchId", BranchId, DbType.Int32);
                dbPara.Add("FromDate", DateFrom, DbType.DateTime);
                dbPara.Add("ToDate", DateTo, DbType.DateTime);
                return await Task.FromResult(dapperManager.GetAll<dtFinancialRegister>("Financial_Register_SP", key, dbPara, commandType: CommandType.StoredProcedure));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
