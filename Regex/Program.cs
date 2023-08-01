using System;
using System.Diagnostics.SymbolStore;

namespace Regexs
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.pincode");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice) 
                {
                    case 1:
                        PinCode pinCode = new PinCode();
                        break;
                }

            }
        }
    }
}