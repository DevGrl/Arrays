using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem
            //Calculate the binary value of a decimal number n
            //Without using the Convert.ToString(int, 2) which converts a number to base 2

            //Solution
            //Take mod of n as the first bit value
            //Divide n by 2 and use the result as the new number n
            //Continue until n is 0

            int n = 13;
            string binary = "";

            do
            {
                binary = (n % 2) + binary;   
                n = n / 2;
            } while (n != 0);

            Console.WriteLine(binary);

            Console.ReadLine();


        }
    }
}
