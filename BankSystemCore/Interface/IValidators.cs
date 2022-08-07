namespace BankSystemCore.Interface
{
    public interface IValidators
    {
        bool CheckAccountNumber(string accountNumber);
        bool CheckEmail(string email);
        bool CheckName(string name);
        bool CheckNumber(string Number);
        bool CheckPassword(string password);
        bool CheckPhoneNumber(string phoneNumber);
    }
}