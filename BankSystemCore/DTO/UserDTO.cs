using BankSystemCore.Interface;
using BankSystemCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemCore.DTO
{
    public class UserDTO : IUserDTO
    {
        public User LoggedUser { get; set; } = null!;
        public List<User> listOfUsers { get; set; } = new List<User>();
    }
}
