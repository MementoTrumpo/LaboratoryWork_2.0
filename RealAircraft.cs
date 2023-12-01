using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectForNavigationSystem
{
    public class RealAircraft : Aircraft
    {
        Random rand = new Random();

        /// <summary>
        /// Измерение датчиками истинной скорости 
        /// </summary>
        public double ErrorTrueAirspeed
        {
            get { return TRUE_AIRSPEED_CONSTANT_COMPONENT + TRUE_AIRSPEED_RANDOM_COMPONENT; }
        }
        /// <summary>
        /// Случайная компонента истинной скорости
        /// </summary>
        public double TRUE_AIRSPEED_RANDOM_COMPONENT
        {
            get { return (rand.NextDouble() * 2 - 1) * rand.Next(-1, 2); }
            set { TRUE_AIRSPEED_RANDOM_COMPONENT = value; }
        }
        /// <summary>
        /// Постоянная компонента истинной скорости
        /// </summary>
        public double TRUE_AIRSPEED_CONSTANT_COMPONENT
        {
            get { return 0.01 * TrueAirspeed; }
            set { TRUE_AIRSPEED_CONSTANT_COMPONENT = value; }
        }
        //---------------------------------------------------------------------------------

        /// <summary>
        /// Погрешность измерения датчиками угла курса
        /// </summary>
        public double ErrorAngleCourse
        {
            get { return ANGLE_COURSE_RANDOM_COMPONENT + ANGLE_COURSE_CONSTANT_COMPONENT; }
        }
        /// <summary>
        /// Случайная компонента угла курса
        /// </summary>
        public double ANGLE_COURSE_RANDOM_COMPONENT 
        {
            get { return  Math.PI / 180 * rand.Next(-1, 2); }
            set { ANGLE_COURSE_RANDOM_COMPONENT = value; }
        }
        /// <summary>
        /// Постоянная компонента угла курса
        /// </summary>
        public double ANGLE_COURSE_CONSTANT_COMPONENT
        {
            get { return Math.PI / 180; }
            set { ANGLE_COURSE_CONSTANT_COMPONENT = value; }
        }
        //----------------------------------------------------------------------------------

        /// <summary>
        /// Погрешность измерения датчиками скорости ветра
        /// </summary>
        public double ErrorWindSpeed
        {
            get { return WIND_SPEED_RANDOM_COMPONENT + WIND_SPEED_CONSTANT_COMPONENT; }
        }
        /// <summary>
        /// Случайная компонента скорости ветра
        /// </summary>
        public double WIND_SPEED_RANDOM_COMPONENT
        {
            get { return (rand.NextDouble() * 2 - 1) * rand.Next(-1, 2); }
            set { WIND_SPEED_RANDOM_COMPONENT = value; }
        }
        /// <summary>
        /// Постоянная компонента скорости ветра
        /// </summary>
        public double WIND_SPEED_CONSTANT_COMPONENT
        {
            get { return 0.1 * WindSpeed; }
            set {  WIND_SPEED_CONSTANT_COMPONENT = value;}
        }
        //--------------------------------------------------------------------------

        /// <summary>
        /// Погрешность измерения угла ветра
        /// </summary>
        public double ErrorWindAngle
        {
            get { return WIND_ANGLE_RANDOM_COMPONENT + WIND_ANGLE_CONSTANT_COMPONENT; }
        }

        /// <summary>
        /// Случайная компонента угла ветра
        /// </summary>
        public double WIND_ANGLE_RANDOM_COMPONENT
        {
            get { return Math.PI / 180 * rand.Next(-1, 2); }
            set { WIND_ANGLE_RANDOM_COMPONENT = value; }
        }
        /// <summary>
        /// Постоянная компонента угла скорости
        /// </summary>
        public double WIND_ANGLE_CONSTANT_COMPONENT
        {
            get { return 1 * -Math.PI / 180; }
            set { WIND_ANGLE_CONSTANT_COMPONENT = value; }
        }


        public RealAircraft(double trueAirspeed, double angleCourse, double windSpeed, double windAngle) 
            : base(trueAirspeed, angleCourse, windSpeed, windAngle)
        {
            TrueAirspeed = trueAirspeed + ErrorTrueAirspeed;
            AngleCourse = angleCourse + ErrorAngleCourse;
            WindSpeed = windSpeed + ErrorWindSpeed;
            WindAngle = windAngle + ErrorWindAngle;

        }


        


    }
}
