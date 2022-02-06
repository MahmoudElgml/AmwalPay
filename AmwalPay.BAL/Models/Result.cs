using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmwalPay.BAL.Models
{
    public class Result
    {


        public string ResponseCode { get; set; }
        public string Message { get; set; }
        public double ApprovalCode { get; set; }
        public string DateTime { get; set; }

}
}
