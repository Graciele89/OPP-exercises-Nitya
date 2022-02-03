using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalNot
{
    class Program
    {
        //Lecture 19: Conditional and Not Operators
        static void Main(string[] args)
        {
            //(condition) ? true : false
            int x = 50;
            int y = 16;

            int biggestNumber = x > y ? x : y;
            Console.WriteLine(biggestNumber);

            double testScore = 95;
            Console.WriteLine((testScore >= 60) ? "Pass" : "Fail");

            int myInt = 5;
            if (!(myInt >= 6))
            {

            }
        }
    }
}
