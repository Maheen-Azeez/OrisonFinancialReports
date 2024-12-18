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
    public class InvGroupItemsManager : IInvGroupItemsManager
    {
        private readonly IDapperManager _dapperManager;

        public InvGroupItemsManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
        public async Task<List<dtInvGroupItems>> GetGroupItems(long Id, string key)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("grpItem", Id, DbType.Int32);
            dbPara.Add("Criteria", "GroupItemMaster", DbType.String);
            var GroupItems = Task.FromResult(_dapperManager.GetAll<dtInvGroupItems>
                                ("[FinRep_InventoryVoucherSP]", key,dbPara,
                                commandType: CommandType.StoredProcedure));
            return await GroupItems;
        }
    }
}
