using OrisonMIS.Shared.Entities.Inventory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Contract.Inventory
{
    public interface ITranCostCentreManager
    {
        public void CreateTranCostCentre(dtTranCostCentre trans, IDbConnection db, IDbTransaction tran);
        Task<List<dtTranCostCentre>> GetTranCostCentre(long vid, string key);
    }
}
