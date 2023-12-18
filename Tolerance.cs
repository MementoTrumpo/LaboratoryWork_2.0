using ConsoleProjectForNavigationSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork_2._0
{
    public class Tolerance : Aircraft
    {
        

        public Tolerance(double trueAirspeed, double angleCourse, double windSpeed, double windAngle, double mapAngle) 
            : base (trueAirspeed, angleCourse, windSpeed, windAngle, mapAngle)
        {

        }


    }
}
