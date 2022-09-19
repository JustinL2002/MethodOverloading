using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class methods
    {
        public static int Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
            return num1 + num2;           
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            Console.WriteLine(num1 + num2);
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool withDollars)
        {
            var sum = num1 + num2;

            if (withDollars == true)
            {
                return $"{num1 + num2} dollars";
            }
            else if (withDollars && (num1 + num2 == 1)
            {
                return $"{num1 + num2} dollar";
            }
            else
            {
                return $"{num1 + num2}";
            }
        }
    }
}
