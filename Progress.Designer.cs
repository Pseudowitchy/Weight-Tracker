namespace Weight_Tracker
{
    partial class Progress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartProgress = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // chartProgress
            // 
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.White;
            this.chartProgress.ChartAreas.Add(chartArea1);
            this.chartProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartProgress.Legends.Add(legend1);
            this.chartProgress.Location = new System.Drawing.Point(0, 0);
            this.chartProgress.Name = "chartProgress";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Your Weight";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.LightCoral;
            series2.Legend = "Legend1";
            series2.Name = "Start";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.YellowGreen;
            series3.Legend = "Legend1";
            series3.Name = "Goal";
            this.chartProgress.Series.Add(series1);
            this.chartProgress.Series.Add(series2);
            this.chartProgress.Series.Add(series3);
            this.chartProgress.Size = new System.Drawing.Size(1326, 825);
            this.chartProgress.TabIndex = 0;
            this.chartProgress.Text = "chart1";
            // 
            // Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1326, 825);
            this.Controls.Add(this.chartProgress);
            this.Name = "Progress";
            this.Text = "Progress";
            this.Load += new System.EventHandler(this.Progress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProgress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartProgress;
    }
}