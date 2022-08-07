using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemCore.Helpers
{
    public class CreateAccNumber
    {
        public static string accNumber()
        {
            return DateTime.UtcNow.Ticks.ToString().Substring(8);
        }
    }
}
