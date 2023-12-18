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

        private Solver solve;

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

       
        public Form1()
        {
            InitializeComponent();

            textBoxes = new TextBox[] {trueAirSpeed_textBox, courseAngle_textBox,
                windSpeed_textBox, windAngle_textBox, mapAngle_textBox };

            radioButtons = new RadioButton[] { radioButton1, radioButton2, radioButton3, radioButton4,
            radioButton5, radioButton6, radioButton7};

            TextBoxSettings();


        }


        //private void Form1_Load(object sender, EventArgs e)
        //{


        //    double trueAirspeed = 252 / 3.6;
        //    double courseAngle = (2 * Math.PI / 180);
        //    double windSpeed = 116 / 3.6;
        //    double windAngle = (120 * Math.PI / 180);
        //    double allTime = 1.89 * 3600;
        //    double timeOfCycles = 0;
        //    double deltaTime = 1;

        //    //Aircraft realAircraft = new Aircraft(trueAirspeed, courseAngle, windSpeed, windAngle);
        //    //Aircraft measureAircraft = new Aircraft(trueAirspeed, courseAngle, windSpeed, windAngle);
        //    //solve = new Solver(realAircraft, measureAircraft, allTime, timeOfCycles, deltaTime);
        //    //solve.GetSolve();
        //    // ShowGraphs();


        //    //Aircraft perfectAircraft = new Aircraft(332 / 3.6, 2 * Math.PI / 180, 116 / 3.6, 120 * Math.PI / 180, 0);
        //    //RealAircraft realAircraft = new RealAircraft(332 / 3.6, 2 * Math.PI / 180, 116 / 3.6, 120 * Math.PI / 180, 0);

        //    //new Calculator(perfectAircraft, realAircraft, 1.89 * 3600, 0, 1);

        //    //calculator.GetSolution();


        //    //ShowInformation();


        //}

        private void ShowInformation()
        {
            foreach(var x in calculator.Difference_X_Axis)
            {
                Trace.WriteLine(x);
            }
        }

        /// <summary>
        /// Отрисовка графиков при помощи ZedGraph
        /// </summary>
        private void ShowGraphs()
        {
            zedGraphControl.GraphPane.CurveList.Clear();

            solve.PlotGraph(zedGraphControl, solve.Time.ToArray(),
                solve.DifferenceCoordinatesX.ToArray(), "Разница по оси X", Color.Black);

            solve.PlotGraph(zedGraphControl, solve.Time.ToArray(),
                solve.DifferenceCoordinatesY.ToArray(), "Разница по оси Y", Color.Red);

            zedGraphControl.AxisChange();

            zedGraphControl.Invalidate();
        }

        private void ShowGraph()
        {
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

        private void solveButton_Click(object sender, EventArgs e)
        {
            double trueAirspeed = Convert.ToDouble(this.trueAirspeed) / 3.6;
            double courseAngle = Convert.ToDouble(this.courseAngle) * Math.PI / 180;
            double windSpeed = Convert.ToDouble(this.windSpeed) / 3.6;
            double windAngle = Convert.ToDouble(this.windAngle) * Math.PI / 180;
            double mapAngle = Convert.ToDouble(this.mapAngle) * Math.PI / 180;

            Aircraft perfectAircraft = new Aircraft(trueAirspeed, courseAngle, windSpeed, windAngle, mapAngle);
            RealAircraft realAircraft = new RealAircraft(trueAirspeed, courseAngle, windSpeed, windAngle, mapAngle);

            Aircraft1 pAircraft = new Aircraft1(trueAirspeed, courseAngle, windSpeed, windAngle, mapAngle);
            Aircraft1 rAircraft = new Aircraft1(trueAirspeed, courseAngle, windSpeed, windAngle, mapAngle);

            //solve = new Solver(pAircraft, rAircraft, 1.89 * 3600, 0, 1, 0);
            //solve.GetSolve();
            //ShowGraphs();

            if (radioButton1.Checked == true)
            {
                realAircraft.FirstTask();
                
                calculator = new Calculator(perfectAircraft, realAircraft, 1.89 * 3600, 0, 1);
                calculator.GetSolution();
                ShowGraph();
            }
            else if (radioButton2.Checked == true)
            {
                realAircraft.SecondTask();
                calculator = new Calculator(perfectAircraft, realAircraft, 1.89 * 3600, 0, 1);
                calculator.GetSolution();
                ShowGraph();

            }
            else if (radioButton3.Checked == true)
            {
                realAircraft.ThirdTask();

                calculator = new Calculator(perfectAircraft, realAircraft, 1.89 * 3600, 0, 1);
                calculator.GetSolution();
                ShowGraph();

            }




            //calculator = new Calculator(perfectAircraft, realAircraft, 1.89 * 3600, 0, 1);
            //calculator.GetSolution();
            //ShowGraph();
            //solve = new Solver(realAircraft, perfectAircraft,1.89 * 3600, 0, 1, 4);

            //solve.GetSolve();
            //ShowGraphs();

        }


    }
}