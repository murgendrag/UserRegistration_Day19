using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class UserFirstName
    {

            public static string FirstName ="^[A-Z]{1}[A-Za-z]{2,}$";
            public static string LastName = "^[A-Z]{1}[A-Za-z]{2,}$";

        public bool Validate_First_Name(string First_Name)
            {
                return Regex.IsMatch(First_Name,FirstName);

            }
        public bool Validate_Last_Name(string Last_Name)
        {
            return Regex.IsMatch(Last_Name, LastName);

        }
    }
    }
