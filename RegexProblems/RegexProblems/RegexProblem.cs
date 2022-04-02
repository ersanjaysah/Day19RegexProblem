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
        public static void PasswordNumeric()
        {
            Console.WriteLine("Please Enter your password with numeric");

            while (true)
            {
                string input = Console.ReadLine();
                Regex r = new Regex("^[A-Z][0-9][a-z]{6}$");
                if (r.IsMatch(input))
                {
                    Console.WriteLine("your password is " + true);
                }
                else
                {
                    Console.WriteLine("Your password is " + false);
                }
            }
        }
    }
}
