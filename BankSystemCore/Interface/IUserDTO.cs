using BankSystemCore.Models;

namespace BankSystemCore.Interface
{
    public interface IUserDTO
    {
        List<User> listOfUsers { get; set; }
        User LoggedUser { get; set; }
    }
}