using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem
            //Convert a binary n to its decimal value

            //Solution
            //Create an integer array to store each bit value (101110)
            //Loop through the array and if the bit == 1, then calculate 2 to the power of the location in the array

            int[] binary = {1,0,1,1};

            int result = ConvertToDecimal(binary);

            if(result==0)
            {
                Console.WriteLine("A valid binary number was not provided");
            }
            else
            {
                Console.WriteLine("The decimal equivalent is {0}", result); 
            }

            Console.Read();
        }

        private static int ConvertToDecimal(int[] binary)
        {
            int decValue = 0;

            if(binary.Length == 0)
            {
                return 0;
            }

            for (int i = 0; i <= binary.Length - 1; i++)
            {
                if (binary[i] == 1)
                {
                    decValue += Convert.ToInt16(Math.Pow(2, i));
                }
                else if(binary[i] > 1)
                {
                    return 0;
                }
            }
            return decValue;
        }
    }
}
