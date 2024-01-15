using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Weight_Tracker
{
    public partial class Recent : Form
    {
        public Recent()
        {
            InitializeComponent();
        }
        private void Recent_Load(object sender, EventArgs e)
        {
            ResetList();
        }
        private void EditMode_Change(object sender, EventArgs e)
        {
            ResetList();
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.Enabled = (!button.Enabled);
                if (button.Text == "Save") { button.Text = "Edit"; }
            }
            foreach (var textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Enabled = false;
            }
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button = (Button)sender;

            string index = new string(button.Name.Where(c => char.IsDigit(c)).ToArray());

            if (button.Text == "Edit")
            {
                foreach (var textbox in this.Controls.OfType<TextBox>())
                {
                    if (textbox.Name.Contains(index)) { textbox.Enabled = true; }
                    else textbox.Enabled = false;
                }
                foreach (var editButton in this.Controls.OfType<Button>().Where(btn => !btn.Text.Contains("Delete")))
                {
                    if (editButton.Name.Contains(index)) { editButton.Text = "Save"; }
                    else editButton.Text = "Edit";
                }
            }
            else if (button.Text == "Save")
            {
                string[] data = File.ReadAllLines("weight_data.txt");
                int location = data.Length - 1 - int.Parse(index);

                foreach (var label in this.Controls.OfType<Label>().Where(lbl => lbl.Name.Contains(index)))
                    if (label.Name.Contains("Date"))
                        data[location] = data[location].Remove(data[location].IndexOf(",") + 1);

                foreach (var textbox in this.Controls.OfType<TextBox>().Where(txt => txt.Name.Contains(index)))
                { 
                    data[location] += textbox.Text.Replace(Properties.Settings.Default.UnitFormat, "");
                    textbox.Enabled = false;
                }

                button.Text = "Edit";
                File.WriteAllLines("weight_data.txt", data);
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var confirmDelete = MessageBox.Show("Are you sure you wish to delete this entry?",
                                                "Confirm Deletion",
                                                MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                Button button = new Button();
                button = (Button)sender;

                string index = new string(button.Name.Where(c => char.IsDigit(c)).ToArray());
                List<string> data = new List<string>(File.ReadAllLines("weight_data.txt"));

                string entryToDelete = "";

                foreach (var label in this.Controls.OfType<Label>().Where(lbl => lbl.Name.Contains(index)))
                    if (label.Name.Contains("Date")) { entryToDelete = label.Text + ","; }
                foreach (var textbox in this.Controls.OfType<TextBox>().Where(txt => txt.Name.Contains(index)))
                        entryToDelete += textbox.Text; 

                for (int i = 0; i < data.Count; i++)
                {
                    if (data[i] ==  entryToDelete) { data.RemoveAt(i); }
                }
                File.WriteAllLines("weight_data.txt", data);
                ResetList();
            }
        }
        private void ResetList()
        {
            int lineCount = File.ReadLines("weight_data.txt").Count();
            string unit = Properties.Settings.Default.UnitFormat;
            for (int i = 0; i <= 9; i++)
            {
                string content = File.ReadLines("weight_data.txt").Skip(lineCount - i - 1).Take(1).First();
                foreach (var label in this.Controls.OfType<Label>().Where(lbl => lbl.Name.Contains(i.ToString())))
                {
                    if (label.Name.Contains("Date")) { label.Text = DateFormatCheck(content.Remove(content.IndexOf(","))); }
                }
                foreach (var textbox in this.Controls.OfType<TextBox>().Where(txt => txt.Name.Contains(i.ToString())))
                {
                    if (textbox.Name.Contains("Weight"))
                        textbox.Text = WeightFormatCheck(content.Remove(0, content.IndexOf(",") + 1)) + " " + unit;
                }
            }
        }
        private string WeightFormatCheck(string weight)
        {
            if (Properties.Settings.Default.UnitFormat == "lbs") { return weight; }
            else if (Properties.Settings.Default.UnitFormat == "kg")
                return (float.Parse(weight) / 2.204623f).ToString(".0");
            else return (float.Parse(weight) / 14f).ToString(".0");


        }
        private string DateFormatCheck(string date)
        {
            if (Properties.Settings.Default.DateFormat == "MM/dd/yyyy") { return date; }
            else { return DateTime.Parse(date).ToString("dd/MM/yyyy"); }
        }
    }
}
