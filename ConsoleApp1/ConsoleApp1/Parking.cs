using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Parking
    {
        Car[] car;
        public Parking() {
            car = new Car[] { new Car("Toyota"), new Car("Chevrolet"), new Car("Lamborghini") };
        }

    }
}
