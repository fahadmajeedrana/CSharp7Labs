using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CoreConstructs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Formatting Numerical Data
            Console.WriteLine("C2 format {0:c2}", 122.2345);
            Console.WriteLine("d2 format {0:d6}", 122);
            Console.WriteLine("f1 format {0:f1}", 122.45);
            Console.WriteLine("n1 format {0:n1}", 122.45);
            Console.WriteLine("X format {0:X}", 122345);
            Console.WriteLine("x format {0:x}", 122345);
            Console.WriteLine("E format {0:E}", 122345);
            Console.WriteLine("e format {0:e}", 122345);

            //Try Parse
            string intString = "10";
            if (int.TryParse(intString, out int convertedInt))
            {
                Console.WriteLine(convertedInt);
            }

            //Time Span
            TimeSpan ts = new TimeSpan(15, 10, 10, 10);
            Console.WriteLine(ts);

            //Big Integer
            BigInteger biggy = BigInteger.Parse("99999999999999999999999999999999999999999999999999");
            BigInteger Add = biggy + BigInteger.Parse("9999999999944444444444444444444444");
            Console.WriteLine(Add);

            //Digit Seperator
            int digitSeperator = 123_456_7;
            Console.WriteLine(digitSeperator);

            //Binary Literal
            int binaryLiteral = 0b0001_0100;
            Console.WriteLine(binaryLiteral);

            //Verbatim String
            string verbatimString = @"This is
                                        a Verbatim String
                                                 with white spaces";
            Console.WriteLine(verbatimString);

            //Switch Statement Pattern Matching
            Console.WriteLine("Please select a language of your choice:");
            Console.WriteLine("[1] VB,2 C#");
            object langChoice = Console.ReadLine();
            var choice = int.TryParse(langChoice.ToString(), out int i) ? i : langChoice;
            switch (choice)
            {
                case int j when j == 1:
                case string s when s.Equals("vb", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("You Selected VB");
                    break;
                case int j when j == 2:
                case string s when s.Equals("c#", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("You Selected C#");
                    break;
            }


            Console.ReadLine();

        }
    }
}
