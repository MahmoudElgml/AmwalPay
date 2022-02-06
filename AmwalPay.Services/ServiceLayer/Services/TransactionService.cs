using AmwalPay.BAL.Models;
using AmwalPay.BAL.Models.Requests;
using AmwalPay.Services.ServiceLayer.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmwalPay.Services.ServiceLayer.Services
{
    public class TransactionService : ITransactionService
    {
        public Result AddTransaction(TransactionRequest transactionRequest)
        {
            return new Result
            {
                ResponseCode = "00",
                Message = "Success",
                ApprovalCode = 123123,
                DateTime = DateTime.Now.ToString("yyyyMMdd")
            };

        }
    }
}
