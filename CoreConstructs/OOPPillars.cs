using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConstructs
{
    class BaseClass
    {
        public virtual void BaseMethod()
        {
            Console.WriteLine("In Base Method");
        }
    }
    class DerivedClass:BaseClass
    {
        public override void BaseMethod()
        {
            Console.WriteLine("In Derived Method");
        }
    }
    class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public override string ToString() => $"[FirstName:{FirstName};MiddleName:{MiddleName};LastName:{LastName}]";
        public override bool Equals(object obj) => obj?.ToString() == this.ToString();

    }
    class JustPerson
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        

    }
}
