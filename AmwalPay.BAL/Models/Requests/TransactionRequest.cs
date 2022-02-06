using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmwalPay.BAL.Models.Requests
{
    public class TransactionRequest
    {

        public double ProcessingCode { get; set; }
        public double SystemTraceNr { get; set; }
        public double FunctionCode { get; set; }
        public double CardNo { get; set; }
        public string CardHolder { get; set; }
        public double AmountTrxn { get; set; }
        public double CurrencyCode { get; set; }
    }
}
