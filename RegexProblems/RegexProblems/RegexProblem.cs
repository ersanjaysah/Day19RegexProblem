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
        public static void Firstname()
        {
            Console.WriteLine("Please Enter your First name");

            while (true)
            {
                string input = Console.ReadLine();
                Regex r = new Regex("^[A-Z][a-z]{2,}$");
                if (r.IsMatch(input))
                {
                    Console.WriteLine("your First name is " + true);
                }
                else
                {
                    Console.WriteLine("Your First name is " + false);
                    Console.WriteLine("First Name Should be Contain Only Four Character");
                }
            }
        }
    }
}
