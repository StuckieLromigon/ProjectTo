using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Car : Vehicle, iLightVehicle
    {
        public int PassangersNumber { get; set; }
    }
}
