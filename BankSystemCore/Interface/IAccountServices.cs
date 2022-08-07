using BankSystemCore.Models;

namespace BankSystemCore.Interface
{
    public interface IAccountServices
    {
        Task<bool> CreateAcc(Account account);
        Task<List<Account>> getAllAccount(Guid Id);
        Task<Account> getOneAccount(Guid Id);
        Task<Account> updateAccount(string accountNumber);
    }
}