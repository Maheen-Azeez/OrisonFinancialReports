using OrisonMIS.Shared.Entities.Financial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Client.Logics.Contract.Financial
{
    public interface IStmt
    {
        Task<IEnumerable<Statement>> Show(long BranchId, string DateFrom, string DateTo, string SP);
    }
}
