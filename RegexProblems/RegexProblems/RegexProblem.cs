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
        public static void EmailValidate()
        {
            Console.WriteLine("Please Enter your Email");

            while (true)
            {
                string input = Console.ReadLine();
                Regex r = new Regex(@"^[a-z]{3}(\.[a-z]{3})[@]bl.(|co|in)$");
                if (r.IsMatch(input))
                {
                    Console.WriteLine("your Email is " + true);
                }
                else
                {
                    Console.WriteLine("Your Email is " + false);
                }
            }
        }
    }
}
