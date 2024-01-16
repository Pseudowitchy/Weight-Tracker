using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Weight_Tracker
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void TxtNewWeight_Change(object sender, EventArgs e)
        {
            float weight;
            try { weight = float.Parse(txtNewWeight.Text); }
            catch { weight = 0.0f; }

            if (weight != 0.0f) { btnRecord.Enabled = true; }
            else { btnRecord.Enabled = false; }
        }
        private void FormFocus(object sender, EventArgs e) { lblUnit.Text = Properties.Settings.Default.UnitFormat; }
        private void BtnRecord_Click(object sender, EventArgs e)
        {
            float newWeight = WeightConversion(float.Parse(txtNewWeight.Text), Properties.Settings.Default.UnitFormat);

            string newData = DateTime.Now.ToString("MM/dd/yyyy") + "," + newWeight.ToString(".0");
            using (var textWriter = File.AppendText("weight_data.txt"))
                textWriter.WriteLine(newData);

            MessageBox.Show("New entry saved to data set!");

            btnRecent.Enabled = true;
            btnProgress.Enabled = true;
        }
        private void BtnRecent_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Recent>().Any())
            {
                Application.OpenForms.OfType<Recent>().First().BringToFront();
            }
            else { var recentForm = new Recent(); recentForm.Show(); }
        }
        private void BtnProgress_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Progress>().Any())
            {
                Application.OpenForms.OfType<Progress>().First().BringToFront();
            }
            else { var recentForm = new Progress(); recentForm.Show(); }
        }
        private void BtnOptions_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Settings>().Any())
            {
                Application.OpenForms.OfType<Settings>().First().BringToFront();
            }
            else { var recentForm = new Settings(); recentForm.Show(); }
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            string[] dataCheck = File.ReadAllLines("weight_data.txt");

            if (dataCheck.Length == 0)
            {
                btnRecent.Enabled = false;
                btnProgress.Enabled = false;
            }

            lblUnit.Text = Properties.Settings.Default.UnitFormat;
        }
        private float WeightConversion(float weight, string unit)
        {
            if (unit == "kg") { return weight * 2.204623f; }
            else if (unit == "st") { return weight * 14f; }
            return weight;
        }
    }
}
