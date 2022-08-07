using BankSystemCore.Interface;
using System.Text.RegularExpressions;

namespace BankSystemCore.Helpers
{
    public class Validators : IValidators
    {
        public bool CheckEmail(string email)
        {
            string strRegex = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return PerformRegEx(strRegex, email);
        }
        public bool CheckName(string name)
        {
            string strRegex = @"^[A-Z]";

            return PerformRegEx(strRegex, name);
        }
        public bool CheckPassword(string password)
        {
            string strRegex = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{6,}$";
            return PerformRegEx(strRegex, password);
        }
        public bool CheckPhoneNumber(string phoneNumber)
        {
            string strRegex = @"^\d{11}$";
            return PerformRegEx(strRegex, phoneNumber);
        }
        public bool CheckAccountNumber(string accountNumber)
        {
            string strRegex = @"^\d{10}$";
            return PerformRegEx(strRegex, accountNumber);
        }
        public bool CheckNumber(string Number)
        {
            string strRegex = @"^[0-9]+$";
            return PerformRegEx(strRegex, Number);
        }
        private static bool PerformRegEx(string pattern, string value)
        {
            Regex re = new Regex(pattern);
            if (re.IsMatch(value))
                return (true);
            else
                return (false);
        }
    }
}
