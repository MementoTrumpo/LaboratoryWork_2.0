namespace LaboratoryWork_2._0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            zedGraphControl = new ZedGraph.ZedGraphControl();
            solve_button = new Button();
            label2 = new Label();
            trueAirSpeed_textBox = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label1 = new Label();
            courseAngle_textBox = new TextBox();
            label4 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label5 = new Label();
            windAngle_textBox = new TextBox();
            label6 = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label7 = new Label();
            windSpeed_textBox = new TextBox();
            label8 = new Label();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label9 = new Label();
            mapAngle_textBox = new TextBox();
            label10 = new Label();
            flowLayoutPanel6 = new FlowLayoutPanel();
            label11 = new Label();
            flightTime_textBox = new TextBox();
            label12 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // zedGraphControl
            // 
            zedGraphControl.Location = new Point(284, 17);
            zedGraphControl.Margin = new Padding(5, 4, 5, 4);
            zedGraphControl.Name = "zedGraphControl";
            zedGraphControl.ScrollGrace = 0D;
            zedGraphControl.ScrollMaxX = 0D;
            zedGraphControl.ScrollMaxY = 0D;
            zedGraphControl.ScrollMaxY2 = 0D;
            zedGraphControl.ScrollMinX = 0D;
            zedGraphControl.ScrollMinY = 0D;
            zedGraphControl.ScrollMinY2 = 0D;
            zedGraphControl.Size = new Size(1036, 671);
            zedGraphControl.TabIndex = 0;
            zedGraphControl.UseExtendedPrintDialog = true;
            zedGraphControl.ZoomButtons2 = MouseButtons.Right;
            // 
            // solve_button
            // 
            solve_button.Location = new Point(15, 634);
            solve_button.Margin = new Padding(4);
            solve_button.Name = "solve_button";
            solve_button.Size = new Size(228, 53);
            solve_button.TabIndex = 1;
            solve_button.Text = "Вычислить";
            solve_button.UseVisualStyleBackColor = true;
            solve_button.Click += solveButton_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(5, 1);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(187, 28);
            label2.TabIndex = 3;
            label2.Text = "Истинная скорость";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trueAirSpeed_textBox
            // 
            trueAirSpeed_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            trueAirSpeed_textBox.ImeMode = ImeMode.NoControl;
            trueAirSpeed_textBox.Location = new Point(5, 33);
            trueAirSpeed_textBox.Margin = new Padding(4);
            trueAirSpeed_textBox.MaxLength = 10;
            trueAirSpeed_textBox.Name = "trueAirSpeed_textBox";
            trueAirSpeed_textBox.Size = new Size(145, 34);
            trueAirSpeed_textBox.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(trueAirSpeed_textBox);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Location = new Point(15, 17);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(1);
            flowLayoutPanel1.Size = new Size(228, 91);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(160, 36);
            label3.Margin = new Padding(6, 7, 6, 7);
            label3.Name = "label3";
            label3.Size = new Size(54, 28);
            label3.TabIndex = 5;
            label3.Text = "(км/ч)";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Controls.Add(courseAngle_textBox);
            flowLayoutPanel2.Controls.Add(label4);
            flowLayoutPanel2.Location = new Point(15, 116);
            flowLayoutPanel2.Margin = new Padding(4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(1);
            flowLayoutPanel2.Size = new Size(228, 91);
            flowLayoutPanel2.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 1);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 3;
            label1.Text = "Угол курса";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // courseAngle_textBox
            // 
            courseAngle_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            courseAngle_textBox.Location = new Point(5, 33);
            courseAngle_textBox.Margin = new Padding(4);
            courseAngle_textBox.Name = "courseAngle_textBox";
            courseAngle_textBox.Size = new Size(145, 34);
            courseAngle_textBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(160, 36);
            label4.Margin = new Padding(6, 7, 6, 7);
            label4.Name = "label4";
            label4.Size = new Size(52, 28);
            label4.TabIndex = 5;
            label4.Text = "(град)";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label5);
            flowLayoutPanel3.Controls.Add(windAngle_textBox);
            flowLayoutPanel3.Controls.Add(label6);
            flowLayoutPanel3.Location = new Point(15, 315);
            flowLayoutPanel3.Margin = new Padding(4);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(1);
            flowLayoutPanel3.Size = new Size(228, 91);
            flowLayoutPanel3.TabIndex = 9;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(5, 1);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(110, 28);
            label5.TabIndex = 3;
            label5.Text = "Угол ветра";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // windAngle_textBox
            // 
            windAngle_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            windAngle_textBox.Location = new Point(5, 33);
            windAngle_textBox.Margin = new Padding(4);
            windAngle_textBox.Name = "windAngle_textBox";
            windAngle_textBox.Size = new Size(145, 34);
            windAngle_textBox.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(160, 36);
            label6.Margin = new Padding(6, 7, 6, 7);
            label6.Name = "label6";
            label6.Size = new Size(52, 28);
            label6.TabIndex = 5;
            label6.Text = "(град)";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label7);
            flowLayoutPanel4.Controls.Add(windSpeed_textBox);
            flowLayoutPanel4.Controls.Add(label8);
            flowLayoutPanel4.Location = new Point(15, 216);
            flowLayoutPanel4.Margin = new Padding(4);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Padding = new Padding(1);
            flowLayoutPanel4.Size = new Size(228, 91);
            flowLayoutPanel4.TabIndex = 8;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(5, 1);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(153, 28);
            label7.TabIndex = 3;
            label7.Text = "Скорость ветра";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // windSpeed_textBox
            // 
            windSpeed_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            windSpeed_textBox.Location = new Point(5, 33);
            windSpeed_textBox.Margin = new Padding(4);
            windSpeed_textBox.Name = "windSpeed_textBox";
            windSpeed_textBox.Size = new Size(145, 34);
            windSpeed_textBox.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(160, 36);
            label8.Margin = new Padding(6, 7, 6, 7);
            label8.Name = "label8";
            label8.Size = new Size(54, 28);
            label8.TabIndex = 5;
            label8.Text = "(км/ч)";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(label9);
            flowLayoutPanel5.Controls.Add(mapAngle_textBox);
            flowLayoutPanel5.Controls.Add(label10);
            flowLayoutPanel5.Location = new Point(15, 414);
            flowLayoutPanel5.Margin = new Padding(4);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(1);
            flowLayoutPanel5.Size = new Size(228, 91);
            flowLayoutPanel5.TabIndex = 10;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(5, 1);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(113, 28);
            label9.TabIndex = 3;
            label9.Text = "Угол карты";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mapAngle_textBox
            // 
            mapAngle_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mapAngle_textBox.Location = new Point(5, 33);
            mapAngle_textBox.Margin = new Padding(4);
            mapAngle_textBox.Name = "mapAngle_textBox";
            mapAngle_textBox.Size = new Size(145, 34);
            mapAngle_textBox.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(160, 36);
            label10.Margin = new Padding(6, 7, 6, 7);
            label10.Name = "label10";
            label10.Size = new Size(52, 28);
            label10.TabIndex = 5;
            label10.Text = "(град)";
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(label11);
            flowLayoutPanel6.Controls.Add(flightTime_textBox);
            flowLayoutPanel6.Controls.Add(label12);
            flowLayoutPanel6.Location = new Point(15, 514);
            flowLayoutPanel6.Margin = new Padding(4);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Padding = new Padding(1);
            flowLayoutPanel6.Size = new Size(228, 91);
            flowLayoutPanel6.TabIndex = 11;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(5, 1);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(137, 28);
            label11.TabIndex = 3;
            label11.Text = "Время полёта";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flightTime_textBox
            // 
            flightTime_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            flightTime_textBox.Location = new Point(5, 33);
            flightTime_textBox.Margin = new Padding(4);
            flightTime_textBox.Name = "flightTime_textBox";
            flightTime_textBox.Size = new Size(145, 34);
            flightTime_textBox.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Location = new Point(160, 36);
            label12.Margin = new Padding(6, 7, 6, 7);
            label12.Name = "label12";
            label12.Size = new Size(44, 28);
            label12.TabIndex = 5;
            label12.Text = "(час)";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(244, 697);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(122, 25);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "Задание №1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(404, 697);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(122, 25);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "Задание №2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(564, 697);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(122, 25);
            radioButton3.TabIndex = 14;
            radioButton3.TabStop = true;
            radioButton3.Text = "Задание №3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(719, 697);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(122, 25);
            radioButton4.TabIndex = 15;
            radioButton4.TabStop = true;
            radioButton4.Text = "Задание №4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(881, 697);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(122, 25);
            radioButton5.TabIndex = 16;
            radioButton5.TabStop = true;
            radioButton5.Text = "Задание №5";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(1022, 697);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(122, 25);
            radioButton6.TabIndex = 17;
            radioButton6.TabStop = true;
            radioButton6.Text = "Задание №6";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(1164, 697);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(122, 25);
            radioButton7.TabIndex = 18;
            radioButton7.TabStop = true;
            radioButton7.Text = "Задание №7";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 734);
            Controls.Add(radioButton7);
            Controls.Add(radioButton6);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(flowLayoutPanel6);
            Controls.Add(flowLayoutPanel5);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(solve_button);
            Controls.Add(zedGraphControl);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl;
        private Button solve_button;
        private Label label2;
        private TextBox trueAirSpeed_textBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label1;
        private TextBox courseAngle_textBox;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label5;
        private TextBox windAngle_textBox;
        private Label label6;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label7;
        private TextBox windSpeed_textBox;
        private Label label8;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label9;
        private TextBox mapAngle_textBox;
        private Label label10;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label11;
        private TextBox flightTime_textBox;
        private Label label12;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
    }
}