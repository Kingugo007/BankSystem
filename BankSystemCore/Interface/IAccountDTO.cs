using BankSystemCore.Models;

namespace BankSystemCore.Interface
{
    public interface IAccountDTO
    {
        Account LoggedAccount { get; set; }
        List<Account> LoggedAccounts { get; set; }
    }
}
