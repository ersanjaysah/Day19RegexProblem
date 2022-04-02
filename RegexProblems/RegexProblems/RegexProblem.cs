using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblems
{
    public class RegexProblem
    {
        public static void MobileNumber()
        {
            Console.WriteLine("Please Enter your Mobile Number");

            while (true)
            {
                string input = Console.ReadLine();
                Regex r = new Regex("^91 [9876][0-9]{9}$");
                if (r.IsMatch(input))
                {
                    Console.WriteLine("your mobile number is " + true);
                }
                else
                {
                    Console.WriteLine("Your Mobile number is " + false);
                }
            }
        }
    }
}
