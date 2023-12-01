using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork_2
{
    public class Aircraft1
    {
        /// <summary>
        /// Поле для генерации случайной величины
        /// </summary>
        Random rand = new Random();

        /// <summary>
        /// Текущая координата X летательного аппарата
        /// </summary>
        public double X { get; set; }
        
        /// <summary>
        /// Текущая координата Y летательного аппарата
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Истинная воздушная скорость
        /// </summary>
        public double TrueAirspeed { get; set; }

        /// <summary>
        /// Угол курса
        /// </summary>
        public double CourseAngle { get; set; }

        /// <summary>
        /// Скорость ветра
        /// </summary>
        public double WindSpeed { get; set; }

        /// <summary>
        /// Угол ветра
        /// </summary>
        public double WindAngle { get; set; }

        /// <summary>
        /// Начальная координата X
        /// </summary>
        public double XInitialCoordinate = 0;

        /// <summary>
        /// Начальная координата Y
        /// </summary>
        public double YInitialCoordinate = 0;
        
        /// <summary>
        /// Угол карты
        /// </summary>
        public double MapAngle { get; set; }

        /// <summary>
        /// Измерение истинной скорости
        /// </summary>
        public double ErrTrueAirspeed
        {
            get
            {
                return 0.1 * TrueAirspeed +
                TrueAirspeed * (rand.NextDouble() * 2 - 1) * rand.Next(-1, 2) + TrueAirspeed;
            }
            set { ErrTrueAirspeed = value; }
        }

        /// <summary>
        /// Измерение угла курса
        /// </summary>
        public double ErrCourseAngle
        {
            get
            {
                return Math.PI / 180 + (Math.PI / 180 * rand.Next(-1, 2)) + CourseAngle;
            }
            set { ErrCourseAngle = value; }
        }

        /// <summary>
        /// Измерение скорости ветра
        /// </summary>
        public double ErrWindSpeed
        {
            get
            {
                return 0.1 * WindSpeed +
                WindSpeed * (rand.NextDouble() * 2 - 1) * rand.Next(-1, 2) + WindSpeed;
            }
            set { ErrWindSpeed = value; }
        }

        /// <summary>
        /// Измерение угла ветра
        /// </summary>
        public double ErrWindAngle
        {
            get
            {
                return 1 * -Math.PI / 180 + (Math.PI / 180 * rand.Next(-1, 2)) + WindAngle;
            }
            set { ErrWindAngle = value; }
        }

        public Aircraft1(double trueAirspeed, double courseAngle, double windSpeed, double windAngle, double mapAngle)
        {
            TrueAirspeed = trueAirspeed;
            CourseAngle = courseAngle;
            WindSpeed = windSpeed;
            WindAngle = windAngle;
            MapAngle = mapAngle;
        }

        /// <summary>
        /// Получить погрешности измерений
        /// </summary>
        //public void GetMeasurementErrors()
        //{
        //    // Погрешность истинной воздушной скорости
        //    ErrTrueAirspeed = 0.01 * TrueAirspeed + 
        //        TrueAirspeed * (rand.NextDouble() * 2 - 1) * rand.Next(-1, 2) + TrueAirspeed;

        //    // Погрешность угла курса
        //    ErrCourseAngle = Math.PI / 180 + (Math.PI / 180 * rand.Next(-1, 2)) + CourseAngle;

        //    // Погрешность скорости ветра
        //    ErrWindSpeed = 0.01 * WindSpeed +
        //        WindSpeed * (rand.NextDouble() * 2 - 1) * rand.Next(-1, 2) + WindSpeed;

        //    // Погрешность угла ветра
        //    ErrWindAngle = -Math.PI / 180 + (Math.PI / 180 * rand.Next(-1, 2)) + WindAngle; 
        //}



        /// <summary>
        /// Получение истинного решения по координате X
        /// </summary>
        /// <returns></returns>
        public double GettingSolutionTrueX()
        {
            return TrueAirspeed * Math.Sin(CourseAngle - MapAngle) +
               WindSpeed * Math.Sin(WindAngle - MapAngle);
        }

        /// <summary>
        /// Получение истинного решения по координате Y
        /// </summary>
        /// <returns></returns>
        public double GettingSolutionTrueY()
        {
            return TrueAirspeed * Math.Cos(CourseAngle - MapAngle) +
               WindSpeed * Math.Cos(WindAngle - MapAngle);
        }

        /// <summary>
        /// Получение измеренного решения по координате X
        /// </summary>
        /// <returns></returns>
        public double GettingSolutionMeasureX()
        {
            return ErrTrueAirspeed * Math.Sin(ErrCourseAngle - MapAngle) +
               ErrWindSpeed * Math.Sin(ErrWindAngle - MapAngle);
        }

        /// <summary>
        /// Получение измеренного решения по координате Y
        /// </summary>
        /// <returns></returns>
        public double GettingSolutionMeasureY()
        {
            return ErrTrueAirspeed * Math.Cos(ErrCourseAngle - MapAngle) +
               ErrWindSpeed * Math.Cos(ErrWindAngle - MapAngle);
        }

    }

}
