using Blazored.SessionStorage;
using OrisonMIS.Shared.Entities.General;
using OrisonMIS.Shared.Entities.Inventory;
using System.Collections.ObjectModel;
using System.Web;
namespace OrisonMIS.Services
{
    public class VoucherEntryService
    {
        HttpClient http = new HttpClient();
        //IDBOperation idbopn;
        private readonly ISessionStorageService SessionStorage;
        private string? key;
        public VoucherEntryService(HttpClient httpClient , ISessionStorageService SessionStorage)
        {
            http = httpClient;
            this.SessionStorage = SessionStorage;
            
        }
        public async Task<string> getUniqueAccID(string val)
        {
            key = HttpUtility.UrlEncode(await SessionStorage.GetItemAsync<string>("token_key"));
            var AccID =  await http.GetStringAsync("api/Uniqueaccounts?acckeyword=" + val + "&key=" + key);
           return AccID;
        }
        public async Task<ObservableCollection<dtInvVoucherEntry>> GenerateVoucherEntry(dtInvTransactions[] DtTransactions,dtInvAccounts ObCustomer, decimal SendRoundoff,string SendCash,string SendtxtVAT, long vID,string InvNo,string Value1,int InVATID, int OutVATID, int CashAccID, int DiscID)
        {
            ObservableCollection<dtInvVoucherEntry> objVE = new ObservableCollection<dtInvVoucherEntry>();
            Console.WriteLine(SendRoundoff);
            Console.WriteLine(SendCash);
            objVE.Clear();
            IEnumerable<int?> salesAccountID = DtTransactions.Select(pkg => pkg.SalesAccountID).ToArray().Distinct();
            Decimal? TotalAmount, VATTot;
            int SlNo = 0;
            //Item Sales Account
            foreach (int? dt in salesAccountID)
            {
                TotalAmount = DtTransactions.Where(items => items.SalesAccountID == dt).Select(amt => amt.Amount).ToArray().Sum();
                dtInvVoucherEntry objVEnt = new dtInvVoucherEntry();
                objVEnt.VID = vID;
                objVEnt.RowType = "Cr";
                objVEnt.Description = "Sales-" + ObCustomer.AccountName;
                objVEnt.AccountID = Convert.ToInt32(dt);
                objVEnt.Credit = Math.Round(Convert.ToDecimal(TotalAmount), 2, MidpointRounding.AwayFromZero);
                objVEnt.Debit = 0;
                objVEnt.TranType = "Inventory";
                objVEnt.Action = "C";
                objVEnt.VisibleonPrint = Convert.ToBoolean(1);
                objVEnt.Reconciled = Convert.ToBoolean(0);
                objVEnt.Active = Convert.ToBoolean(1);
                objVEnt.RowState = "Insert";
                SlNo = SlNo + 1;
                objVEnt.SlNo = SlNo;
                objVE.Add(objVEnt);
            }

            //VAT Entry
            VATTot = 0;
            VATTot = Convert.ToDecimal(SendtxtVAT);
            if (VATTot != 0)
            {
                dtInvVoucherEntry objVEnt = new dtInvVoucherEntry();
                objVEnt.VID = vID;
                objVEnt.RowType = "Cr";
                objVEnt.Description = "VAT - Sales Inv. No:" + InvNo;
                objVEnt.AccountID = Convert.ToInt32(OutVATID);
                objVEnt.Credit = Math.Round(Convert.ToDecimal(VATTot), 2, MidpointRounding.AwayFromZero);
                objVEnt.Debit = 0;
                objVEnt.TranType = "VAT";
                objVEnt.Action = "C";
                objVEnt.VisibleonPrint = Convert.ToBoolean(1);
                objVEnt.Reconciled = Convert.ToBoolean(0);
                objVEnt.Active = Convert.ToBoolean(1);
                objVEnt.RowState = "Insert";
                SlNo = SlNo + 1;
                objVEnt.SlNo = SlNo;
                objVE.Add(objVEnt);
            }

            //Party or Cash Entry
            TotalAmount = DtTransactions.Select(amt => amt.NetAmount).ToArray().Sum();
            TotalAmount = Math.Round(Convert.ToDecimal(TotalAmount), 2, MidpointRounding.AwayFromZero);
            if (Math.Round(Convert.ToDecimal(SendRoundoff), 2, MidpointRounding.AwayFromZero) != 0)
            {
                dtInvVoucherEntry objVEt = new dtInvVoucherEntry();
                objVEt.VID = vID;
                objVEt.RowType = "Dr";
                objVEt.Description = "Sales Discount - Sales Inv. No:" + InvNo;
                objVEt.AccountID = Convert.ToInt32(DiscID);
                objVEt.Debit = Math.Round(Convert.ToDecimal(SendRoundoff), 2, MidpointRounding.AwayFromZero);
                objVEt.Credit = 0;
                objVEt.TranType = "Discount";
                objVEt.Action = "C";
                objVEt.VisibleonPrint = Convert.ToBoolean(1);
                objVEt.Reconciled = Convert.ToBoolean(0);
                objVEt.Active = Convert.ToBoolean(1);
                objVEt.RowState = "Insert";
                SlNo = SlNo + 1;
                objVEt.SlNo = SlNo;
                objVE.Add(objVEt);
            }


            TotalAmount = Math.Round(Convert.ToDecimal(TotalAmount), 2, MidpointRounding.AwayFromZero) - Math.Round(Convert.ToDecimal(SendRoundoff), 2, MidpointRounding.AwayFromZero);
            if (Value1 == "Cash")
            {
                dtInvVoucherEntry objVEnt = new dtInvVoucherEntry();
                objVEnt.VID = vID;
                objVEnt.RowType = "Dr";
                objVEnt.Description = "Cash Sales";
                objVEnt.AccountID = Convert.ToInt32(CashAccID);
                objVEnt.Debit = Math.Round(Convert.ToDecimal(TotalAmount), 2, MidpointRounding.AwayFromZero);
                objVEnt.Credit = 0;
                objVEnt.TranType = "Cash";
                objVEnt.Action = "C";
                objVEnt.VisibleonPrint = Convert.ToBoolean(1);
                objVEnt.Reconciled = Convert.ToBoolean(0);
                objVEnt.Active = Convert.ToBoolean(1);
                objVEnt.RowState = "Insert";
                SlNo = SlNo + 1;
                objVEnt.SlNo = SlNo;
                objVE.Add(objVEnt);
            }
            else
            {
                if (Math.Round(Convert.ToDecimal(SendCash), 2, MidpointRounding.AwayFromZero) != 0)
                {
                    dtInvVoucherEntry objVEt = new dtInvVoucherEntry();
                    objVEt.VID = vID;
                    objVEt.RowType = "Dr";
                    objVEt.Description = "Cash Sales";
                    objVEt.AccountID = Convert.ToInt32(CashAccID);
                    objVEt.Debit = Math.Round(Convert.ToDecimal(SendCash), 2, MidpointRounding.AwayFromZero);
                    objVEt.Credit = 0;
                    objVEt.TranType = "Cash";
                    objVEt.Action = "C";
                    objVEt.VisibleonPrint = Convert.ToBoolean(1);
                    objVEt.Reconciled = Convert.ToBoolean(0);
                    objVEt.Active = Convert.ToBoolean(1);
                    objVEt.RowState = "Insert";
                    SlNo = SlNo + 1;
                    objVEt.SlNo = SlNo;
                    objVE.Add(objVEt);
                }
                TotalAmount = Math.Round(Convert.ToDecimal(TotalAmount - Math.Round(Convert.ToDecimal(SendCash), 2, MidpointRounding.AwayFromZero)), 2, MidpointRounding.AwayFromZero);
                dtInvVoucherEntry objVEnt = new dtInvVoucherEntry();
                objVEnt.VID = vID;
                objVEnt.RowType = "Dr";
                objVEnt.Description = "Cash Sales";
                objVEnt.AccountID = Convert.ToInt32(ObCustomer.ID);
                objVEnt.Debit = Math.Round(Convert.ToDecimal(TotalAmount), 2, MidpointRounding.AwayFromZero);
                objVEnt.Credit = 0;
                objVEnt.TranType = "Party";
                objVEnt.Action = "C";
                objVEnt.VisibleonPrint = Convert.ToBoolean(1);
                objVEnt.Reconciled = Convert.ToBoolean(0);
                objVEnt.Active = Convert.ToBoolean(1);
                objVEnt.RowState = "Insert";
                SlNo = SlNo + 1;
                objVEnt.SlNo = SlNo;
                objVE.Add(objVEnt);
            }
            return objVE;
        }
        public async Task<ObservableCollection<dtInvVoucherEntry>> CreateVoucherEntry(ObservableCollection<dtInvVoucherEntry> DtVoucherEntryOld, dtInvTransactions[] DtTransactions, dtInvAccounts ObCustomer, decimal SendRoundoff, string SendCash, string SendtxtVAT, long vID, string InvNo, string Value1)
        {
            string cmdtext;
            int InVATID, OutVATID, CashAccID, DiscID;
            cmdtext = "VAT_Input VAT";
            InVATID = Convert.ToInt32(getUniqueAccID(cmdtext).Result);
            cmdtext = "VAT_Output VAT";
            OutVATID = Convert.ToInt32(getUniqueAccID(cmdtext).Result);
            cmdtext = "Cash Account";
            CashAccID = Convert.ToInt32(getUniqueAccID(cmdtext).Result);
            cmdtext = "Discount Allowed";
            DiscID = Convert.ToInt32(getUniqueAccID(cmdtext).Result);
            dtInvVoucherEntry[] DtVoucherEntrNew = GenerateVoucherEntry(DtTransactions, ObCustomer, SendRoundoff, SendCash, SendtxtVAT, vID, InvNo, Value1, InVATID, OutVATID, CashAccID, DiscID).Result.ToArray();
            dtInvVoucherEntry sr = new dtInvVoucherEntry();
            ObservableCollection<dtInvVoucherEntry> objVE = new ObservableCollection<dtInvVoucherEntry>();
            //ObservableCollection<dtInvVoucherEntry> DelArray = new ObservableCollection<dtInvVoucherEntry>();
            if (DtVoucherEntrNew != null && DtVoucherEntrNew.Count() > 0)
            {
                if(DtVoucherEntryOld != null && DtVoucherEntryOld.Count()>0)
                {
                    foreach(dtInvVoucherEntry dtOld in DtVoucherEntryOld)
                    {
                        sr = DtVoucherEntrNew.Where(T => T.AccountID == dtOld.AccountID && T.TranType == dtOld.TranType).FirstOrDefault();
                        if (sr == null)
                        {
                            dtOld.RowState = "Delete";
                            objVE.Add(dtOld);
                            //DtTransactionsOld.Remove(dtOld);
                        }
                    }
                    foreach (dtInvVoucherEntry Del in objVE)
                    {
                        DtVoucherEntryOld.Remove(Del);
                    }
                    if (DtVoucherEntryOld.Count() > 0)
                    {
                        foreach(dtInvVoucherEntry dtNew in DtVoucherEntrNew)
                        {
                            sr = DtVoucherEntryOld.Where(T => T.AccountID == dtNew.AccountID && T.TranType == dtNew.TranType).FirstOrDefault();
                            if (sr == null)
                            {
                                objVE.Add(dtNew);
                            }
                            else
                            {
                                sr.RowState = "Update";
                                sr.RowType = dtNew.RowType;
                                sr.Debit = dtNew.Debit;
                                sr.Credit = dtNew.Credit;
                                sr.Description = dtNew.Description;
                                sr.TranType = dtNew.TranType;
                                objVE.Add(sr);
                            }
                        }
                    }
                }
                else
                {
                    foreach(dtInvVoucherEntry dtNew in DtVoucherEntrNew)
                    {
                        objVE.Add(dtNew);
                    }
                }
            }
            else if(DtVoucherEntryOld.Count()>0)
            { 
                foreach(dtInvVoucherEntry dtOld in DtVoucherEntryOld)
                {
                    dtOld.RowState = "Delete";
                    objVE.Add(dtOld);
                    //DtVoucherEntryOld.Remove(dtOld);
                }
                //foreach(dtInvVoucherEntry Del in objVE)
                //{
                //    DtVoucherEntryOld.Remove(Del);
                //}
            }
            return objVE;
        }

        public async Task<ObservableCollection<dtInvVoucherEntry>> UpdateVoucherEntry(ObservableCollection<dtInvVoucherEntry> DtVoucherEntryOld, dtInvVoucherEntry[] DtVoucherEntrNew)
        {
            string cmdtext;
            int InVATID, OutVATID, CashAccID, DiscID;
            cmdtext = "VAT_Input VAT";
            InVATID = Convert.ToInt32(getUniqueAccID(cmdtext).Result);
            cmdtext = "VAT_Output VAT";
            OutVATID = Convert.ToInt32(getUniqueAccID(cmdtext).Result);
            cmdtext = "Cash Account";
            CashAccID = Convert.ToInt32(getUniqueAccID(cmdtext).Result);
            cmdtext = "Discount Allowed";
            DiscID = Convert.ToInt32(getUniqueAccID(cmdtext).Result);
            dtInvVoucherEntry sr = new dtInvVoucherEntry();
            ObservableCollection<dtInvVoucherEntry> objVE = new ObservableCollection<dtInvVoucherEntry>();
            if (DtVoucherEntrNew != null && DtVoucherEntrNew.Count() > 0)
            {
                if (DtVoucherEntryOld != null && DtVoucherEntryOld.Count() > 0)
                {
                    foreach (dtInvVoucherEntry dtOld in DtVoucherEntryOld)
                    {
                        sr = DtVoucherEntrNew.Where(T => T.AccountID == dtOld.AccountID && T.TranType == dtOld.TranType).FirstOrDefault();
                        if (sr == null)
                        {
                            dtOld.RowState = "Delete";
                            objVE.Add(dtOld);
                            //DtTransactionsOld.Remove(dtOld);
                        }
                    }
                    foreach (dtInvVoucherEntry Del in objVE)
                    {
                        DtVoucherEntryOld.Remove(Del);
                    }
                    if (DtVoucherEntryOld.Count() > 0)
                    {
                        foreach (dtInvVoucherEntry dtNew in DtVoucherEntrNew)
                        {
                            sr = DtVoucherEntryOld.Where(T => T.AccountID == dtNew.AccountID && T.TranType == dtNew.TranType).FirstOrDefault();
                            if (sr == null)
                            {
                                objVE.Add(dtNew);
                            }
                            else
                            {
                                sr.RowState = "Update";
                                sr.RowType = dtNew.RowType;
                                sr.Debit = dtNew.Debit;
                                sr.Credit = dtNew.Credit;
                                sr.Description = dtNew.Description;
                                sr.TranType = dtNew.TranType;
                                objVE.Add(sr);
                            }
                        }
                    }
                }
                else
                {
                    foreach (dtInvVoucherEntry dtNew in DtVoucherEntrNew)
                    {
                        objVE.Add(dtNew);
                    }
                }
            }
            else if (DtVoucherEntryOld.Count() > 0)
            {
                foreach (dtInvVoucherEntry dtOld in DtVoucherEntryOld)
                {
                    dtOld.RowState = "Delete";
                    objVE.Add(dtOld);
                    //DtVoucherEntryOld.Remove(dtOld);
                }
                //foreach(dtInvVoucherEntry Del in objVE)
                //{
                //    DtVoucherEntryOld.Remove(Del);
                //}
            }
            return objVE;
        }
    }
}
