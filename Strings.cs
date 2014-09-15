using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //working with string
            //string myString="Go to your C:\\ Drive";
            //string myString = "My \"so called\" life";
            //string myString = "What if i need a \n new line?";
            
            //string myString = String.Format("{0}!", "Bonzai");
            //string myString = String.Format("Make: {0} (Model: {1})", "BMW", "760li");
            //string myString = String.Format("{0:C}", 123.45); // "x" zł
            //string myString = String.Format("{0:N}", 123456789); // 123 456...
            //string myString = String.Format("{0:P}", .123); //%
            //string myString = String.Format("Phone number: {0:(##) ##-###-###}", 1234567890);

            //string myString = "";

            //for (int i = 0; i < 100; i++)
            //{
            //    myString += "--" + i.ToString();
            //}

            //StringBuilder myString = new StringBuilder();

            //for (int i = 0; i < 100; i++)
            //{
            //    myString.Append("--");
            //    myString.Append(i);
            //}

            string myString = " Esselum verde primalas boćka ";
            //myString = myString.Substring(5, 5);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "-");
            myString = String.Format(
                "Length before: {0} -- After: {1}", 
                myString.Length, 
                myString.Trim().Length);

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
