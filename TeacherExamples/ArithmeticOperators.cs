using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingArithmeticOperators
{
    class Program
    {
        //Lecture 4: Using Arithmetic Operators
        static void Main(string[] args)
        {
            // + - * / %

            int myInt = 5 + 5;
            Console.WriteLine(myInt);
            int myInt2 = 5 - 5;
            Console.WriteLine(myInt2);
            int myInt3 = 5 * 5;
            Console.WriteLine(myInt3);


            double myDouble = 45.0 / 2;
            Console.WriteLine(myDouble);

            double remain = 5 % 4;
            Console.WriteLine(remain);



            int result = (2 + 3) * 4;
            Console.WriteLine("The result is {0}", result);


            int myInt4 = myInt + myInt2 + myInt3;
            Console.WriteLine(myInt4);



            int x = 15;
            x = x + 1;
            x += 1;

            Console.WriteLine("The value of x is {0}", x);

            int y = 5;
            ++y;
            Console.WriteLine("The value of y is {0}", y);

            int b = 4;
            int c = ++b;
            Console.WriteLine("The value of b is {0} and the value of c is {1}", b, c);

            Console.ReadLine();


        }
    }
}
