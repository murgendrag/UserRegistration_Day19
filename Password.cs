using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class Password
    {
        public static string Pass_Word = "^(?=.*[A-Za-z])(?=.*/d)[A-Za-z/d]{8,}$";
        public static string Pass_Word2 = "^(?=.*[a-z])(?=.*[A-Z])(?=.*/d)[a-zA-Z/d]{8,}$";
        public bool Validate_Rule1(string passWord)
        {
            return Regex.IsMatch(Pass_Word, passWord);

        }
        public bool Validate_Rule2(string passWord2)
        {
            return Regex.IsMatch(Pass_Word2, passWord2);

        }
    }
}
