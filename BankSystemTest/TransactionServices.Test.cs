using BankSystemCore.Helpers;
using BankSystemCore.Interface;
using BankSystemCore.Models;
using BankSystemCore.Services;
using Moq;

namespace BankSystemTest
{
    public class TransactionServicesTest 
    {    
        private readonly Mock<IJsonOperation> _jsonOperation = new Mock<IJsonOperation>();
        private readonly Mock<IUserDTO> _userDTo = new Mock<IUserDTO>();
        private readonly Mock<IAccountDTO> _accountDTo = new Mock<IAccountDTO>();
        private readonly Mock<IAccountServices> _accountServiceMock = new Mock<IAccountServices>();
        [Fact]
        public async void deposit()
        {
            //Arrange
            var accountId = Guid.NewGuid();
            var accountName = "Test Test";
            var accountNumber = "1234567890";
            decimal initialbalance = 100000;
            decimal amount = 1000;
            decimal newBalance = 0;
            Account acc = new Account()
            {
                UserId = accountId,
                AccountNumber = accountNumber,
                Balance = initialbalance,
                Name = accountName,
                CreatedAt = DateTime.Now,
            };
            //Act
            _accountServiceMock.Setup(x => x.updateAccount(accountNumber)).ReturnsAsync(acc);
            TransactionServices transactionServices = new TransactionServices(_accountServiceMock.Object,
                _userDTo.Object, _accountDTo.Object);
            var res = await transactionServices.deposit(amount, accountNumber);
            //Assert
            Assert.NotNull(_accountServiceMock.Object);          
        }
    }
}
