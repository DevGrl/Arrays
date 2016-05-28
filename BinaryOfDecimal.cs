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

            //original value
            int n = 13;

            LinkedList<int> binary = new LinkedList<int>();

            do
            {
                binary.AddFirst( n % 2);
                n = n / 2;
            } while (n != 0);

            foreach (var item in binary)
            {
                Console.Write(item);
            }

            Console.ReadLine();


        }
    }
}
