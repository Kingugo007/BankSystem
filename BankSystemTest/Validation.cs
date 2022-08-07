using BankSystemCore.Helpers;
using BankSystemCore.Interface;
using BankSystemCore.Models;
using Xunit;

namespace BankSystemTest
{
    public class ValidatorsTest
    {
        private readonly IValidators _validators;

        public ValidatorsTest()
        {
            _validators = new Validators();
        }
        User user = new User();
        [Fact]
        public void check_if_first_character_IsUpperCase()
        {
            //Arrange
            user.FirstName = "Test";
            user.LastName = "Test";
            //Assert
            Assert.True(_validators.CheckName(user.FirstName));
            Assert.True(_validators.CheckName(user.LastName));
            Assert.False(_validators.CheckName("test"));        
        }
        [Fact]
        public void fullNameShouldbe_String_with_firstCharacter_UpperCase()
        {
            //Arrange
            user.FirstName = "Test";
            user.LastName = "Test";
            //Assert
            Assert.Equal("Test Test", user.FullName);
            Assert.NotEqual("Test test", user.FullName);
        }
        [Fact]
        public void passwordShouldBe_atLeastOnenumber_OneSpecialChar_Oneletter()
        {
            //Arrange
            user.Password = "test@123";       
            //Assert
            Assert.True(_validators.CheckPassword(user.Password));
            Assert.False(_validators.CheckPassword("test123"));
            Assert.False(_validators.CheckPassword("test"));
            Assert.False(_validators.CheckPassword("1234"));
        }
        [Fact]
        public void emailShouldBe_correct_email_format()
        {
            //Arrange
            user.Email = "test@mail.com";
            //assert
            Assert.True(_validators.CheckEmail(user.Email));
            Assert.False(_validators.CheckEmail("test@mail"));
            Assert.False(_validators.CheckEmail("test@"));
            Assert.False(_validators.CheckEmail("@1233"));
        }
        [Fact]
        public void phoneNumber_ShouldBe_11Digits()
        {
            //Arrange
            user.Phone = "08132128393";
            //Assert
            Assert.True(_validators.CheckPhoneNumber(user.Phone));
            Assert.False(_validators.CheckPhoneNumber("081233433"));
            Assert.False(_validators.CheckPhoneNumber("abcdefgh"));           
        }
        [Fact]
        public void accountNumber()
        {
            //Assert
            Assert.True(_validators.CheckAccountNumber("0123456789"));
            Assert.False(_validators.CheckAccountNumber("0123456789s"));
        }
        [Fact]
        public void inputDigit_ShouldBe_Converted_without_errors()
        {
            Assert.True(_validators.CheckNumber("9232"));
            Assert.False(_validators.CheckNumber("i32"));
        }


    }
}