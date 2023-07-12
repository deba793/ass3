using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mystring;
            int result;
            Console.WriteLine("Enter the string :");
            mystring = Console.ReadLine();
            if (int.TryParse(mystring, out result))
            {
                Console.WriteLine("converted integer is \t" + result);
            }
            else
            {
                Console.WriteLine("invalid converstion");
            }
        
    }
    }
}
