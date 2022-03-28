using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class MobileFormat
    {

        public static string MobileNumber = "^(91)[6-9]{1}[0-9]{9}$";
        
        public bool Validate_MobileNumber(string Mobile_Number)
        {
            return Regex.IsMatch(MobileNumber, Mobile_Number);

        }

    }
    
}
