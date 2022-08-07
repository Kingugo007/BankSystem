using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemCore.Models
{
    [Serializable]
    public class Account
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string AccountNumber { get; set; } = string.Empty;
        public decimal Balance { get; set; }
        public Guid UserId { get; set; }
        public string AccountType { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
