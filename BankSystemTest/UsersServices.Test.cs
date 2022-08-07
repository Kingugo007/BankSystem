using BankSystemCore.Helpers;
using BankSystemCore.Interface;
using BankSystemCore.Models;
using BankSystemCore.Services;
using Moq;

namespace BankSystemTest
{
    public class UsersServicesTest
    {
  
        private readonly Mock<IJsonOperation> _operationMock = new Mock<IJsonOperation>();
        private readonly Mock<IUtilities> _UtilitiesMock = new Mock<IUtilities>();
        private readonly Mock<IAccountServices> _accountServicesMock = new Mock<IAccountServices>();
        private readonly string jsonFile = "Users.json";
        [Fact]
        public async Task loginUser_ShouldReadAll_Users()
        {
            //Arrange
           List<User> users = new List<User>();
            var email = "test@gmail.com";
            var pass = "test@123";
            var UserId = Guid.NewGuid();    
            users.Add(new User
            {
                Id = UserId,
                FirstName = "Test",
                LastName = "Test",
                Password = pass,
                Email = email,
                Phone =  "08136887343",
                CreatedAt = DateTime.Now,          
            });                
            //Act
            _operationMock.Setup(x => x.ReadJson<User>(jsonFile)).ReturnsAsync(users);
            UserServices userServices = new UserServices(_operationMock.Object, _UtilitiesMock.Object, _accountServicesMock.Object);
            var result = await userServices.Login(email, pass);
            //Assert
            Assert.NotNull(users);    
        }
        [Fact]
        public async Task loginUser_ShouldReturn_Matchaccount()
        {
            //Arrange
            var email = "test@gmail.com";
            var pass = "test@123";
            var accountNumber = "1234567890";
            var UserId = Guid.NewGuid();
            Account account =  new Account()
            {
               UserId = UserId,
               Name = "Test Test",
               AccountNumber = accountNumber,
               Balance = 1000,
               AccountType = "Savings"

            };
            //Act
            _accountServicesMock.Setup(x => x.getOneAccount(UserId)).ReturnsAsync(account);
            UserServices userServices = new UserServices(_operationMock.Object, _UtilitiesMock.Object, _accountServicesMock.Object);
            var result = await userServices.Login(email, pass);
            //Assert
            Assert.NotNull(_accountServicesMock.Object);
        }

        [Fact]
        public async Task check_existingUser_beforeRegister()
        {
            var users = new List<User>();
            User user = new()
            {
               Id = Guid.NewGuid(),
               FirstName = "Test",
               LastName = "Test",
               Email = "test@gmail.com",
               Password = "test@123",
               CreatedAt = DateTime.Now
            };
            users.Add(user);    
            _operationMock.Setup(x => x.ReadJson<User>(jsonFile)).ReturnsAsync(users);
            UserServices userServices = new UserServices(_operationMock.Object, _UtilitiesMock.Object, _accountServicesMock.Object);
            var res = await userServices.Register(user);
            Assert.Equal("User already exist", res.Message);    
        }
        [Fact]
        public async Task registerUser_if_email_notexist()
        {
            var users = new List<User>();
            User user = new()
            {
                Id = Guid.NewGuid(),
                FirstName = "Test",
                LastName = "Test",
                Email = "test@gmail.com",
                Password = "test@123",
                CreatedAt = DateTime.Now
            };
            users.Add(user);
            _operationMock.Setup(x => x.WriteJson<User>(user, jsonFile)).ReturnsAsync(true);
            UserServices userServices = new UserServices(_operationMock.Object, _UtilitiesMock.Object, _accountServicesMock.Object);
            var res = await userServices.Register(user);
            Assert.True(res.Status);
        }
        [Fact]
        public async Task check_ifUser_Saved_toUsersjsonfile()
        {
            var users = new List<User>();
            User user = new()
            {
                Id = Guid.NewGuid(),
                FirstName = "Test",
                LastName = "Test",
                Email = "test@gmail.com",
                Password = "test@123",
                CreatedAt = DateTime.Now
            };
            users.Add(user);
            _operationMock.Setup(x => x.WriteJson<User>(user, "wrongFile.json")).ReturnsAsync(true);
            UserServices userServices = new UserServices(_operationMock.Object, _UtilitiesMock.Object, _accountServicesMock.Object);
            var res = await userServices.Register(user);
            Assert.Equal("Unable to save user info", res.Message);
        }

    }
}
