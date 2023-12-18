﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace ConsoleProjectForNavigationSystem
{
    public class Calculator
    {
        /// <summary>
        /// Разница координат по X между идеальными и реальными измерениями
        /// </summary>
        public List<double> Difference_X_Axis = new List<double>();

        /// <summary>
        /// Разница координат по Y между идеальными и реальными измерениями
        /// </summary>
        public List<double> Difference_Y_Axis = new List<double>();

        /// <summary>
        /// Все точки измерений координат с датчиков во время полета
        /// </summary>
        public List<double> AllPointsOfTime = new List<double>();

        /// <summary>
        /// Идеальные измерения с самолета
        /// </summary>
        public Aircraft _perfectAircraft;



        /// <summary>
        /// Реальные измерения с самолета ( с помехеми)
        /// </summary>
        public RealAircraft _realAircraft;


        /// <summary>
        /// Время полета ( в сек.)
        /// </summary>
        public double AllTime { get; set; }

        /// <summary>
        /// Количество шагов для вычисления координат
        /// </summary>
        public double TimeCycles { get; set; }

        /// <summary>
        /// Шаг между соседними измерениями с датчиков ( не более 1 сек.)
        /// </summary>
        public double DeltaTime { get; set; }


        public Calculator(Aircraft perfectAircraft, RealAircraft realAircraft,
            double allTime, double timeCycles, double deltaTime)
        {
            _perfectAircraft = perfectAircraft;
            _realAircraft = realAircraft;
            AllTime = allTime;
            TimeCycles = timeCycles;
            DeltaTime = deltaTime;
            
                    
        }

        public void GetSolution()
        {
            double X_CURRENT_REAL, X_NEXT_REAL;
            double Y_CURRENT_REAL, Y_NEXT_REAL;

            double X_CURRENT_PERFECT, X_NEXT_PERFECT;
            double Y_CURRENT_PERFECT, Y_NEXT_PERFECT;

            while (TimeCycles <= AllTime)
            {
                


                //-----------------------------------------------------------------------------------
                X_CURRENT_PERFECT = _perfectAircraft.ReturnCoordinateX();
                X_NEXT_PERFECT = _perfectAircraft.X_INITIAL_VALUE + X_CURRENT_PERFECT * DeltaTime;

                Y_CURRENT_PERFECT = _perfectAircraft.ReturnCoordinateY();
                Y_NEXT_PERFECT = _perfectAircraft.Y_INITIAL_VALUE + Y_CURRENT_PERFECT * DeltaTime;

                //-----------------------------------------------------------------------------------


                X_CURRENT_REAL = _realAircraft.ReturnCoordinateX();
                X_NEXT_REAL = _realAircraft.X_INITIAL_VALUE + X_CURRENT_REAL * DeltaTime;

                Y_CURRENT_REAL = _realAircraft.ReturnCoordinateY();
                Y_NEXT_REAL = _realAircraft.Y_INITIAL_VALUE + Y_CURRENT_REAL * DeltaTime;
                //

                Difference_X_Axis.Add(X_NEXT_REAL - X_NEXT_PERFECT);
                Difference_Y_Axis.Add(Y_NEXT_REAL - Y_NEXT_PERFECT);

                _realAircraft.X_INITIAL_VALUE = X_NEXT_REAL;
                _realAircraft.Y_INITIAL_VALUE = Y_NEXT_REAL;

                _perfectAircraft.X_INITIAL_VALUE = X_NEXT_PERFECT;
                _perfectAircraft.Y_INITIAL_VALUE = Y_NEXT_PERFECT;

                TimeCycles += DeltaTime;

            }

            GeneratePointsOfTime();
        }

        private void GeneratePointsOfTime()
        {
            double initialValue = 0;
            for (int i = 0; i < Difference_X_Axis.Count; i++)
            {
                AllPointsOfTime.Add(initialValue);
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
