using BankSystemCore.Helpers;
using BankSystemCore.Interface;
using BankSystemCore.Models;

namespace BankSystemCore.Services
{ 
    public class TransactionServices : ITransactionServices
    {
        private readonly IAccountServices _accountService;
        private readonly IUserDTO _userDTO;
        private readonly IAccountDTO _accountDTO;
        public TransactionServices(IAccountServices accountServices, IUserDTO userDTO, IAccountDTO accountDTO)
        {
            _accountService = accountServices;
            _userDTO = userDTO;
            _accountDTO = accountDTO;
        }
        // deposit
        public async Task<Response> deposit(decimal amount, string accountNumber)
        {
            decimal newBalance;
            var userAcc = _accountDTO.LoggedAccount;
            var singleAccount = await _accountService.updateAccount(accountNumber);
            if (singleAccount != null)
            {
                newBalance = singleAccount.Balance + amount;
                userAcc = new Account()
                {
                    Id = singleAccount.Id,
                    Name = singleAccount.Name,
                    AccountNumber = singleAccount.AccountNumber,
                    Balance = newBalance,
                    UserId = singleAccount.UserId,
                    AccountType = singleAccount.AccountType,
                    CreatedAt = DateTime.Now,
                };
                var result = await _accountService.CreateAcc(userAcc);
                if (result)
                {
                    return new Response
                    {
                        Message = "deposit successful",
                        Status = true,
                    };
                }
            }
            return new Response
            {
                Message = "Account not found",
                Status = false,
            };
        }
        //withdraw
        public async Task<Response> withdraw(decimal amount, string accountNumber)
        {
            decimal newBalance;
            var userAcc = _accountDTO.LoggedAccount;
            var singleAccount = await _accountService.updateAccount(accountNumber);
            if (singleAccount != null)
            {
                if (singleAccount.Balance >= amount)
                {
                    newBalance = singleAccount.Balance - amount;
                    userAcc = new Account()
                    {
                        Id = singleAccount.Id,
                        Name = singleAccount.Name,
                        AccountNumber = singleAccount.AccountNumber,
                        Balance = newBalance,
                        UserId = singleAccount.UserId,
                        AccountType = singleAccount.AccountType,
                        CreatedAt = DateTime.Now,
                    };
                    var result = await _accountService.CreateAcc(userAcc);
                    if (result)
                    {
                        return new Response
                        {
                            Message = "withdraw successful",
                            Status = true
                        };
                    }
                }
                else
                {
                    return new Response
                    {
                        Message = "Cannot not perform this transaction",
                        Status = false
                    };
                }

            }
            return new Response
            {

                Message = "Account not found",
                Status = false
            };
        }
        //check Balance
        public async Task<Account> checkBalance(string accountNumber)
        {
            return await _accountService.updateAccount(accountNumber);
        }
        //Transfer
        public async Task<Response> transfer(decimal amount, string sender, string receiver)
        {
            var rwithdraw = await withdraw(amount, sender);
            var rdeposit = await deposit(amount, receiver);
            if (rwithdraw.Status == true || rdeposit.Status == true)
            {
                return new Response
                {
                    Message = "Transfer successful",
                    Status = true
                };
            }
            return new Response
            {
                Message = "Account not found",
                Status = false
            };
        }
        
    }
}
