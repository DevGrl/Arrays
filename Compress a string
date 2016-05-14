using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Modify a string to replace duplicates with the count unless the compressed string is larger
//Example:
//Input: aabbbc
//Ouput: a2b3c1

//Input: abc
//Output: a1b1c1
//This would be rejected as soon as a1 is calculated


namespace CompressString
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abc";
            string newString = "";
            int count = 0;
            char temp = original[0];
            bool flag = true;

            for (int i = 0; i <= original.Length - 1; i++)
            {
                if (flag != false)
                {

                    if (original[i] == temp)
                    {
                        count++;
                    }
                    else if (original[i] != temp)
                    {
                        
                        if (newString.Length + 2 >= original.Length)
                        {
                            Console.WriteLine("Compressed string is longer than the original string. Exiting.");
                            Console.ReadLine();
                            flag = false;
                            break;
                        }
                        newString = newString + temp + Convert.ToString(count);
                        count = 1;
                        temp = original[i];
                    }
                    
                    if (i == original.Length - 1)
                    {
                        newString = newString + temp + Convert.ToString(count);
                    }
                }
            }//end for (int i = 0; i <= original.Length - 1; i++)

                if (flag)
                {
                    Console.WriteLine("New String = {0}", newString);
                    Console.ReadLine();
                }
            }
        }
    }
