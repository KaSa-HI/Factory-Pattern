using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal static class VehicleFactory
    {
        public static IVehicle GetVehicle(string amtTires)
        {
            if (amtTires == 2.ToString())
                return new Motorcycle();

            return new Car();
        }
    }
}
