using OrisonMIS.Shared.Entities;
using OrisonMIS.Shared.Entities.Financial;

namespace OrisonMIS.Server.Contract.Financial
{
    public interface IFinancialManager
    {
        public Task<dtFinancialRegisterPaging> GetData(int BranchId, DateTime DateFrom, DateTime DateTo, int pageNumber, int pageSize, string Search, string action, string? VType, string key);
        public Task<List<dtFinancialRegister>> GetData(int BranchId, DateTime DateFrom, DateTime DateTo,string key);
        Task<List<dtFinancialRegister>> GetDataByID(int branchId, int vId, string key);
        Task<List<dtTransaction>> GetTransaction(int branchId, DateTime fDate, DateTime tDate, string? vType, string key);
        Task<List<dtInvoiceWiseSales>> GetInvoiceWiseSales(int branchId, DateTime fDate, DateTime tDate, string? vType, string key);
        Task<List<dtMonthwiseSales>> GetMonthWiseSales(int branchId,string? vType,int year, string key);
        Task<List<dtSalesAnalysis>> GetSalesDateWIse(int branchId, DateTime fDate, DateTime tDate, string? vType, string key);
        Task<List<dtFinancialRegister>> GetVoucherEntry(int branchId, long vId, string key);
        Task<List<string>> GetVType(int branchId, string key);
    }
}
