using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleProjectForNavigationSystem
{
    public abstract class Aircraft
    {
        private double _trueAirspeed;

        /// <summary>
        /// Истинная скорость
        /// </summary>
        public double TrueAirspeed
        {
            get { return _trueAirspeed; }
            set { _trueAirspeed = value; }
        }

        private double _angleCourse;
        /// <summary>
        /// Угол курса
        /// </summary>
        public double AngleCourse
        {
            get { return _angleCourse; }
            set { _angleCourse = value; }
        }

        private double _windSpeed;
        /// <summary>
        /// Скорость ветра
        /// </summary>
        public double WindSpeed
        {
            get { return _windSpeed; }
            set { _windSpeed = value; }
        }

        private double _windAngle;
        /// <summary>
        /// Угол ветра
        /// </summary>
        public double WindAngle
        {
            get { return _windAngle; }
            set { _windAngle = value; }
        }

        public Aircraft(double trueAirspeed, double angleCourse, double windSpeed, double windAngle)
        {
            _trueAirspeed = trueAirspeed;
            _angleCourse = angleCourse;
            _windSpeed = windSpeed;
            _windAngle = windAngle;
        }
    }
}
