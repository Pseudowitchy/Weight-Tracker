using System;
using System.IO;
using System.Windows.Forms;

namespace Weight_Tracker
{
    public partial class Goal : Form
    {
        public Goal()
        {
            InitializeComponent();
        }
        private void Goal_Load(object sender, EventArgs e)
        {
            txtGoal.Text = File.ReadAllText("weight_goal.txt");
        }

        private void BtnConfirm(object sender, EventArgs e)
        {
            try
            {
                float goal = float.Parse(txtGoal.Text);
                File.WriteAllText("weight_goal.txt", goal.ToString());
                this.Close();
            }
            catch { lblError.Visible = true; }
        }
        private void BtnCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
