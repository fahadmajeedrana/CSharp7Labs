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
            CodeConstructPart1.Execute();
            CodeConstructPart2.Execute();

            BaseClass dc = new DerivedClass();
            dc.BaseMethod();

            Person p = new Person() { FirstName="Fahad",LastName="Rana",MiddleName="Majeed"};
            Person p1 = new Person() { FirstName = "Fahad", LastName = "Rana", MiddleName = "Majeed" }; 
            Console.WriteLine(p.ToString());
            Console.WriteLine(p.Equals(p1));
            Console.WriteLine(object.Equals(p,p1));

            JustPerson jp=new JustPerson() { FirstName = "Fahad", LastName = "Rana", MiddleName = "Majeed" };
            JustPerson jp1 = new JustPerson() { FirstName = "Fahad", LastName = "Rana", MiddleName = "Majeed" };
            Console.WriteLine(object.Equals(jp,jp1));

            Console.ReadLine();
        }
    }
}
