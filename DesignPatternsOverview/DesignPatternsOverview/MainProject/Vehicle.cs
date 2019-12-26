using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsOverview.MainProject {
    abstract class Vehicle {
        internal string frame;
        internal int wheels;
        internal float gas;
        internal float battery;
        internal string paint;
    }

    class Car : Vehicle { 
        internal Car() { }
    }

    class Plane : Vehicle { 
        internal Plane() { }
    }

    class Rocket : Vehicle { 
        internal Rocket() { }
    }
}
