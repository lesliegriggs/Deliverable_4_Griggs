// Author: Leslie Griggs
// ISM 4300
// 20 September 2022
// Deliverable 4

using System;

namespace Deliverable_4_Griggs
{
    class Program
    {
        static void Main(string[] args)
        {

                int input = 25;
        
                if (input == 25) 
                {
                    int[] fibonacci = new int[input];
                    fibonacci[0] = 0;
                    fibonacci[1] = 1;
                    for (int i = 0; i < input; i++)

                        if (i >= 2)
                        {
                            fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
                        }

                    Console.WriteLine("");
                    Console.WriteLine("The first " + input.ToString() + " fibonacci numbers are: ");
                    Console.WriteLine("");
                int count = 0;
                    foreach (int number in fibonacci)
                    {
                    count++;
                    Console.WriteLine("Fibonacci number (" + count + ") = " + number.ToString());
                    }
                    Console.WriteLine("");

                    Console.WriteLine("");

                }
             
           
        }
    }
}

