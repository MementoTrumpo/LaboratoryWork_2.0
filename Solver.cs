using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using ZedGraph;

namespace LaboratoryWork_2._0
{
    public class Solver
    {
        /// <summary>
        /// Список координат X
        /// </summary>
        public List<double> DifferenceCoordinatesX = new List<double>();

        /// <summary>
        /// Список координат Y
        /// </summary>
        public List<double> DifferenceCoordinatesY = new List<double>();

        /// <summary>
        /// Список точек при измерении времени с шагом deltaTime
        /// </summary>
        public List<double> Time = new List<double>();

        /// <summary>
        /// Самолет для истинных значениях параметров
        /// </summary>
        private Aircraft1 realAircraft;

        /// <summary>
        /// Самолет для измеренных значений параметров
        /// </summary>
        private Aircraft1 measureAircraft;

        /// <summary>
        /// Полное время полета в (сек)
        /// </summary>
        public double AllTime { get; }

        /// <summary>
        /// Количество циклов
        /// </summary>
        public double TimeCycles { get; set; }

        /// <summary>
        /// Шаг измерений (1 сек - максимиум)
        /// </summary>
        public double DeltaTime { get; }

        /// <summary>
        /// Тип вычислений для выявления зависимостей (По вариантам) - У меня 10 вариант
        /// 1 - Обнуление случайной составляющей погрешности (всех составляющих)
        /// 2 - Увеличение постоянной составляющей погрешности на порядок
        /// 3 - Уменьшение постоянной составляющей погрешности на порядок
        /// 4 - Обнуление постоянной составляющей погрешностей (всех составляющих)
        /// 5 - Увеличение случайной составляющей погрешностей
        /// 6 - Уменьшение случайной составляющей погрешностей
        /// 
        /// </summary>
        public int TypeOfCalculations { get; set; }


        public Solver(Aircraft1 realAircraft, Aircraft1 measureAircraft, double allTime,
            double timeCycles, double deltaTime, int typeOfCalculations)
        {
            this.measureAircraft = measureAircraft;
            this.realAircraft = realAircraft;
            AllTime = allTime;
            TimeCycles = timeCycles;
            DeltaTime = deltaTime;
            TypeOfCalculations = typeOfCalculations;
        }


        public void GetSolve()
        {
            double X_CURRENT_REAL, X_NEXT_REAL;
            double Y_CURRENT_REAL, Y_NEXT_REAL;

            double X_CURRENT_MEASURED, X_NEXT_MEASURED; 
            double Y_CURRENT_MEASURED, Y_NEXT_MEASURED;

            while(TimeCycles <= AllTime)
            {
                X_CURRENT_REAL = realAircraft.GettingSolutionTrueX();
                X_NEXT_REAL = realAircraft.XInitialCoordinate + X_CURRENT_REAL * DeltaTime;

                Y_CURRENT_REAL = realAircraft.GettingSolutionTrueY();
                Y_NEXT_REAL = realAircraft.YInitialCoordinate + Y_CURRENT_REAL * DeltaTime;

                X_CURRENT_MEASURED = measureAircraft.GettingSolutionMeasureX();
                X_NEXT_MEASURED = measureAircraft.XInitialCoordinate + X_CURRENT_MEASURED * DeltaTime;

                Y_CURRENT_MEASURED = measureAircraft.GettingSolutionMeasureY();
                Y_NEXT_MEASURED = measureAircraft.YInitialCoordinate + Y_CURRENT_MEASURED * DeltaTime;

                DifferenceCoordinatesX.Add(X_NEXT_MEASURED - X_NEXT_REAL);
                DifferenceCoordinatesY.Add(Y_NEXT_MEASURED - Y_NEXT_REAL);

                realAircraft.XInitialCoordinate = X_NEXT_REAL;
                realAircraft.YInitialCoordinate = Y_NEXT_REAL;

                measureAircraft.XInitialCoordinate = X_NEXT_MEASURED;
                measureAircraft.YInitialCoordinate = Y_NEXT_MEASURED;
                
                TimeCycles += DeltaTime;

               
            }

            GeneratePointsOfTime();
        }
        /// <summary>
        /// Вычисление истинного значения с датчиков полета
        /// </summary>
        //private void CalculatingTrueValue(out double result )
        //{
        //    double X_CURRENT_REAL = realAircraft.GettingSolutionTrueX();
        //    double X_NEXT_REAL = realAircraft.XInitialCoordinate + X_CURRENT_REAL * DeltaTime;
           
        //    double Y_CURRENT_REAL = realAircraft.GettingSolutionTrueY();
        //    double Y_NEXT_REAL = realAircraft.YInitialCoordinate + Y_CURRENT_REAL * DeltaTime;

        //    return 
        //}


        /// <summary>
        /// Создание точек для оси времени
        /// </summary>
        private void GeneratePointsOfTime()
        {
            double initialValue = 0;
            for (int i = 0; i < DifferenceCoordinatesX.Count; i++)
            {
                Time.Add(initialValue);
                initialValue += DeltaTime;

            }
        }

        /// Отрисовка графика в форме
        /// </summary>
        /// <param name="zedGraphControl"></param>
        /// <param name="time"></param>
        /// <param name="coordinates"></param>
        /// <param name="axisCaption"></param>
        public void PlotGraph(ZedGraphControl zedGraphControl, double[] time, double[] coordinates,
            string axisCaption, Color color)
        {
            GraphPane graphPane = zedGraphControl.GraphPane;

            //graphPane.CurveList.Clear();

            PointPairList list = new PointPairList(time, coordinates);

            LineItem line = graphPane.AddCurve(axisCaption, list, color, SymbolType.None);


        }

    }
}
