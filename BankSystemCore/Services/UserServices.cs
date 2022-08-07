using BankSystemCore.Helpers;
using BankSystemCore.Interface;
using BankSystemCore.Models;

namespace BankSystemCore.Services
{ 
    public class UserServices : IUserServices
    {
        private readonly string userFile = "Users.json";
        private readonly string dir = Path.Combine(Environment.CurrentDirectory, "db");
        private readonly IJsonOperation _dbContext;
        private readonly IUtilities _utilities;
        private readonly IAccountServices _accountServices;
        public UserServices(IJsonOperation dbContext, IUtilities utilities, IAccountServices accountServices)
        {
            _dbContext = dbContext;
            _utilities = utilities;
            _accountServices = accountServices;
        }
        public async Task<Response> Register(User user)
        {
            user.CreatedAt = DateTime.Now;
            var path = Path.Combine(dir, userFile);
            bool status = false;
            try
            {
                var users = await _dbContext.ReadJson<User>(userFile);
                if (users == null)
                {
                    status = await _dbContext.WriteJson<User>(user, userFile);
                    if (status)
                    {
                        return new Response
                        {
                            Message = "Successfully registerd",
                            Status = true
                        };
                    }
                    else 
                    {
                        return new Response
                        {
                            Message = "Unable to save user info",
                            Status = false
                        };
                    }
                }
                //check if the use exist
                var exist = users!.SingleOrDefault(x => x.Email == user.Email);
                if (exist != null)
                    return new Response
                    {
                        Message = "User already exist",
                        Status = false
                    };
                // Register user
                var isRegistered = await _dbContext.WriteJson<User>(user, userFile);
                if (isRegistered)
                    return new Response
                    {
                        Message = "Successfully registerd",
                        Status = true,
                        Data = user
                    };
                return new Response
                {
                    Message = "An error occured",
                    Status = false
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
        //User login
        public async Task<Response> Login(string email, string password)
        {
            string hashPassword = _utilities.ComputeSha256Hash(password);
            var users = await _dbContext.ReadJson<User>(userFile);
            var path = Path.Combine(dir, userFile);
            if (File.Exists(path) && users != null)
            {
                foreach (var item in users)
                   {
                    if (item.Email == email && item.Password == hashPassword)
                    {
                        var loggedUser = await _accountServices.getOneAccount(item.Id);
                        return new Response
                        {
                            Message = "Successfully login",
                            Status = true,
                            Data = loggedUser
                        };
                    }             
                }            
                return new Response
                 {
                   Message = "Invalid Credentials",
                   Status = false
                 };
        }
            else
            {
                return new Response
                {
                    Message = "Error connecting to database",
                    Status = false
                };
}
                return new Response
                { 
                     Message = "An error occured",
                     Status = false
                 };
        }
    }
}
