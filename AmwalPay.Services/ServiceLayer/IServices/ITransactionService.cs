using AmwalPay.BAL.Models;
using AmwalPay.BAL.Models.Requests;


namespace AmwalPay.Services.ServiceLayer.IServices
{
    public interface ITransactionService
    {
        Result AddTransaction(TransactionRequest transactionRequest);

    }
}
