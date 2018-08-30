using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConstructs
{
    class Car:IComparable
    {
        public static IComparer SortByPetName { get => new SortByPetName(); }
        public string PetName { get; set; }
        public int ID { get; set; }

        public Car(string PetName, int ID)
        {
            this.PetName = PetName;
            this.ID = ID;
        }

        public int CompareTo(object obj)
        {
            return this.ID.CompareTo(((Car)obj).ID);
        }
    }
    class SortByPetName : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((Car)x).PetName.CompareTo(((Car)y).PetName);
        }
    }
}
