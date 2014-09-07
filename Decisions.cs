using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please type somthing and press \"ENTER\" key: ");
            //string userValue = Console.ReadLine();
            //Console.WriteLine("You typed: " + userValue);

            Console.WriteLine("Would You prefer what is behind door number 1, 2, or 3?");
            string userValue = Console.ReadLine();

            //string response="";
            //if (userValue == "1")
            //    response = "Cogratz U just won brand new car";
            //else if (userValue == "2")
            //    response="You won a new boat!";
            //else if (userValue == "3")
            //    response="You won a new bike!";
            //else
            //    response="Sorry, we didn't understand. You lose!";
            //Console.WriteLine(response);

            string response = (userValue == "1") ? "boat" : "strand of lint";
            Console.WriteLine("You won a {0}!", response);

            Console.ReadLine();
        }
    }
}
