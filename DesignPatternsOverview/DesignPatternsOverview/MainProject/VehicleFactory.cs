using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsOverview.MainProject {
    class VehicleFactory : Vehicle, IVehicleAssembler, IVehicleCustomFrame {

        public VehicleFactory() { }

        static int vehiclesCreated = 0;

        public static void CountVehicles() { 
            //Console.WriteLine("Number of vehicles created: " + vehiclesCreated);
            Console.WriteLine($"Number of vehicles created: {vehiclesCreated}");
        }

        public void CreateCar() {
            Car c = new Car();
            //c.frame = "Car frame";

            c.wheels = 4;
            c.gas = 0.0f;
            c.battery = 0.0f;

            vehiclesCreated++;
        }
        
        public void CreatePlane() {
            Plane p = new Plane();

            p.frame = "Car frame";
            p.wheels = 4;
            p.gas = 0.0f;
            p.battery = 0.0f;

            vehiclesCreated++;
        }
        
        public void CreateRocket() {
            Rocket r = new Rocket();

            r.frame = "Car frame";
            r.wheels = 4;
            r.gas = 0.0f;
            r.battery = 0.0f;

            vehiclesCreated++;
        }

        public void SetFrame(Vehicle veh) {
            Console.WriteLine("Which frame?");
            string vehframe = Console.ReadLine();
            veh.frame = vehframe;
        }

        public void SetPaint(Vehicle veh) {
            Console.WriteLine("Which paint?");
            string vehpaint = Console.ReadLine();
            veh.paint = vehpaint;
        }
    }
}
