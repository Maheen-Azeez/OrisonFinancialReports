using OrisonMIS.Shared.Entities.Inventory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Server.Contract.Inventory
{
    public interface IVEntryCostCentreManager
    {
        public void VEntryCostCentreEvents(dtVentryCostCentre Ventry, IDbConnection db, IDbTransaction tran);
        Task<List<dtVentryCostCentre>> GetVEntryCostCentre(long vid, string key);
    }
}
