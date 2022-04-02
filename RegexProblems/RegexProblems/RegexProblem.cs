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
        public static void PasswordWithSpecialChar()
        {
            Console.WriteLine("Enter your password with one Upper,one numberic,one special char");

            while (true)
            {
                string input = Console.ReadLine();
                Regex r = new Regex(@"^[A-Z][0-9](|_|.|-|~)[a-z]{5}$");
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
