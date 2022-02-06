using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmwalPay.DAL.Entities
{
    public class Transaction
    {

       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public double ProcessingCode { get; set; }
        public double SystemTraceNr { get; set; }
        public double FunctionCode { get; set; }
        public double CardNo { get; set; }
        public string CardHolder { get; set; }
        public double AmountTrxn { get; set; }
        public double CurrencyCode { get; set; }
    }
}
