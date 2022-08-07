using BankSystemCore.Interface;
using BankSystemCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemCore.DTO
{
    public class AccountDTO : IAccountDTO
    {
        public Account LoggedAccount { get; set; } = new Account();
        public List<Account> LoggedAccounts { get; set; } = new List<Account>();
    }
}
