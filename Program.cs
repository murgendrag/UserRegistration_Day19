using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            string FirstName, LastName, Emailid,Mobile_Number,passWord,passWord2;
            bool result, result1, result2,result3,result4,result5;

            UserFirstName Check = new UserFirstName();
            LastName Check1 = new LastName();
            EmailId Check2 = new EmailId();
            MobileFormat Check3 = new MobileFormat();
            Password Check4 = new Password();

            Console.WriteLine(" Enter FirstName");
            FirstName = Console.ReadLine();

            Console.WriteLine(" Enter LastName");
            LastName = Console.ReadLine();

            Console.WriteLine(" Enter Emailid");
            Emailid = Console.ReadLine();

            Console.WriteLine(" Enter MobileNumber");
            Mobile_Number= Console.ReadLine();

            Console.WriteLine(" Enter Password with min 8 characters");
            passWord = Console.ReadLine();

            Console.WriteLine(" Enter Password with atleast 1 upper case");
            passWord2 = Console.ReadLine();

            result = Check.Validate_First_Name(FirstName);
            Console.WriteLine(result);

            result1 = Check1.Validate_Last_Name(LastName);
            Console.WriteLine(result1);

            result2 = Check2.Validate_Last_Name(Emailid);
            Console.WriteLine(result2);

            result3 = Check3.Validate_MobileNumber(Mobile_Number);
            Console.WriteLine(result3);

            result4 = Check4.Validate_Rule1(passWord);
            Console.WriteLine(result4);

            result5 = Check4.Validate_Rule2(passWord2);

            if (FirstName.Length < 3 || LastName.Length < 3)
            {
                Console.WriteLine("Enter minimum of 3 characters");
            }
        }
    }
}
