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
        public void EmailUC2()
        {
            string UC2_regex = "^[@]{1}[a-z]{0,}$";
            Console.WriteLine("Enter the email");
            string input = Console.ReadLine();
            Regex re = new Regex(UC2_regex);
            if (re.IsMatch(input))
                Console.WriteLine("Valid email");
            else
                Console.WriteLine("not valid email");
        }
        public void EmailUC3()
        {
            string UC3_regex = "^[.]{1}[a-z]{2}$";
            Console.WriteLine("Enter the email");
            string input = Console.ReadLine();
            Regex re = new Regex(UC3_regex);
            if (re.IsMatch(input))
                Console.WriteLine("Valid email");
            else
                Console.WriteLine("not valid email");
        }
        public void EmailUC4()
        {
            string actualRegex = "^[a-z]+[._+-]{0,1}[a-z]+[@]{1}[a-z]+[.]{1}[a-z]{2,3}([.]{1}[a-z]{2}){0,1}$";
            Console.WriteLine("Enter the email");
            string input = Console.ReadLine();
            Regex re = new Regex(actualRegex);
            if (re.IsMatch(input))
                Console.WriteLine("Valid email");
            else
                Console.WriteLine("not valid email");
        }

        internal void Validate(string input)
        {
            string actualRegex = @"^[^.]([a-z0-9\-+]{0,})[\.]{0,1}([a-z0-9\-+]{1,})(@{1}[a-z0-9]{1,})(\.)([a-z]{0,}[\.]{0,1}[a-z]{2,})]{0,}$";
            Regex re = new Regex(actualRegex);
            if (re.IsMatch(input))
                Console.WriteLine(input + " is Valid email");
            else
                Console.WriteLine(input +" is not valid email");
        }
    }
}