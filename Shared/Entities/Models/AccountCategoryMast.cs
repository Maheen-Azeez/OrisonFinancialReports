using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class AccountCategoryMast
    {
        public AccountCategoryMast()
        {
            AccountCategoryLists = new HashSet<AccountCategoryList>();
            AccountCategoryTrans = new HashSet<AccountCategoryTran>();
            Accounts = new HashSet<Account>();
            PaymentModeMastPaymentCategories = new HashSet<PaymentModeMast>();
            PaymentModeMastReceiptCategories = new HashSet<PaymentModeMast>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public byte OrderNo { get; set; }

        public virtual ICollection<AccountCategoryList> AccountCategoryLists { get; set; }
        public virtual ICollection<AccountCategoryTran> AccountCategoryTrans { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<PaymentModeMast> PaymentModeMastPaymentCategories { get; set; }
        public virtual ICollection<PaymentModeMast> PaymentModeMastReceiptCategories { get; set; }
    }
}
