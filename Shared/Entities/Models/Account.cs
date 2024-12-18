using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Account
    {
        public Account()
        {
            AccountsImages = new HashSet<AccountsImage>();
            AccountsListUsers = new HashSet<AccountsListUser>();
            AccountsLists = new HashSet<AccountsList>();
            AdditionalChargeCrAccounts = new HashSet<AdditionalCharge>();
            AdditionalChargeDrAccounts = new HashSet<AdditionalCharge>();
            BankDetails = new HashSet<BankDetail>();
            ChequeBanks = new HashSet<Cheque>();
            ChequeBanksNavigation = new HashSet<ChequeBank>();
            ChequeBookMasters = new HashSet<ChequeBookMaster>();
            ChequeParties = new HashSet<Cheque>();
            CostCentreDetailClients = new HashSet<CostCentreDetail>();
            CostCentreDetailSuppliers = new HashSet<CostCentreDetail>();
            Cpdetails = new HashSet<Cpdetail>();
            CustomerAdditionals = new HashSet<CustomerAdditional>();
            CustomerStatuses = new HashSet<CustomerStatus>();
            Dcsaccounts = new HashSet<Dcsaccount>();
            DynamicAccounts = new HashSet<DynamicAccount>();
            EssapproverTrans = new HashSet<EssapproverTran>();
            Essmaintenances = new HashSet<Essmaintenance>();
            FamasterAssetAccounts = new HashSet<Famaster>();
            FamasterDeprAccounts = new HashSet<Famaster>();
            FamasterVendorAccounts = new HashSet<Famaster>();
            Gcheques = new HashSet<Gcheque>();
            GroupParents = new HashSet<GroupParent>();
            HrabsentLists = new HashSet<HrabsentList>();
            HrbranchSettings = new HashSet<HrbranchSetting>();
            HrcampAttendances = new HashSet<HrcampAttendance>();
            HrdeductionMultidetails = new HashSet<HrdeductionMultidetail>();
            HrdocumentsExpenses = new HashSet<HrdocumentsExpense>();
            HrempAdvanceDetails = new HashSet<HrempAdvanceDetail>();
            HrempDocuments = new HashSet<HrempDocument>();
            HrempDocumentsExpenses = new HashSet<HrempDocumentsExpense>();
            HrempExperiences = new HashSet<HrempExperience>();
            HrempFamilies = new HashSet<HrempFamily>();
            HrempLeaveDetails = new HashSet<HrempLeaveDetail>();
            HrempNotes = new HashSet<HrempNote>();
            HrempPhotos = new HashSet<HrempPhoto>();
            HrempProjectTrans = new HashSet<HrempProjectTran>();
            HrempQualifications = new HashSet<HrempQualification>();
            HrempSalaries = new HashSet<HrempSalary>();
            HrempWages = new HashSet<HrempWage>();
            HremployeeTracks = new HashSet<HremployeeTrack>();
            HrfinalSettlements = new HashSet<HrfinalSettlement>();
            HrgratuityAndLeaveSalaryTrans = new HashSet<HrgratuityAndLeaveSalaryTran>();
            HrgratuityParents = new HashSet<HrgratuityParent>();
            HrinvoiceDetails = new HashSet<HrinvoiceDetail>();
            Hrmobilizations = new HashSet<Hrmobilization>();
            HrprojectAttendances = new HashSet<HrprojectAttendance>();
            HrrateMasterMeterSquares = new HashSet<HrrateMasterMeterSquare>();
            HrsalaryIncrementEmpDetails = new HashSet<HrsalaryIncrementEmpDetail>();
            HrsupplierInvoiceDetails = new HashSet<HrsupplierInvoiceDetail>();
            HrsupplierInvoices = new HashSet<HrsupplierInvoice>();
            HrtimeCardDetails = new HashSet<HrtimeCardDetail>();
            HrtimeCardMeterSquares = new HashSet<HrtimeCardMeterSquare>();
            HrtimeSheets = new HashSet<HrtimeSheet>();
            Hrwpstrans = new HashSet<Hrwpstran>();
            InverseParentNavigation = new HashSet<Account>();
            ItemMasterCostAccounts = new HashSet<ItemMaster>();
            ItemMasterInvAccounts = new HashSet<ItemMaster>();
            ItemMasterPurchaseAccounts = new HashSet<ItemMaster>();
            ItemMasterSalesAccounts = new HashSet<ItemMaster>();
            LcAccounts = new HashSet<Lc>();
            LcBanks = new HashSet<Lc>();
            LcSuppliers = new HashSet<Lc>();
            Personeldetailstran2s = new HashSet<Personeldetailstran2>();
            PersonnelDetailsTranTracks = new HashSet<PersonnelDetailsTranTrack>();
            PortalUsers = new HashSet<PortalUser>();
            PrepaidVoucherMasterPartyAccounts = new HashSet<PrepaidVoucherMaster>();
            PrepaidVoucherMasterPrepaidAccounts = new HashSet<PrepaidVoucherMaster>();
            SalesInvoiceDetails = new HashSet<SalesInvoiceDetail>();
            SalesInvoices = new HashSet<SalesInvoice>();
            SchoolFeeMasters = new HashSet<SchoolFeeMaster>();
            SchoolStudentTrans = new HashSet<SchoolStudentTran>();
            TourismExcursionInvoices = new HashSet<TourismExcursionInvoice>();
            TourismRateMasters = new HashSet<TourismRateMaster>();
            TransactionCrAccounts = new HashSet<Transaction>();
            TransactionDrAccounts = new HashSet<Transaction>();
            TransactionPostAccounts = new HashSet<Transaction>();
            UniqueAccounts = new HashSet<UniqueAccount>();
            VoucherAccounts = new HashSet<Voucher>();
            VoucherCollections = new HashSet<VoucherCollection>();
            VoucherEntries = new HashSet<VoucherEntry>();
            VoucherEntryDetails = new HashSet<VoucherEntryDetail>();
            VoucherStaffs = new HashSet<Voucher>();
            VtypeTranBankAccountNavigations = new HashSet<VtypeTran>();
            VtypeTranCardAccountNavigations = new HashSet<VtypeTran>();
            VtypeTranCashAccountNavigations = new HashSet<VtypeTran>();
            VtypeTranPostAccountNavigations = new HashSet<VtypeTran>();
        }

        public int Id { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public int? Parent { get; set; }
        public int ParentLevel { get; set; }
        public bool VoucherEntry { get; set; }
        public bool FinalAccount { get; set; }
        public int AccountGroup { get; set; }
        public int? SubGroup { get; set; }
        public int? AccCategory { get; set; }
        public bool? ShowChild { get; set; }
        public bool? Isdefault { get; set; }
        public bool? AllowEntry { get; set; }
        public bool InActive { get; set; }
        public bool? Editable { get; set; }
        public long? UserTrackId { get; set; }
        public int? Currency { get; set; }
        public int? BranchId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int? CreatedUser { get; set; }
        public int? ModifiedUser { get; set; }
        public int? AorderNo { get; set; }
        public int? Ccid { get; set; }
        public bool? InVisible { get; set; }
        public decimal? SortField { get; set; }
        public bool? ShowRow { get; set; }

        public virtual AccountCategoryMast AccCategoryNavigation { get; set; }
        public virtual AccountGroupMast AccountGroupNavigation { get; set; }
        public virtual Company Branch { get; set; }
        public virtual Account ParentNavigation { get; set; }
        public virtual SubGroupMast SubGroupNavigation { get; set; }
        public virtual Hremployee Hremployee { get; set; }
        public virtual HremployeeBackup HremployeeBackup { get; set; }
        public virtual PersonnelDetailsTran PersonnelDetailsTran { get; set; }
        public virtual SchoolStudent SchoolStudent { get; set; }
        public virtual ICollection<AccountsImage> AccountsImages { get; set; }
        public virtual ICollection<AccountsListUser> AccountsListUsers { get; set; }
        public virtual ICollection<AccountsList> AccountsLists { get; set; }
        public virtual ICollection<AdditionalCharge> AdditionalChargeCrAccounts { get; set; }
        public virtual ICollection<AdditionalCharge> AdditionalChargeDrAccounts { get; set; }
        public virtual ICollection<BankDetail> BankDetails { get; set; }
        public virtual ICollection<Cheque> ChequeBanks { get; set; }
        public virtual ICollection<ChequeBank> ChequeBanksNavigation { get; set; }
        public virtual ICollection<ChequeBookMaster> ChequeBookMasters { get; set; }
        public virtual ICollection<Cheque> ChequeParties { get; set; }
        public virtual ICollection<CostCentreDetail> CostCentreDetailClients { get; set; }
        public virtual ICollection<CostCentreDetail> CostCentreDetailSuppliers { get; set; }
        public virtual ICollection<Cpdetail> Cpdetails { get; set; }
        public virtual ICollection<CustomerAdditional> CustomerAdditionals { get; set; }
        public virtual ICollection<CustomerStatus> CustomerStatuses { get; set; }
        public virtual ICollection<Dcsaccount> Dcsaccounts { get; set; }
        public virtual ICollection<DynamicAccount> DynamicAccounts { get; set; }
        public virtual ICollection<EssapproverTran> EssapproverTrans { get; set; }
        public virtual ICollection<Essmaintenance> Essmaintenances { get; set; }
        public virtual ICollection<Famaster> FamasterAssetAccounts { get; set; }
        public virtual ICollection<Famaster> FamasterDeprAccounts { get; set; }
        public virtual ICollection<Famaster> FamasterVendorAccounts { get; set; }
        public virtual ICollection<Gcheque> Gcheques { get; set; }
        public virtual ICollection<GroupParent> GroupParents { get; set; }
        public virtual ICollection<HrabsentList> HrabsentLists { get; set; }
        public virtual ICollection<HrbranchSetting> HrbranchSettings { get; set; }
        public virtual ICollection<HrcampAttendance> HrcampAttendances { get; set; }
        public virtual ICollection<HrdeductionMultidetail> HrdeductionMultidetails { get; set; }
        public virtual ICollection<HrdocumentsExpense> HrdocumentsExpenses { get; set; }
        public virtual ICollection<HrempAdvanceDetail> HrempAdvanceDetails { get; set; }
        public virtual ICollection<HrempDocument> HrempDocuments { get; set; }
        public virtual ICollection<HrempDocumentsExpense> HrempDocumentsExpenses { get; set; }
        public virtual ICollection<HrempExperience> HrempExperiences { get; set; }
        public virtual ICollection<HrempFamily> HrempFamilies { get; set; }
        public virtual ICollection<HrempLeaveDetail> HrempLeaveDetails { get; set; }
        public virtual ICollection<HrempNote> HrempNotes { get; set; }
        public virtual ICollection<HrempPhoto> HrempPhotos { get; set; }
        public virtual ICollection<HrempProjectTran> HrempProjectTrans { get; set; }
        public virtual ICollection<HrempQualification> HrempQualifications { get; set; }
        public virtual ICollection<HrempSalary> HrempSalaries { get; set; }
        public virtual ICollection<HrempWage> HrempWages { get; set; }
        public virtual ICollection<HremployeeTrack> HremployeeTracks { get; set; }
        public virtual ICollection<HrfinalSettlement> HrfinalSettlements { get; set; }
        public virtual ICollection<HrgratuityAndLeaveSalaryTran> HrgratuityAndLeaveSalaryTrans { get; set; }
        public virtual ICollection<HrgratuityParent> HrgratuityParents { get; set; }
        public virtual ICollection<HrinvoiceDetail> HrinvoiceDetails { get; set; }
        public virtual ICollection<Hrmobilization> Hrmobilizations { get; set; }
        public virtual ICollection<HrprojectAttendance> HrprojectAttendances { get; set; }
        public virtual ICollection<HrrateMasterMeterSquare> HrrateMasterMeterSquares { get; set; }
        public virtual ICollection<HrsalaryIncrementEmpDetail> HrsalaryIncrementEmpDetails { get; set; }
        public virtual ICollection<HrsupplierInvoiceDetail> HrsupplierInvoiceDetails { get; set; }
        public virtual ICollection<HrsupplierInvoice> HrsupplierInvoices { get; set; }
        public virtual ICollection<HrtimeCardDetail> HrtimeCardDetails { get; set; }
        public virtual ICollection<HrtimeCardMeterSquare> HrtimeCardMeterSquares { get; set; }
        public virtual ICollection<HrtimeSheet> HrtimeSheets { get; set; }
        public virtual ICollection<Hrwpstran> Hrwpstrans { get; set; }
        public virtual ICollection<Account> InverseParentNavigation { get; set; }
        public virtual ICollection<ItemMaster> ItemMasterCostAccounts { get; set; }
        public virtual ICollection<ItemMaster> ItemMasterInvAccounts { get; set; }
        public virtual ICollection<ItemMaster> ItemMasterPurchaseAccounts { get; set; }
        public virtual ICollection<ItemMaster> ItemMasterSalesAccounts { get; set; }
        public virtual ICollection<Lc> LcAccounts { get; set; }
        public virtual ICollection<Lc> LcBanks { get; set; }
        public virtual ICollection<Lc> LcSuppliers { get; set; }
        public virtual ICollection<Personeldetailstran2> Personeldetailstran2s { get; set; }
        public virtual ICollection<PersonnelDetailsTranTrack> PersonnelDetailsTranTracks { get; set; }
        public virtual ICollection<PortalUser> PortalUsers { get; set; }
        public virtual ICollection<PrepaidVoucherMaster> PrepaidVoucherMasterPartyAccounts { get; set; }
        public virtual ICollection<PrepaidVoucherMaster> PrepaidVoucherMasterPrepaidAccounts { get; set; }
        public virtual ICollection<SalesInvoiceDetail> SalesInvoiceDetails { get; set; }
        public virtual ICollection<SalesInvoice> SalesInvoices { get; set; }
        public virtual ICollection<SchoolFeeMaster> SchoolFeeMasters { get; set; }
        public virtual ICollection<SchoolStudentTran> SchoolStudentTrans { get; set; }
        public virtual ICollection<TourismExcursionInvoice> TourismExcursionInvoices { get; set; }
        public virtual ICollection<TourismRateMaster> TourismRateMasters { get; set; }
        public virtual ICollection<Transaction> TransactionCrAccounts { get; set; }
        public virtual ICollection<Transaction> TransactionDrAccounts { get; set; }
        public virtual ICollection<Transaction> TransactionPostAccounts { get; set; }
        public virtual ICollection<UniqueAccount> UniqueAccounts { get; set; }
        public virtual ICollection<Voucher> VoucherAccounts { get; set; }
        public virtual ICollection<VoucherCollection> VoucherCollections { get; set; }
        public virtual ICollection<VoucherEntry> VoucherEntries { get; set; }
        public virtual ICollection<VoucherEntryDetail> VoucherEntryDetails { get; set; }
        public virtual ICollection<Voucher> VoucherStaffs { get; set; }
        public virtual ICollection<VtypeTran> VtypeTranBankAccountNavigations { get; set; }
        public virtual ICollection<VtypeTran> VtypeTranCardAccountNavigations { get; set; }
        public virtual ICollection<VtypeTran> VtypeTranCashAccountNavigations { get; set; }
        public virtual ICollection<VtypeTran> VtypeTranPostAccountNavigations { get; set; }
    }
}
