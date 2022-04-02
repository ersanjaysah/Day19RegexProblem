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
        public static void Lastname()
        {
            Console.WriteLine("Please Enter your Last name");

            while (true)
            {
                string input = Console.ReadLine();
                Regex r = new Regex("^[A-Z][a-z]{2,}$");
                if (r.IsMatch(input))
                {
                    Console.WriteLine("your last name is " + true);
                }
                else
                {
                    Console.WriteLine("Your Last name is " + false);
                    Console.WriteLine("last Name Should be Contain Only Three Character");
                }
            }
        }
    }
}
