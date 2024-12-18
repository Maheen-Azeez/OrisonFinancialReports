using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using OrisonMIS.Server.Contract.General;
using OrisonMIS.Server.Contract.Inventory;
using OrisonMIS.Shared.Entities.Inventory;

namespace OrisonMIS.Server.Concrete.Inventory
{
    public class InvVoucherAdditionalsManager : IInvVoucherAdditionalsManager
    {
        private readonly IDapperManager _dapperManager;

        public InvVoucherAdditionalsManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
        public async Task<dtInvVoucherAdditionals> GetVoucherAdditionals(long VId, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("VId", VId, DbType.Int32);
            dbPara.Add("Criteria", "VoucherAdditionals", DbType.String);
            //dtInvVoucher voucher = new dtInvVoucher();
            var voucherAdditionals = Task.FromResult(_dapperManager.Get<dtInvVoucherAdditionals>
                                ("[FINWEB_INVENTORYVoucherSP]", key, dbPara, commandType: CommandType.StoredProcedure));
            //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return await voucherAdditionals;
        }

        public async Task<long> CreateVoucherAdditionals(dtInvVoucherAdditionals dtInvVoucherAdditionals, IDbConnection db, IDbTransaction tran)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("VId", dtInvVoucherAdditionals.VID, DbType.Int64);
            dbPara.Add("PartyName", dtInvVoucherAdditionals.PartyName, DbType.String);
            dbPara.Add("VATType", dtInvVoucherAdditionals.VATType, DbType.String);
            dbPara.Add("TAXCode", dtInvVoucherAdditionals.TAXCode, DbType.String);
            dbPara.Add("AmountPaid", dtInvVoucherAdditionals.AmountPaid, DbType.Decimal);
            dbPara.Add("TRNNo", dtInvVoucherAdditionals.TRNNo, DbType.String);
            dbPara.Add("Discount", dtInvVoucherAdditionals.Discount, DbType.Decimal);
            dbPara.Add("Field3", dtInvVoucherAdditionals.Field3, DbType.String);
            dbPara.Add("Field1", dtInvVoucherAdditionals.Field1, DbType.String);
            dbPara.Add("Field2", dtInvVoucherAdditionals.Field2, DbType.String);
            dbPara.Add("Field4", dtInvVoucherAdditionals.Field4, DbType.String);
            dbPara.Add("Field5", dtInvVoucherAdditionals.Field5, DbType.String);
            dbPara.Add("Field6", dtInvVoucherAdditionals.Field6, DbType.String);
            dbPara.Add("Tel", dtInvVoucherAdditionals.Tel, DbType.String);
            dbPara.Add("Field8", dtInvVoucherAdditionals.Field8, DbType.String);
            dbPara.Add("Field9", dtInvVoucherAdditionals.Field9, DbType.String);
            dbPara.Add("Field10", dtInvVoucherAdditionals.Field10, DbType.String);
            dbPara.Add("Date2", dtInvVoucherAdditionals.Date2, DbType.Date);
            dbPara.Add("Address", dtInvVoucherAdditionals.Address, DbType.String);
            dbPara.Add("DefaultWHID", dtInvVoucherAdditionals.DefaultWHID, DbType.String);
            dbPara.Add("HeaderText", dtInvVoucherAdditionals.HeaderText, DbType.String);
            dbPara.Add("FooterText", dtInvVoucherAdditionals.FooterText, DbType.String);
            dbPara.Add("Criteria", "Insert", DbType.String);

            dbPara.Add("NewID", dbType: DbType.Int64, direction: ParameterDirection.Output);

            long newID = _dapperManager.Insert("[FINWEB_DMLVoucherAdditionalsSP]", dbPara, db, tran, commandType: CommandType.StoredProcedure);
            return newID;
        }

        public void UpdateVoucherAdditionals(dtInvVoucherAdditionals dtInvVoucherAdditionals, IDbConnection db, IDbTransaction tran)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("VId", dtInvVoucherAdditionals.VID, DbType.Int64);
            dbPara.Add("PartyName", dtInvVoucherAdditionals.PartyName, DbType.String);
            dbPara.Add("VATType", dtInvVoucherAdditionals.VATType, DbType.String);
            dbPara.Add("TAXCode", dtInvVoucherAdditionals.TAXCode, DbType.String);
            dbPara.Add("AmountPaid", dtInvVoucherAdditionals.AmountPaid, DbType.Decimal);
            dbPara.Add("TRNNo", dtInvVoucherAdditionals.TRNNo, DbType.String);
            dbPara.Add("Discount", dtInvVoucherAdditionals.Discount, DbType.Decimal);
            dbPara.Add("Criteria", "Update", DbType.String);
            dbPara.Add("DefaultWHID", dtInvVoucherAdditionals.DefaultWHID, DbType.String);
            dbPara.Add("Field1", dtInvVoucherAdditionals.Field1, DbType.String);
            dbPara.Add("Field2", dtInvVoucherAdditionals.Field2, DbType.String);
            dbPara.Add("Field3", dtInvVoucherAdditionals.Field3, DbType.String);
            dbPara.Add("Field4", dtInvVoucherAdditionals.Field4, DbType.String);
            dbPara.Add("Field5", dtInvVoucherAdditionals.Field5, DbType.String);
            dbPara.Add("Field6", dtInvVoucherAdditionals.Field6, DbType.String);
            dbPara.Add("Field8", dtInvVoucherAdditionals.Field8, DbType.String);
            dbPara.Add("Field9", dtInvVoucherAdditionals.Field9, DbType.String);
            dbPara.Add("Field10", dtInvVoucherAdditionals.Field10, DbType.String);
            dbPara.Add("Date2", dtInvVoucherAdditionals.Date2, DbType.Date);
            dbPara.Add("HeaderText", dtInvVoucherAdditionals.HeaderText, DbType.String);
            dbPara.Add("FooterText", dtInvVoucherAdditionals.FooterText, DbType.String);

            _dapperManager.UpdateTable("[FINWEB_DMLVoucherAdditionalsSP]", dbPara, db, tran, commandType: CommandType.StoredProcedure);
        }
    }
}
