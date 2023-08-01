using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexs
{
    internal class PinCode
    {
        public PinCode() 
        {
            string regex = "^[0-9]{6} || [0-9]{3}[ ][0-9]{3}$";
            Console.WriteLine("Enter the pin code");
            string input = Console.ReadLine();
            Regex re = new Regex(regex);
            if (re.IsMatch(input))
                Console.WriteLine("Valid pin code");
            else
                Console.WriteLine("Pin code not valid");
        }
    }
}
