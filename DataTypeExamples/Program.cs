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
            #region 2) Data Types
            //Two Basic Data Types: Value types (bool & char(single character = single quotes) & Reference types (string = dbl quotes)
            Console.WriteLine("------------------");
            Console.WriteLine("Initializing ints:");
            Console.WriteLine("------------------");
            int number1;
            number1 = 10;
            int number2 = 20;
            Console.WriteLine("number1 is " + number1);
            Console.WriteLine($"number2 is {number2}");

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Whole Numbers & Fractions: using 5 / 9 = 0.55555555555555555....");
            Console.WriteLine("----------------------------------------------------------------");
            //int only holds whole numbers
            //int (4 bytes), short (2 bytes), long (8 bytes)
            Console.WriteLine("Whole Numbers:");
            Console.WriteLine("--------------");
            int intMax = int.MaxValue;
            Console.WriteLine($"int.MaxValue is: {intMax}");
            uint uintMax = uint.MaxValue;
            Console.WriteLine($"uint,MaxValue is: {uintMax} - can cast with U on end ex: 12345U");
            short shortMax = short.MaxValue;
            Console.WriteLine($"short.MaxValue is: {shortMax}");
            long longMax = long.MaxValue;
            Console.WriteLine($"long.MaxValue is: {longMax} - can cast with L on end ex: 12345L");
            Console.WriteLine("");

            number1 = 5 / 9;
            Console.WriteLine("int 5 / 9 is " + number1);
            int i = 12345;
            long l = i;
            //short s = i; = build error
            short s1 = (short)i;
            short s2 = Convert.ToInt16(i);
            Console.WriteLine($"values of int(12345), long(= int) & short1(cast from int) & short2(Convert.ToInt16) are {i}, {l} & {s1} & {s2}");
            Console.WriteLine("");

            Console.WriteLine("Fractions:");
            Console.WriteLine("----------");
            double doubleMax = double.MaxValue;
            Console.WriteLine($"double.MaxValue is: {doubleMax}   - can cast with D on end ex: 12345.23D");

            float floatMax = float.MaxValue;
            Console.WriteLine($"float.MaxValue is: {floatMax}     - can cast with F on end ex: 12345.23F");

            decimal decimalMax = decimal.MaxValue;
            Console.WriteLine($"decimal.MaxValue is: {decimalMax} - can cast with M on end ex: 12345.12M");
            Console.WriteLine("");


            double dbl1 = 5.0 / 9.0;
            float flt1 = 5.0F / 9.0F;
            Console.WriteLine($"values of double(5.0 / 9.0) & float(5.0F / 9.0F are: {dbl1} & {flt1}");
            double d = 5 / 9;
            Console.WriteLine($"values of double(5 / 9) is {d} (because there is no cast or conversion on 5 or 9(int))");
            double dd = Convert.ToDouble(5) / 9;
            Console.WriteLine($"values of double(Convert.ToDouble(5) / 9) is {dd}");
            double ddd = (double)5 / 9;
            Console.WriteLine($"values of double(Cast5 / 9) is {ddd}");
            Console.WriteLine("Casting of non literals is done by putting the type to cast to in front of name ex: (long)fromDblName");
            Console.WriteLine("");


            Console.Read();
            #endregion

            #region 1) String Formatting:
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Please enter your name...");
            //string name = Console.ReadLine();
            //Console.WriteLine("Yo " + name + "!");

            //Console.WriteLine(string.Format("Yo {0}", name + "!"));

            ////string interpollation:
            //Console.WriteLine($"Yo {name}!");

            //Console.WriteLine("Press enter to terminate...");
            //Console.Read();
            #endregion

        }
    }
}
