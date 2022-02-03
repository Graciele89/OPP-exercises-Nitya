using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatements
{
    class Program
    {
        //Lecture 18: Switch Statements
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year");
            int year = int.Parse(Console.ReadLine());
            //if (year == 1)
            //{
            //    Console.WriteLine("Freshman");
            //}
            //else if (year == 2)
            //{
            //    Console.WriteLine("Sophomore");
            //}
            //else if (year == 3)
            //{
            //    Console.WriteLine("Junior");
            //}
            //else if (year == 4)
            //{
            //    Console.WriteLine("Senior");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid year");
            //}

            switch (year)
            {
                case 1:
                    {
                        Console.WriteLine("Freshman");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Sophomore");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Junior");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Senior");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid year");
                        break;
                    }
            }

        }
    }
}
