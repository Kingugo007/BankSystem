using BankSystemCore.Helpers;

namespace BankSystemTest
{
    public class CreateAccountNumberTest
    {
        [Fact]
        public void check_if_account_number_is_string_Of_10_Numbers()
        {
            //Arrange
            var expected = @"^\d{10}$";
            //Act
            var result = CreateAccNumber.accNumber();
            //Assert
            Assert.Matches(expected, result);
        }
    }
}
