using System;
using System.IO;
using System.Windows.Forms;

namespace Weight_Tracker
{
    public partial class Unit : Form
    {
        public Unit()
        {
            InitializeComponent();
        }
        private void Unit_Load(object sender, EventArgs e)
        {
            txtUnit.Text = File.ReadAllText("unit.txt");
        }
        private void BtnConfirm(object sender, EventArgs e)
        {
            File.WriteAllText("unit.txt", txtUnit.Text);
            this.Close();
        }
        private void BtnCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
