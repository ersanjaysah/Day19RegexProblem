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
        public static void EmailValidation()
        {
            Console.WriteLine("Enter your Email Address");

            while (true)
            {
                string input = Console.ReadLine();
                Regex r = new Regex("^[A-Za-z0-9.+-]{1,}[a-zA-Z0-9]@[a-z0-9]{1,}.(co|org|com|in|us|net|au|com.com|com.au)$");
                if (r.IsMatch(input))
                {
                    Console.WriteLine("your Email is " + true);
                }
                else
                {
                    Console.WriteLine("Your email is " + false);
                }
            }
        }
    }
}
