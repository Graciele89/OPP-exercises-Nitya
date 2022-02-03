using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseStatements
{
    class Program
    {
        //Lecture 16: If-Else Statements
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            if (age == 1)
            {
                Console.WriteLine("You are 1");
            }
            else if (age == 2)
            {
                Console.WriteLine("You are 2");
            }
            else if (age == 3)
            {
                Console.WriteLine("You are 3");
            }
        }
    }
}

