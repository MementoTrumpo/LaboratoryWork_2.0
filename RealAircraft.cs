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

        private double _trueAirspeedRandomComponent;
        /// <summary>
        /// Случайная компонента истинной скорости
        /// </summary>
        public double TRUE_AIRSPEED_RANDOM_COMPONENT
        {
            get { return TrueAirspeed * 0.01 * (rand.NextDouble() * 2 - 1); }
            set { _trueAirspeedRandomComponent = value; }
        }

        private double _trueAirspeedConstantComponent;
        /// <summary>
        /// Постоянная компонента истинной скорости
        /// </summary>
        public double TRUE_AIRSPEED_CONSTANT_COMPONENT
        {
            get { return 0.01 * TrueAirspeed; }
            set { _trueAirspeedConstantComponent = value; }
        }
        //---------------------------------------------------------------------------------

        /// <summary>
        /// Погрешность измерения датчиками угла курса
        /// </summary>
        public double ErrorAngleCourse
        {
            get { return ANGLE_COURSE_RANDOM_COMPONENT + ANGLE_COURSE_CONSTANT_COMPONENT; }
        }
        
        private double _angleCourseRandomComponent;

        /// <summary>
        /// Случайная компонента угла курса
        /// </summary>
        public double ANGLE_COURSE_RANDOM_COMPONENT 
        {
            get { return Math.PI / 180 * ((rand.NextDouble() * 2) - 1); }
            set { _angleCourseRandomComponent = value; }
        }
        
        private double _angleCourseConstantComponent;

        /// <summary>
        /// Постоянная компонента угла курса
        /// </summary>
        public double ANGLE_COURSE_CONSTANT_COMPONENT
        {
            get { return Math.PI / 180; }
            set { _angleCourseConstantComponent = value; }
        }
        //----------------------------------------------------------------------------------

        /// <summary>
        /// Погрешность измерения датчиками скорости ветра
        /// </summary>
        public double ErrorWindSpeed
        {
            get { return WIND_SPEED_RANDOM_COMPONENT + WIND_SPEED_CONSTANT_COMPONENT; }
        }

        private double _windSpeedRandomComponent;

        /// <summary>
        /// Случайная компонента скорости ветра
        /// </summary>
        /// 
        public double WIND_SPEED_RANDOM_COMPONENT
        {
            get { return  0.01 * WindSpeed * (rand.NextDouble() * 2 - 1); }
            set { _windSpeedRandomComponent = value; }
        }

        private double _windSpeedConstantComponent;

        /// <summary>
        /// Постоянная компонента скорости ветра
        /// </summary>
        public double WIND_SPEED_CONSTANT_COMPONENT
        {
            get { return 0.01 * WindSpeed; }
            set {  _windSpeedConstantComponent = value;}
        }
        //--------------------------------------------------------------------------

        /// <summary>
        /// Погрешность измерения угла ветра
        /// </summary>
        public double ErrorWindAngle
        {
            get { return WIND_ANGLE_RANDOM_COMPONENT + WIND_ANGLE_CONSTANT_COMPONENT; }
        }

        private double _windAngleRandomComponent;

        /// <summary>
        /// Случайная компонента угла ветра
        /// </summary>
        public double WIND_ANGLE_RANDOM_COMPONENT
        {
            get { return Math.PI / 180 * (rand.NextDouble() * 2 - 1); }
            set { _windAngleRandomComponent = value; }
        }
        
        private double _windAngleConstantComponent;

        /// <summary>
        /// Постоянная компонента угла скорости
        /// </summary>
        public double WIND_ANGLE_CONSTANT_COMPONENT
        {
            get { return 1 * -Math.PI / 180; }
            set { _windAngleConstantComponent = value; }
        }


        //public override double TrueAirspeed
        //{
        //    get => base.TrueAirspeed + TRUE_AIRSPEED_CONSTANT_COMPONENT + TRUE_AIRSPEED_RANDOM_COMPONENT;
        //    set { base.TrueAirspeed = value;}
        //}

        //public override double AngleCourse
        //{
        //    get => base.AngleCourse + ANGLE_COURSE_CONSTANT_COMPONENT + ANGLE_COURSE_RANDOM_COMPONENT;
        //    set => base.AngleCourse = value;
        //}

        //public override double WindSpeed
        //{
        //    get => base.WindSpeed + WIND_SPEED_CONSTANT_COMPONENT + WIND_SPEED_RANDOM_COMPONENT;
        //    set => base.WindSpeed = value;
        //}

        //public override double WindAngle 
        //{ 
        //    get => base.WindAngle + WIND_ANGLE_CONSTANT_COMPONENT + WIND_ANGLE_RANDOM_COMPONENT; 
        //    set => base.WindAngle = value;
        //}

        public RealAircraft(double trueAirspeed, double angleCourse, double windSpeed, double windAngle, double mapAngle) 
            : base(trueAirspeed, angleCourse, windSpeed, windAngle, mapAngle)
        {
            TrueAirspeed = trueAirspeed;
            AngleCourse = angleCourse;
            WindSpeed = windSpeed;
            WindAngle = windAngle;
            MapAngle = mapAngle;

        }

        public override double ReturnCoordinateX()
        {
            return (TrueAirspeed + ErrorTrueAirspeed) * Math.Sin((AngleCourse + ErrorAngleCourse) - MapAngle) +
                (WindSpeed + ErrorWindSpeed) * Math.Sin((WindAngle + ErrorWindAngle) - MapAngle);
        }

        public override double ReturnCoordinateY()
        {
            return (TrueAirspeed + ErrorTrueAirspeed) * Math.Cos((AngleCourse + ErrorAngleCourse) - MapAngle) +
               (WindSpeed + ErrorWindSpeed) * Math.Cos((WindAngle + ErrorWindAngle) - MapAngle);
        }


        /// <summary>
        /// Обнуление случайной составляющей всех измерений
        /// </summary>
        public void FirstTask()
        {
            TRUE_AIRSPEED_RANDOM_COMPONENT = 0d;
            ANGLE_COURSE_RANDOM_COMPONENT = 0d;
            WIND_ANGLE_RANDOM_COMPONENT = 0d;
            WIND_SPEED_RANDOM_COMPONENT = 0d;
        }

        /// <summary>
        /// Увеличение постоянной составляющей погрешности измерителя на порядок (ПО ВАРИАНТУ) - Курсовая система
        /// </summary>
        public void SecondTask()
        {
            ANGLE_COURSE_CONSTANT_COMPONENT = Math.PI / 180 * 10;
        }

        /// <summary>
        /// Обнуление постоянной составляющей погрешности измерителя
        /// </summary>
        public void ThirdTask()
        {
            TRUE_AIRSPEED_CONSTANT_COMPONENT = 0;
            ANGLE_COURSE_CONSTANT_COMPONENT = 0;
            WIND_ANGLE_CONSTANT_COMPONENT = 0;
            WIND_SPEED_CONSTANT_COMPONENT = 0;
        }


    }
}
