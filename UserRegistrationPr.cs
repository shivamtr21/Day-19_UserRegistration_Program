using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class UserRegistrationPr
    {
        public static string LastName = "^[A-Z]{1}[A-Za-z]{2,}$";

        public bool ValidateLName(string LName)
        {
            return Regex.IsMatch(LName, LastName);
        }
    }
}
