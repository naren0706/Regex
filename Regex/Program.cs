using System;
using System.Diagnostics.SymbolStore;

namespace Regexs
{
    class Program
    {
        const string FILEPATH = @"E:\BridgeGateProblems\Regex\Regex\email.txt";
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.pincode\n2.email");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice) 
                {
                    case 1:
                        PinCode pinCode = new PinCode();
                        break;
                    case 2:
                        Email email = new Email();
                        string[] emails = File.ReadAllText(FILEPATH).Split(",");
                        foreach (var item in emails)
                        {
                            email.Validate(item);
                        }
                        break;
                }
            }
        }
    }
}