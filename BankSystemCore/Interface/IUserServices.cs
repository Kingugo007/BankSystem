using BankSystemCore.Helpers;
using BankSystemCore.Models;

namespace BankSystemCore.Interface
{
    public interface IUserServices
    {
        Task<Response> Login(string email, string password);
        Task<Response> Register(User user);
    }
}