using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreConstructs
{
    class Garage:IEnumerable
    {
        public Car[] Cars { get; set; }
        public Garage()
        {
            Cars = new Car[3];
            Cars[0] = new Car("Honda",2);
            Cars[1] = new Car("Toyota",5);
            Cars[2] = new Car("Suzuki", 1);
        }

        public IEnumerator GetEnumerator()
        {
            return Cars.GetEnumerator();
        }
        public IEnumerable CustomEnumerator()
        {
            return Enumerable();
            IEnumerable Enumerable()
            {
                foreach (Car _car in Cars)
                {
                    yield return _car;
                }
            }
        }
    }
}
