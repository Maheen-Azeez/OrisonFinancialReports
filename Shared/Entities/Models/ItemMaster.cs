using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class ItemMaster
    {
        public ItemMaster()
        {
            AvgCostNews = new HashSet<AvgCostNew>();
            AvgCosts = new HashSet<AvgCost>();
            EstimationItems = new HashSet<EstimationItem>();
            GroupDetailGroups = new HashSet<GroupDetail>();
            GroupDetailItems = new HashSet<GroupDetail>();
            InvItemSearches = new HashSet<InvItemSearch>();
            ItemMasterDetails = new HashSet<ItemMasterDetail>();
            ItemMasterMultiUnits = new HashSet<ItemMasterMultiUnit>();
            ProdFinishedItems = new HashSet<ProdFinishedItem>();
            ProdMaterials = new HashSet<ProdMaterial>();
            PromotionItems = new HashSet<PromotionItem>();
            Transactions = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public decimal? SellingPrice { get; set; }
        public string Oemno { get; set; }
        public string PartNo { get; set; }
        public int CategoryId { get; set; }
        public string Manufacturer { get; set; }
        public string BarCode { get; set; }
        public string ModelNo { get; set; }
        public string Unit { get; set; }
        public decimal? Rol { get; set; }
        public string Remarks { get; set; }
        public bool IsGroup { get; set; }
        public bool? StockItem { get; set; }
        public bool Inactive { get; set; }
        public int? InvAccountId { get; set; }
        public int? CostAccountId { get; set; }
        public int? PurchaseAccountId { get; set; }
        public int? SalesAccountId { get; set; }
        public decimal? Stock { get; set; }
        public decimal? InvoicedStock { get; set; }
        public decimal? AvgCost { get; set; }
        public decimal? LastCost { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public int? ModifiedUserId { get; set; }
        public int? BranchId { get; set; }
        public string Location { get; set; }
        public string MajorGroup { get; set; }
        public string MiddleGroup { get; set; }
        public string MinorGroup { get; set; }
        public decimal? CashPrice { get; set; }
        public decimal? CreditPrice { get; set; }
        public decimal? Roq { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public string Field5 { get; set; }
        public DateTime? PurDate { get; set; }
        public bool FixedAssetItem { get; set; }
        public decimal? ExcisePercen { get; set; }
        public string Vatpercen { get; set; }
        public decimal? Vrate { get; set; }

        public virtual Category Category { get; set; }
        public virtual Account CostAccount { get; set; }
        public virtual Account InvAccount { get; set; }
        public virtual GroupMajor MajorGroupNavigation { get; set; }
        public virtual GroupMiddle MiddleGroupNavigation { get; set; }
        public virtual GroupMinor MinorGroupNavigation { get; set; }
        public virtual Account PurchaseAccount { get; set; }
        public virtual Account SalesAccount { get; set; }
        public virtual UnitMaster UnitNavigation { get; set; }
        public virtual ItemSublist ItemSublist { get; set; }
        public virtual ICollection<AvgCostNew> AvgCostNews { get; set; }
        public virtual ICollection<AvgCost> AvgCosts { get; set; }
        public virtual ICollection<EstimationItem> EstimationItems { get; set; }
        public virtual ICollection<GroupDetail> GroupDetailGroups { get; set; }
        public virtual ICollection<GroupDetail> GroupDetailItems { get; set; }
        public virtual ICollection<InvItemSearch> InvItemSearches { get; set; }
        public virtual ICollection<ItemMasterDetail> ItemMasterDetails { get; set; }
        public virtual ICollection<ItemMasterMultiUnit> ItemMasterMultiUnits { get; set; }
        public virtual ICollection<ProdFinishedItem> ProdFinishedItems { get; set; }
        public virtual ICollection<ProdMaterial> ProdMaterials { get; set; }
        public virtual ICollection<PromotionItem> PromotionItems { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
