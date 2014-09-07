using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arraays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 32;

            Console.WriteLine(numbers.Length);

            //int[] numbers = new int[] { 4, 8, 15, 16, 32, 71 };

            //Console.WriteLine(numbers[1].ToString());
            //Console.ReadLine();

            //string[] names = new string[] { "Tommy", "Jake", "David", "Someone" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            string zig = "Really long string I have to write that in " +
                         "two or more lines :/";
            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char charElement in charArray)
            {
                Console.Write(charElement);
            }
            Console.ReadLine();
        }
    }
}
