using System.Text.RegularExpressions;

namespace Regexs
{
    internal class Email
    {
        public void EmailUC1()
        {
            string UC1_regex = "^[a-z]{0,}$";
            Console.WriteLine("Enter the email");
            string input = Console.ReadLine();
            Regex re = new Regex(UC1_regex);
            if (re.IsMatch(input))
                Console.WriteLine("Valid email");
            else
                Console.WriteLine("not valid email");
        }
    }
}