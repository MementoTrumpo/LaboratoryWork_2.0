using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleProjectForNavigationSystem
{
    public class Aircraft
    {
        private double _trueAirspeed;

        /// <summary>
        /// Истинная скорость
        /// </summary>
        public virtual double TrueAirspeed
        {
            get { return _trueAirspeed; }
            set { _trueAirspeed = value; }
        }

        private double _angleCourse;
        /// <summary>
        /// Угол курса
        /// </summary>
        public virtual double AngleCourse
        {
            get { return _angleCourse; }
            set { _angleCourse = value; }
        }

        private double _windSpeed;
        /// <summary>
        /// Скорость ветра
        /// </summary>
        public virtual double WindSpeed
        {
            get { return _windSpeed; }
            set { _windSpeed = value; }
        }

        private double _windAngle;
        /// <summary>
        /// Угол ветра
        /// </summary>
        public virtual double WindAngle
        {
            get { return _windAngle; }
            set { _windAngle = value; }
        }

        private double _mapAngle;
        /// <summary>
        /// Угол карты
        /// </summary>
        public virtual double MapAngle
        {
            get { return _mapAngle; }
            set { _mapAngle = value; }
        }

        private double _x;
        /// <summary>
        /// Координата X летательного аппарата
        /// </summary>
        public double X
        {
            get { return _x; }
            set { _x = value; }
        }

        private double _y;
        /// <summary>
        /// Координата Y летательного аппарата
        /// </summary>
        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }
        /// <summary>
        /// Начальное значение X
        /// </summary>
        public double X_INITIAL_VALUE = 0;

        /// <summary>
        /// Начальноое значение Y
        /// </summary>
        public double Y_INITIAL_VALUE = 0;

        public Aircraft(double trueAirspeed, double angleCourse, double windSpeed, double windAngle, double mapAngle)
        {
            TrueAirspeed = trueAirspeed;
            AngleCourse = angleCourse;
            WindSpeed = windSpeed;
            WindAngle = windAngle;
            MapAngle = mapAngle;
        }

        /// <summary>
        /// Находит координату X летательного аппарата
        /// </summary>
        /// <returns>Координата X</returns>
        public virtual double ReturnCoordinateX()
        {
            return TrueAirspeed * Math.Sin(AngleCourse - MapAngle) + WindSpeed * Math.Sin(WindAngle - MapAngle);
        }
        
        /// <summary>
        /// Находит координату Y летательного аппарата
        /// </summary>
        /// <returns>Координата Y</returns>
        public virtual double ReturnCoordinateY()
        {
            return TrueAirspeed * Math.Cos(AngleCourse - MapAngle) + WindSpeed * Math.Cos(WindAngle - MapAngle);
        }
    }
}
