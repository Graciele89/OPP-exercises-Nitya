using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingString
{
    class Program
    {
        //Lecture 7: Using the String Data Type
        static void Main(string[] args)
        {
            string myString = "Hello World";

            string name1 = "Jesse";
            string name2 = "Bob";

            int namesEqual = name1.CompareTo(name2);
            Console.WriteLine("Names equal {0}", namesEqual);

            Console.WriteLine("{0} has {1} characters", name1, name1.Length);

            string firstCharacterOfName = name1.Substring(0, 1);
            Console.WriteLine(firstCharacterOfName);

            string middleSectionOfName = name1.Substring(1, 3);
            Console.WriteLine(middleSectionOfName);

            bool startsWith = name1.StartsWith("Jess");
            Console.WriteLine(startsWith);

            Console.ReadLine();



        }
    }
}

