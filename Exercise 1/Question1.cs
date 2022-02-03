using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1Nitya.Exercise_1
{
    //create a simple calculator:
    public class Question1
    {
          Console.WriteLine("********** BASIC CALCULATOR **********");

            Console.WriteLine("Hey dear!");
            Console.WriteLine("Chose an operator: ( + ), ( - ), ( / ), ( * ) ? ");
            string choice = (Console.ReadLine());

        Console.Write("Enter your first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (choice == "+")
            {
                Double result = num1 + num2;
        Console.WriteLine("Result =  " + result);
            }
            else if (choice == "-")
            {
                Double result = num1 - num2;
    Console.Write("Result = " + result);
            }
            else if (choice == "/")
{
    Double result = num1 / num2;
    Console.Write("Result =  " + result);
}
else if (choice == "*")
{
    Double result = num1 * num2;
    Console.Write("Result =  " + result);
}
else
{
    Console.Write("Invalid Operator");
}


Console.ReadLine();

  }
 }
}