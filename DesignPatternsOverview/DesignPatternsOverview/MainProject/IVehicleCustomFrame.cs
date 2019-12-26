using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsOverview.MainProject {
    interface IVehicleCustomFrame : IVehicleFrame {
        void SetPaint(Vehicle v);
    }
}
