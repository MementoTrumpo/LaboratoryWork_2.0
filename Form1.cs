using ScottPlot;
using ZedGraph;
using System.Windows.Input;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Web;

namespace LaboratoryWork_2._0
{
    public partial class Form1 : Form
    {
        private TextBox[] textBoxes;

        private Solver solve;

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


            TextBoxSettings();


        }


        private void Form1_Load(object sender, EventArgs e)
        {


            double trueAirspeed = 252 / 3.6;
            double courseAngle = (2 * Math.PI / 180);
            double windSpeed = 116 / 3.6;
            double windAngle = (120 * Math.PI / 180);
            double allTime = 1.89 * 3600;
            double timeOfCycles = 0;
            double deltaTime = 1;

            //Aircraft realAircraft = new Aircraft(trueAirspeed, courseAngle, windSpeed, windAngle);
            //Aircraft measureAircraft = new Aircraft(trueAirspeed, courseAngle, windSpeed, windAngle);
            //solve = new Solver(realAircraft, measureAircraft, allTime, timeOfCycles, deltaTime);
            //solve.GetSolve();
            // ShowGraphs();


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

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Пожалуйста, вводите только числа и только одну запятую!");
            }
        }

     
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
            double flightTime;

            Aircraft1 realAircraft = new Aircraft1(trueAirspeed, courseAngle, windSpeed, windAngle, mapAngle);
            Aircraft1 measureAircraft = new Aircraft1(trueAirspeed, courseAngle, windSpeed, windAngle, mapAngle);

            if (radioButton1.Checked == true)
            {
                
            }



            solve = new Solver(realAircraft, measureAircraft, 1.89 * 3600, 0, 1, 4);

            solve.GetSolve();
            ShowGraphs();

        }

       
    }
}