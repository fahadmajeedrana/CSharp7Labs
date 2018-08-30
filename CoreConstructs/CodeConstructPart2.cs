using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CoreConstructs
{
    class CodeConstructPart2
    {
        public static void Execute()
        {
            //Expression Bodied Members
            Console.WriteLine(Add(5, 4));

            //Discarded parameters
            string numberOne = "1";
            if (int.TryParse(numberOne, out _))
            {
                Console.WriteLine("Valid Int");
            }

            //ref locals and returns
            string[] stringArray = { "One","Two","Three" };
            stringArray.ToList().ForEach(x => Console.WriteLine(x));
            ref string _testString = ref StringPosition(stringArray,0);
            _testString = "Changed";
            stringArray.ToList().ForEach(x => Console.WriteLine(x));
            Wrapper();

            (int, int) tuppleInt = (1,2);
            Console.WriteLine($"Value contained by tuppleInt is {tuppleInt.Item1} and {tuppleInt.Item2}");
            (int _int1, int _int2) namedTuppleInt = (2,3);
            Console.WriteLine($"Value contained by namedTuppleInt is {namedTuppleInt._int1} and {namedTuppleInt._int2}");
            var _inferredValueTuppleInt = (x: 2, y: 3);
            Console.WriteLine($"Value contained by _inferredValueTuppleInt is {_inferredValueTuppleInt.x} and {_inferredValueTuppleInt.y}");
            
        }
        //Expression Bodied Members
        static int Add(int x, int y) => x + y;
        static ref string StringPosition(string[] StringArray,int position)
        {
            return ref StringArray[position];
        }
        //Local Functions
        static void Wrapper()
        {
            Console.WriteLine("Inside Wrapper");
            LocalFunction();
            void LocalFunction() => Console.WriteLine("Inside Local Function");
        }
    }
}
