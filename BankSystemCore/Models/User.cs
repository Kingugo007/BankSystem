using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemCore.Models
{   
        [Serializable]
        public class User
        {
            public Guid Id { get; set; } = Guid.NewGuid();
            public string FirstName { get; set; } = string.Empty;
            public string LastName { get; set; } = string.Empty;
            public string Password { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public string Phone { get; set; } = string.Empty;
            public DateTime CreatedAt { get; set; }
            public string FullName { get { return $"{FirstName} {LastName}"; } }
        }    
}
