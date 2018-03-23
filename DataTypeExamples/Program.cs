using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //blah
            //Console.WriteLine("What's your name");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hello {name}");
            //Console.WriteLine("Enter to terminate...");
            //Console.Read();

            //int number1;
            //number1 = 1;
            double number1 = (double) 5 / 9;
            float number2 = 5f / 9f;
            Console.WriteLine(number1);
            Console.WriteLine(number2);

            int i = 12345;
            short s1 = Convert.ToInt16(i);
            short s2 = (short)i;
            Console.WriteLine($"{s1} {s2}");
            Console.ReadLine();

            //test
        }
    }
}
