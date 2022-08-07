using BankSystemCore.Helpers;
using BankSystemCore.Models;

namespace BankSystemCore.Interface
{
    public interface ITransactionServices
    {
        Task<Account> checkBalance(string accountNumber);
        Task<Response> deposit(decimal amount, string accountNumber);
        Task<Response> transfer(decimal amount, string sender, string receiver);
        Task<Response> withdraw(decimal amount, string accountNumber);
    }
}