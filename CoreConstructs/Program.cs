using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Collections;

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

            Person p = new Person() { FirstName = "Fahad", LastName = "Rana", MiddleName = "Majeed" };
            Person p1 = new Person() { FirstName = "Fahad", LastName = "Rana", MiddleName = "Majeed" };
            Console.WriteLine(p.ToString());
            Console.WriteLine(p.Equals(p1));
            Console.WriteLine(object.Equals(p, p1));

            JustPerson jp = new JustPerson() { FirstName = "Fahad", LastName = "Rana", MiddleName = "Majeed" };
            JustPerson jp1 = new JustPerson() { FirstName = "Fahad", LastName = "Rana", MiddleName = "Majeed" };
            Console.WriteLine(object.Equals(jp, jp1));

            var g = new Garage();
            foreach (Car c in g)
            {
                Console.WriteLine(c.PetName);
            }           

            Array.Sort(g.Cars);
            foreach (Car c in g.CustomEnumerator())
            {
                Console.WriteLine(c.PetName);
            }
            
            Array.Sort(g.Cars,Car.SortByPetName);

            foreach (Car c in g.CustomEnumerator())
            {
                Console.WriteLine(c.PetName);
            }
            Console.ReadLine();
        }
    }
}
