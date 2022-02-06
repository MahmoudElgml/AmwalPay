using AmwalPay.BAL.Models;
using AmwalPay.BAL.Models.Requests;
using AmwalPay.Services.ServiceLayer.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AmwalPay.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TransactionController : ControllerBase
    {

        private ITransactionService TransactionService;

        public TransactionController(ITransactionService _transactionService)
        {
            TransactionService = _transactionService;
        }


        [HttpPost("AddTransaction")]
        public Result favourite(TransactionRequest TransactionRequest)
        {
            var result = TransactionService.AddTransaction(TransactionRequest);
            return result;
        }
    
    
    }


    
}
