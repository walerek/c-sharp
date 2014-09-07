using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForIterations
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                //Console.Write(i.ToString() + " ");

                if (i == 7)
                {
                    Console.WriteLine("Found seven!");
                    break;
                }
            }

            for (int value = 0; value < 12; value++)
            {
                Console.Write(value + " ");
            }

            Console.ReadLine();
        }
    }
}
