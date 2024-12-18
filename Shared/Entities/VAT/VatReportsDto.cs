using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.VAT
{
    public class VatReportsDto
    {
        public List<VatRegisterDto>? vatRegister { get; set; }
        public List<CurrentVatDto>? currentVat { get; set; }
        public List<InPutVatDto>? inPutVat {  get; set; }
        public List<OutPutVatDto>? outPutVat {  get; set; }
    }
}
