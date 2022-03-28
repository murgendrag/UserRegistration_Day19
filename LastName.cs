using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class LastName
    {
        public static string lastName = "^[A-Z]{1}[A-Za-z]{2,}$";

        public bool Validate_Last_Name(string Last_Name)
        {
            return Regex.IsMatch(Last_Name, lastName);

        }
    }
}
