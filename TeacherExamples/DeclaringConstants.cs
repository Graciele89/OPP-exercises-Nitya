using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringConstants
{
    class Program
    {
        enum DayOfWeek
        {
            SUNDAY,
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY
        }

        //Lecture 9: Declaring Constants
        static void Main(string[] args)
        {
            const int myConstInt = 10;
            //myConstInt = 6;
            Console.WriteLine(myConstInt);

            Console.WriteLine(Math.Log10(16));

            Console.WriteLine(Math.PI);

            DayOfWeek today = DayOfWeek.FRIDAY;
            Console.WriteLine(today);

            int numberOfToday = (int)today;
            Console.WriteLine(numberOfToday);

            Console.ReadLine();
        }
    }
}

