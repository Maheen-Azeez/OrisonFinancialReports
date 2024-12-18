﻿using System;
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
    public class InvItemsManager : IInvItemsManager
    {
        private readonly IDapperManager _dapperManager;

        public InvItemsManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
        public async Task<List<dtItems>> GetItems(int BranchId, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("BranchId", BranchId, DbType.Int32);
            dbPara.Add("Criteria", "ItemMaster", DbType.String);
            //dtInvVoucher voucher = new dtInvVoucher();
            var Items = Task.FromResult(_dapperManager.GetAll<dtItems>
                                ("[FinRep_InventoryVoucherSP]", key,dbPara,
                                commandType: CommandType.StoredProcedure));
            //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return await Items;
        }
        public async Task<dtItems> GetItemsbyID(int BranchId,int itemID, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("BranchId", BranchId, DbType.Int32);
            dbPara.Add("ItemID", itemID, DbType.Int32);
            dbPara.Add("Criteria", "ItembyID", DbType.String);
            //dtInvVoucher voucher = new dtInvVoucher();
            var Items = Task.FromResult(_dapperManager.Get<dtItems>
                                ("[FinRep_InventoryVoucherSP]", key, dbPara,
                                commandType: CommandType.StoredProcedure));
            //($"SELECT * FROM [Article] WHERE Title like '%{search}%' ORDER BY {orderBy} {direction} OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY; ", null, commandType: CommandType.Text));
            return await Items;
        }
    }
}
