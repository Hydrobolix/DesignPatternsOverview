using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsOverview.MainProject {
    class Program {
        static void Main(String[] args) {
            VehicleFactory VF = new VehicleFactory();

            VF.CreateCar();
            VF.CreatePlane();
            VF.CreateRocket();

            VehicleFactory.CountVehicles();
        }
    }
}
