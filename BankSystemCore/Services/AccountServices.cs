using BankSystemCore.Interface;
using BankSystemCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemCore.Services 
{ 
    public class AccountServices : IAccountServices
    {
        private readonly string accountFile = "Accounts.json";
        private readonly IJsonOperation _dbContext;
        private readonly IUserDTO _userDTO;
        public AccountServices(IJsonOperation dbContext, IUserDTO userDTO)
        {
            _dbContext = dbContext;
            _userDTO = userDTO;
        }
        public async Task<bool> CreateAcc(Account account)
        {            
           
                account.CreatedAt = DateTime.Now;
                try
                {
                   return await _dbContext.WriteJson<Account>(account, accountFile);
                }
                catch (Exception)
                {
                    throw;
                }          
        }
        public async Task<List<Account>> getAllAccount(Guid Id)
        {
            try
            {
                var accounts = await _dbContext.ReadJson<Account>(accountFile);
                return accounts.Where(x => x.UserId == Id).DistinctBy(x => x.AccountNumber).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<Account> getOneAccount(Guid Id)
        {
            try
            {
                var accounts = await _dbContext.ReadJson<Account>(accountFile);
                return  accounts.LastOrDefault(x => x.UserId == Id);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<Account> updateAccount(string accountNumber)
        {
            try
            {
                var accounts = await _dbContext.ReadJson<Account>(accountFile);
                return accounts.LastOrDefault(x => x.AccountNumber == accountNumber);
            }
            catch (Exception)
            {
                throw;
            }
        }



    }
}
