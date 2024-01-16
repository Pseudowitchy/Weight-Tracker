using System;
using System.IO;
using System.Windows.Forms;

namespace Weight_Tracker
{
    public partial class Progress : Form
    {
        public Progress()
        {
            InitializeComponent();
        }
        private void Progress_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("weight_data.txt");

            float conversionMultiple = 1;

            if (Properties.Settings.Default.UnitFormat == "kg") { conversionMultiple = 2.204623f; }
            else if (Properties.Settings.Default.UnitFormat == "st") { conversionMultiple = 14; }

            float startWeight = float.Parse(lines[0].Remove(0, lines[0].IndexOf(",") + 1));
            float goalWeight = Properties.Settings.Default.GoalWeight;

            DateTime startDate = DateTime.Parse(lines[0].Remove(lines[0].IndexOf(",")));
            DateTime endDate = DateTime.Parse(lines[lines.Length - 1].Remove(lines[lines.Length - 1].IndexOf(",")));

            chartProgress.ChartAreas[0].AxisX.Minimum = startDate.AddDays(-14).ToOADate();
            chartProgress.ChartAreas[0].AxisX.Maximum = endDate.AddDays(14).ToOADate();
            chartProgress.ChartAreas[0].AxisX.LabelStyle.Format = Properties.Settings.Default.DateFormat;

            chartProgress.ChartAreas[0].AxisY.Minimum = (goalWeight / conversionMultiple) * .95;
            chartProgress.ChartAreas[0].AxisY.LabelStyle.Format = "0";

            foreach (string line in lines)
            {
                DateTime date = DateTime.Parse(line.Remove(line.IndexOf(",")));
                chartProgress.Series["Your Weight"].Points.AddXY(date,
                    (float.Parse(line.Remove(0, line.IndexOf(",") + 1))) / conversionMultiple);
                chartProgress.Series["Start"].Points.AddXY(date, startWeight / conversionMultiple);
                chartProgress.Series["Goal"].Points.AddXY(date, goalWeight / conversionMultiple);
            }
        }
    }
}
