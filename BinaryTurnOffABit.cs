using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTurnOffABit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Turn off the kth element in a number n

            //Convert the decimal value of n to binary
            //Looking at kth element from the right
            //Create another variable equal to 1 + (k-1) zeros
            //Subtract the two values

            int number = 15;
            int k = 4;

            TurnOffBit(number, k);

        }

        private static void TurnOffBit(int number, int k)
        {            
            //int binary = Convert.ToInt32((Convert.ToString(number, 2)));
            //Shift 0001 by k-1 spaces
            //result == 1000
            int x = 1 << (k - 1);
            //1111
            //1000
            //In order to get the result of 0111, use XOR because it only flips a bit if both are on
            //result == 0111
            int result = number ^ x;
            Console.WriteLine("Using bit operations, {0} with the {1} bit flipped results in: {2}", number, x, result);
            Console.WriteLine("The binary equivalent is {0} with the {1} = {2}", Convert.ToString(number, 2), Convert.ToString(x,2), Convert.ToString(result, 2));
            Console.Read();
        }
    }
}
