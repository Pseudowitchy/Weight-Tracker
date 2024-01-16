using System;
using System.Windows.Forms;

namespace Weight_Tracker
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            float goal = Properties.Settings.Default.GoalWeight;
            lblUnitHolder.Text = Properties.Settings.Default.UnitFormat;

            if (Properties.Settings.Default.UnitFormat == "lbs") { RadbtnUnitLbs_CheckedChanged(); }
            else if (Properties.Settings.Default.UnitFormat == "kg") { RadbtnUnitKgs_CheckedChanged(); goal /= 2.204623f; }
            else if (Properties.Settings.Default.UnitFormat == "st") { RadbtnUnitSt_CheckedChanged(); goal /= 14; }

            if (Properties.Settings.Default.DateFormat == "MM/dd/yyyy") { RadbtnDate1_CheckedChanged(); }
            else if (Properties.Settings.Default.DateFormat == "dd/MM/yyyy") { RadbtnDate2_CheckedChanged(); }

            txtGoal.Text = goal.ToString("0") + " " + Properties.Settings.Default.UnitFormat;
        }
        private void BtnApply_Click(object sender, EventArgs e)
        {
            if (radbtnUnitLbs.Checked) { Properties.Settings.Default.UnitFormat = "lbs"; }
            else if (radbtnUnitKg.Checked) { Properties.Settings.Default.UnitFormat = "kg"; }
            else if (radbtnUnitSt.Checked) { Properties.Settings.Default.UnitFormat = "st"; }

            if (radbtnDate1.Checked) { Properties.Settings.Default.DateFormat = "MM/dd/yyyy"; }
            else if (radbtnDate2.Checked) { Properties.Settings.Default.DateFormat = "dd/MM/yyyy"; }

            float goal = 0.0f;
            if (Properties.Settings.Default.UnitFormat == "lbs") goal = float.Parse(txtGoal.Text.Replace("lbs", ""));
            else if (Properties.Settings.Default.UnitFormat == "kg") goal = float.Parse(txtGoal.Text.Replace("kg", "")) * 2.204623f;
            else if (Properties.Settings.Default.UnitFormat == "st") goal = float.Parse(txtGoal.Text.Replace("st", "")) * 14;
            Properties.Settings.Default.GoalWeight = goal;

            Properties.Settings.Default.Save();
            this.Close();
        }
        private void BtnCancel_Click(object sender, EventArgs e) { this.Close(); }
        private void UnitChanged_Click(object sender, EventArgs e)
        {
            RadioButton radbtn = (RadioButton)sender;
            string unit = lblUnitHolder.Text;
            float value = float.Parse(txtGoal.Text.Replace(unit, ""));

            if (!radbtn.Text.Contains(unit))
            {
                if (unit == "lbs")
                {
                    if (radbtn.Text.Contains("kg")) { txtGoal.Text = (value / 2.204623f).ToString(".0"); }
                    else { txtGoal.Text = (value / 14).ToString(".0"); }
                }
                else if (unit == "kg")
                {
                    if (radbtn.Text.Contains("lbs")) { txtGoal.Text = (value * 2.204623f).ToString(".0"); }
                    else { txtGoal.Text = (value * .157473f).ToString(".0"); }
                }
                else if (unit == "st")
                {
                    if (radbtn.Text.Contains("lbs")) { txtGoal.Text = (value * 14).ToString(".0"); }
                    else { txtGoal.Text = (value / .157473f).ToString(".0"); }
                }
                txtGoal.Text += " " + radbtn.Tag.ToString();
                lblUnitHolder.Text = radbtn.Tag.ToString();
            }
        }
        private void RadbtnUnitLbs_CheckedChanged() { radbtnUnitLbs.Checked = true; }
        private void RadbtnUnitKgs_CheckedChanged() { radbtnUnitKg.Checked = true; }
        private void RadbtnUnitSt_CheckedChanged() { radbtnUnitSt.Checked = true; }
        private void RadbtnDate1_CheckedChanged() { radbtnDate1.Checked = true; }
        private void RadbtnDate2_CheckedChanged() { radbtnDate2.Checked = true; }
    }
}
