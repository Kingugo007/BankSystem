using BankSystemCore.Interface;
using BankSystemCore.Models;
using BankSystemCore.Services;
using Moq;

namespace BankSystemTest
{
    public class AccountServicesTest
    {
        private readonly Mock<IJsonOperation> _jsonOperation = new Mock<IJsonOperation>();
        private readonly Mock<IUserDTO> _userDTo = new Mock<IUserDTO>();
        private readonly string jsonFile = "Accounts.json";
        [Fact]
        public async Task checkIfAccountIsCreated()
        {
            Account account = new Account()
            {
                Id = Guid.NewGuid(),
                AccountNumber = "1234567890",                
                Balance = 120,
                Name = "Test Test",
                CreatedAt = DateTime.Now,
             };
            
           _jsonOperation.Setup(x => x.WriteJson<Account>(account, jsonFile)).ReturnsAsync(true);
            AccountServices accountServices = new AccountServices(_jsonOperation.Object, _userDTo.Object);
            var res = await accountServices.CreateAcc(account);
            Assert.True(res);
        }

        [Fact]
        public async Task checkIfAccountIsNotCreated()
        {
            //Arrange
            Account account = new Account()
            {
                Id = Guid.NewGuid(),
                AccountNumber = "1234567890",
                Balance = 120,
                Name = "Test Test",
                CreatedAt = DateTime.Now,
            };
            //Act
            _jsonOperation.Setup(x => x.WriteJson<Account>(account, jsonFile)).ReturnsAsync(false);
            AccountServices accountServices = new AccountServices(_jsonOperation.Object, _userDTo.Object);
            var res = await accountServices.CreateAcc(account);
            //Assert
            Assert.False(res);  
        }
        [Fact]
        public async Task getAllAccountById_ShouldReturnListOfAccounts()
        {
            //Arrange
            List<Account> accounts = new List<Account>();
            Account acc = new Account()
            {
                Id = Guid.NewGuid(),
                AccountNumber = "1234567890",
                Balance = 120,
                Name = "Test Test",
                CreatedAt = DateTime.Now,
            };
            accounts.Add(acc);
            //Act
            _jsonOperation.Setup(x => x.ReadJson<Account>(jsonFile)).ReturnsAsync(accounts);
            AccountServices accountServices = new AccountServices(_jsonOperation.Object, _userDTo.Object);
            var res = await accountServices.getAllAccount(acc.Id);
            //Assert
            Assert.NotNull(res);
        }

        [Fact]
        public async Task getSingleAccount_ShouldReturnMatchAccount()
        {
            //Arrange
            List<Account> accounts = new List<Account>();
            var accountId = Guid.NewGuid();
            var accountName = "Test Test";
            Account acc = new Account()
            {
                UserId = accountId,
                AccountNumber = "1234567890",
                Balance = 120,
                Name = accountName,
                CreatedAt = DateTime.Now,
            };
            accounts.Add(acc);
            //Act
            _jsonOperation.Setup(x => x.ReadJson<Account>(jsonFile)).ReturnsAsync(accounts);
            AccountServices accountServices = new AccountServices(_jsonOperation.Object, _userDTo.Object);
            var res = await accountServices.getOneAccount(accountId);
            //Assert
            Assert.Equal(accountId.ToString(), res.UserId.ToString());
        }
        [Fact]
        public async Task updateAccount_ShouldReturnMatchAccount()
        {
            //Arrange
            List<Account> accounts = new List<Account>();
            var accountId = Guid.NewGuid();
            var accountName = "Test Test";
            var accountNumber = "1234567890";
            Account acc = new Account()
            {
                UserId = accountId,
                AccountNumber = accountNumber,
                Balance = 120,
                Name = accountName,
                CreatedAt = DateTime.Now,
            };
            accounts.Add(acc);
            //Act
            _jsonOperation.Setup(x => x.ReadJson<Account>(jsonFile)).ReturnsAsync(accounts);
            AccountServices accountServices = new AccountServices(_jsonOperation.Object, _userDTo.Object);
            var res = await accountServices.updateAccount(accountNumber);
            //Assert
            Assert.Equal(acc.AccountNumber, res.AccountNumber);
        }
        [Fact]
        public void throwException_ifAccount_NotCreated()
        {
            //Arrange
            Account account = null;
            //Act
            _jsonOperation.Setup(x => x.WriteJson<Account>(account, "wrongFile")).Throws<Exception>();
            AccountServices accountServices = new AccountServices(_jsonOperation.Object, _userDTo.Object);
            //Assert
            Assert.ThrowsAsync<Exception>( async () => await accountServices.CreateAcc(account));
        }
    }
}
