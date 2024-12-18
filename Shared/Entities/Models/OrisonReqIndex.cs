using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class OrisonReqIndex
    {
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string IndexName { get; set; }
        public string ColumnName { get; set; }
        public string IndexType { get; set; }
        public string Pk { get; set; }
        public string UniqueKey { get; set; }
        public decimal? FragPercent { get; set; }
        public string Sqlstmt { get; set; }
    }
}
