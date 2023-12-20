using ScottPlot;
using ZedGraph;
using System.Windows.Input;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Web;
using ConsoleProjectForNavigationSystem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Drawing;

namespace LaboratoryWork_2._0
{
    public partial class Form1 : Form
    {
        private TextBox[] textBoxes;

        private RadioButton[] radioButtons;

        //private Solver solve;

        private Calculator calculator;

        private string trueAirspeed
        {
            get { return trueAirSpeed_textBox.Text; }
            set { trueAirSpeed_textBox.Text = value; }
        }

        private string courseAngle
        {
            get { return courseAngle_textBox.Text; }
            set { courseAngle_textBox.Text = value; }
        }

        private string windSpeed
        {
            get { return windSpeed_textBox.Text; }
            set { windSpeed_textBox.Text = value; }
        }

        private string windAngle
        {
            get { return windAngle_textBox.Text; }
            set { windAngle_textBox.Text = value; }
        }

        private string mapAngle
        {
            get { return mapAngle_textBox.Text; }
            set { mapAngle_textBox.Text = value; }
        }

        private string flightTime
        {
            get { return flightTime_textBox.Text; }
            set { flightTime_textBox.Text = value; }
        }


        public Form1()
        {
            InitializeComponent();

            textBoxes = new TextBox[] {trueAirSpeed_textBox, courseAngle_textBox,
                windSpeed_textBox, windAngle_textBox, mapAngle_textBox };

            radioButtons = new RadioButton[] { radioButton1, radioButton2, radioButton3, radioButton4,
            radioButton5, radioButton6, radioButton7};

            TextBoxSettings();


        }

        /// <summary>
        /// Отрисовка графиков при помощи ZedGraph
        /// </summary>
        //private void ShowGraphs()
        //{
        //    zedGraphControl.GraphPane.CurveList.Clear();

        //    solve.PlotGraph(zedGraphControl, solve.Time.ToArray(),
        //        solve.DifferenceCoordinatesX.ToArray(), "Разница по оси X", Color.Black);

        //    solve.PlotGraph(zedGraphControl, solve.Time.ToArray(),
        //        solve.DifferenceCoordinatesY.ToArray(), "Разница по оси Y", Color.Red);

        //    zedGraphControl.AxisChange();

        //    zedGraphControl.Invalidate();
        //}

        private void ShowGraph()
        {
            zedGraphControl.GraphPane.Title.Text = "Разница между идеальными и измеренными значениями";
            zedGraphControl.GraphPane.Title.IsVisible = true;

            zedGraphControl.GraphPane.XAxis.Title.Text = "Время (с)";
            zedGraphControl.GraphPane.XAxis.Title.IsVisible = true;

            zedGraphControl.GraphPane.YAxis.Title.Text = "Координата (м)";
            zedGraphControl.GraphPane.XAxis.Title.IsVisible = true;


            zedGraphControl.GraphPane.CurveList.Clear();

            calculator.PlotGraph(zedGraphControl, calculator.AllPointsOfTime.ToArray(),
                calculator.Difference_X_Axis.ToArray(), "Разница по оси X", Color.Black);


            calculator.PlotGraph(zedGraphControl, calculator.AllPointsOfTime.ToArray(),
                calculator.Difference_Y_Axis.ToArray(), "Разница по оси Y", Color.Red);

            zedGraphControl.AxisChange();

            zedGraphControl.Invalidate();

        }

        /// <summary>
        /// Определяет нажатие букв и специалных символов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Пожалуйста, вводите только числа и только одну запятую!");
            }

            // Разрешена только одна запятая !
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Пожалуйста, вводите только числа и только одну запятую!");
            }
        }

        /// <summary>
        /// Ограничение ввода в TextBox
        /// </summary>
        private void TextBoxSettings()
        {
            foreach (var textBox in textBoxes)
            {
                textBox.MaxLength = 10;
                textBox.KeyPress += TextBox_KeyPress;
            }
        }
        
        private double CheckingInputValue(string value)
        {
            double result = default;
            try
            {
                result = Convert.ToDouble(value);
            }
            catch (Exception)
            {
                MessageBox.Show("Введите значение!");
            }
            return result;
        }

        private void solveButton_Click(object sender, EventArgs e)
        {

          
            double trueAirspeed = CheckingInputValue(this.trueAirSpeed_textBox.Text) / 3.6;
            double courseAngle = CheckingInputValue(this.courseAngle_textBox.Text) * Math.PI / 180;
            double windSpeed = CheckingInputValue(this.windSpeed_textBox.Text) / 3.6;
            double windAngle = CheckingInputValue(this.windAngle_textBox.Text) * Math.PI / 180;
            double mapAngle = CheckingInputValue(this.mapAngle_textBox.Text) * Math.PI / 180;
            double flightTime = CheckingInputValue(this.flightTime_textBox.Text) * 3600;

            Aircraft perfectAircraft = new Aircraft(trueAirspeed, courseAngle, windSpeed, windAngle, mapAngle);
            RealAircraft realAircraft = new RealAircraft(trueAirspeed, courseAngle, windSpeed, windAngle, mapAngle, 1);

            //Aircraft1 pAircraft = new Aircraft1(trueAirspeed, courseAngle, windSpeed, windAngle, mapAngle);
            //Aircraft1 rAircraft = new Aircraft1(trueAirspeed, courseAngle, windSpeed, windAngle, mapAngle);

            //solve = new Solver(pAircraft, rAircraft, 1.89 * 3600, 0, 1, 0);
            //solve.GetSolve();
            //ShowGraphs();

            if (radioButton1.Checked == true)
            {
                realAircraft.OptionCalculate = 0;
                calculator = new Calculator(perfectAircraft, realAircraft, flightTime, 0, 1);
                calculator.GetSolution();
                ShowGraph();
            }
            else if (radioButton2.Checked == true)
            {
                realAircraft.OptionCalculate = 1;
                calculator = new Calculator(perfectAircraft, realAircraft, flightTime, 0, 1);
                calculator.GetSolution();
                ShowGraph();

            }
            else if (radioButton3.Checked == true)
            {
                realAircraft.OptionCalculate = 2;
                calculator = new Calculator(perfectAircraft, realAircraft, flightTime, 0, 1);
                calculator.GetSolution();
                ShowGraph();
            }
            else if (radioButton4.Checked == true)
            {
                realAircraft.OptionCalculate = 3;
                calculator = new Calculator(perfectAircraft, realAircraft, flightTime, 0, 1);
                calculator.GetSolution();
                ShowGraph();
            }

            else if (radioButton5.Checked == true)
            {
                realAircraft.OptionCalculate = 4;
                calculator = new Calculator(perfectAircraft, realAircraft, flightTime, 0, 1);
                calculator.GetSolution();
                ShowGraph();
            }
            else if (radioButton6.Checked == true)
            {
                realAircraft.OptionCalculate = 5;
                calculator = new Calculator(perfectAircraft, realAircraft, flightTime, 0, 1);
                calculator.GetSolution();
                ShowGraph();
            }
            else if (radioButton7.Checked == true)
            {
                realAircraft.OptionCalculate = 6;
                calculator = new Calculator(perfectAircraft, realAircraft, flightTime, 0, 1);
                calculator.GetSolution();
                ShowGraph();
            }
            else
            {
                MessageBox.Show("Выберите задание для выполнения вычислений!");
            }
        }
    }
}