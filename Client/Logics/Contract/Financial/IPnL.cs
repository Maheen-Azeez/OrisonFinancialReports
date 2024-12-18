using OrisonMIS.Shared.Entities.Financial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Client.Logics.Contract.Financial
{
    public interface IPnL
    {
        Task<IEnumerable<PnL>> Show(long BranchId, string DateFrom, string DateTo, object Double, string SP);
    }
}
