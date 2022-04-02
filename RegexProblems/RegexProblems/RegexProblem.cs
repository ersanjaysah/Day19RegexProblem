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
        public static void PasswordWitUpperCase()
        {
            Console.WriteLine("Please Enter your password");

            while (true)
            {
                string input = Console.ReadLine();
                Regex r = new Regex("^[A-Z][a-z]{7}$");
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
