namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入矩阵左上角点横坐标";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(292, 15);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(137, 31);
            this.textBoxX.TabIndex = 1;
            this.textBoxX.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1427, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(49, 75);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(438, 634);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // chart1
            // 
            chartArea1.CursorX.SelectionEnd = -100D;
            chartArea1.CursorX.SelectionStart = 100D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(512, 92);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.Black;
            series1.MarkerSize = 3;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "平面点集合";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.DarkRed;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.DarkRed;
            series2.MarkerSize = 15;
            series2.Name = "矩阵上";
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.DarkRed;
            series3.Legend = "Legend1";
            series3.MarkerColor = System.Drawing.Color.DarkRed;
            series3.MarkerSize = 15;
            series3.Name = "矩阵下";
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.DarkRed;
            series4.Legend = "Legend1";
            series4.MarkerColor = System.Drawing.Color.DarkRed;
            series4.MarkerSize = 15;
            series4.Name = "矩阵左";
            series5.BorderWidth = 5;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.DarkRed;
            series5.LabelBorderWidth = 15;
            series5.Legend = "Legend1";
            series5.MarkerColor = System.Drawing.Color.DarkRed;
            series5.MarkerSize = 15;
            series5.Name = "矩阵右";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(1818, 1032);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(868, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "输入矩阵长";
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(1008, 15);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(130, 31);
            this.textBoxM.TabIndex = 6;
            this.textBoxM.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1286, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(495, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "随机生成1万个点，每个点坐标范围在-1万到1万之间";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(1290, 12);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(131, 31);
            this.textBoxN.TabIndex = 9;
            this.textBoxN.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1172, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "输入矩阵宽";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(693, 12);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(134, 31);
            this.textBoxY.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "输入矩阵左上角点纵坐标";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2342, 1136);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "鹰眼问题";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label5;
    }
}

