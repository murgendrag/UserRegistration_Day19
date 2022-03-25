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

            public static string FirstName = "^[A-Z]{1}[A-Z a-z]{15}$";
            public bool Validate_First_Name(string First_Name)
            {
                return Regex.IsMatch(First_Name,FirstName);

            }

        }
    }
