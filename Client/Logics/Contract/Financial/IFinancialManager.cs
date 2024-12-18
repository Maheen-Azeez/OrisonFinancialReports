using OrisonMIS.Shared.Entities;
using OrisonMIS.Shared.Entities.Financial;

namespace OrisonMIS.Client.Logics.Contract.Financial
{
    public interface IFinancialManager
    {
        public Task<dtFinancialRegisterPaging> GetData(int BranchId, string DateFrom, string DateTo, int pageNumber, int pageSize, string Search, string action,string? VType);
        public Task<List<dtTransaction>> GetTransaction(int BranchId, string DateFrom, string DateTo,string? VType);
        public Task<List<dtInvoiceWiseSales>> GetInvoiceWiseSales(int BranchId, string DateFrom, string DateTo,string? VType);
        public Task<List<dtSalesAnalysis>> GetSalesDateWIse(int BranchId, string DateFrom, string DateTo,string? VType);
        public Task<List<dtMonthwiseSales>> GetMonthWiseSales(int BranchId, string DateFrom, string DateTo,string? VType,int year);
        public Task<List<dtFinancialRegister>> getVoucherEntry(long VID, int BranchID);
        public Task<List<dtFinancialRegister>> GetData(int BranchId, string DateFrom, string DateTo);
        public Task<List<dtFinancialRegister>> GetDataByID(int BranchId, int VId);
        public Task<IList<string>> GetVType(int BranchId);
    }
}
