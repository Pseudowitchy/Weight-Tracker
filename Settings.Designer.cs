namespace Weight_Tracker
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.radbtnUnitSt = new System.Windows.Forms.RadioButton();
            this.radbtnUnitKg = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGoal = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUnitHolder = new System.Windows.Forms.Label();
            this.radbtnUnitLbs = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radbtnDate1 = new System.Windows.Forms.RadioButton();
            this.radbtnDate2 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unit Type:";
            // 
            // radbtnUnitSt
            // 
            this.radbtnUnitSt.AutoSize = true;
            this.radbtnUnitSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnUnitSt.Location = new System.Drawing.Point(12, 93);
            this.radbtnUnitSt.Name = "radbtnUnitSt";
            this.radbtnUnitSt.Size = new System.Drawing.Size(104, 24);
            this.radbtnUnitSt.TabIndex = 2;
            this.radbtnUnitSt.Tag = "st";
            this.radbtnUnitSt.Text = "Stone (st)";
            this.radbtnUnitSt.UseVisualStyleBackColor = true;
            this.radbtnUnitSt.Click += new System.EventHandler(this.UnitChanged_Click);
            // 
            // radbtnUnitKg
            // 
            this.radbtnUnitKg.AutoSize = true;
            this.radbtnUnitKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnUnitKg.Location = new System.Drawing.Point(12, 63);
            this.radbtnUnitKg.Name = "radbtnUnitKg";
            this.radbtnUnitKg.Size = new System.Drawing.Size(130, 24);
            this.radbtnUnitKg.TabIndex = 3;
            this.radbtnUnitKg.Tag = "kg";
            this.radbtnUnitKg.Text = "Kilogram (kg)";
            this.radbtnUnitKg.UseVisualStyleBackColor = true;
            this.radbtnUnitKg.Click += new System.EventHandler(this.UnitChanged_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date Format:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Goal Weight:";
            // 
            // txtGoal
            // 
            this.txtGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoal.Location = new System.Drawing.Point(17, 53);
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.Size = new System.Drawing.Size(121, 26);
            this.txtGoal.TabIndex = 7;
            this.txtGoal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblUnitHolder);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radbtnUnitLbs);
            this.panel1.Controls.Add(this.radbtnUnitSt);
            this.panel1.Controls.Add(this.radbtnUnitKg);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 145);
            this.panel1.TabIndex = 8;
            // 
            // lblUnitHolder
            // 
            this.lblUnitHolder.AutoSize = true;
            this.lblUnitHolder.Location = new System.Drawing.Point(45, 120);
            this.lblUnitHolder.Name = "lblUnitHolder";
            this.lblUnitHolder.Size = new System.Drawing.Size(44, 16);
            this.lblUnitHolder.TabIndex = 4;
            this.lblUnitHolder.Text = "label2";
            this.lblUnitHolder.Visible = false;
            // 
            // radbtnUnitLbs
            // 
            this.radbtnUnitLbs.AutoSize = true;
            this.radbtnUnitLbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnUnitLbs.Location = new System.Drawing.Point(12, 33);
            this.radbtnUnitLbs.Name = "radbtnUnitLbs";
            this.radbtnUnitLbs.Size = new System.Drawing.Size(125, 24);
            this.radbtnUnitLbs.TabIndex = 1;
            this.radbtnUnitLbs.Tag = "lbs";
            this.radbtnUnitLbs.Text = "Pounds (lbs)";
            this.radbtnUnitLbs.UseVisualStyleBackColor = true;
            this.radbtnUnitLbs.Click += new System.EventHandler(this.UnitChanged_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.radbtnDate1);
            this.panel2.Controls.Add(this.radbtnDate2);
            this.panel2.Location = new System.Drawing.Point(154, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 145);
            this.panel2.TabIndex = 9;
            // 
            // radbtnDate1
            // 
            this.radbtnDate1.AutoSize = true;
            this.radbtnDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnDate1.Location = new System.Drawing.Point(9, 32);
            this.radbtnDate1.Name = "radbtnDate1";
            this.radbtnDate1.Size = new System.Drawing.Size(134, 24);
            this.radbtnDate1.TabIndex = 4;
            this.radbtnDate1.Text = "MM/DD/YYYY";
            this.radbtnDate1.UseVisualStyleBackColor = true;
            // 
            // radbtnDate2
            // 
            this.radbtnDate2.AutoSize = true;
            this.radbtnDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnDate2.Location = new System.Drawing.Point(9, 62);
            this.radbtnDate2.Name = "radbtnDate2";
            this.radbtnDate2.Size = new System.Drawing.Size(134, 24);
            this.radbtnDate2.TabIndex = 11;
            this.radbtnDate2.Text = "DD/MM/YYYY";
            this.radbtnDate2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtGoal);
            this.panel3.Location = new System.Drawing.Point(0, 144);
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 100);
            this.panel3.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(177, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 35);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(177, 155);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(126, 35);
            this.btnApply.TabIndex = 12;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(325, 244);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radbtnUnitLbs;
        private System.Windows.Forms.RadioButton radbtnUnitSt;
        private System.Windows.Forms.RadioButton radbtnUnitKg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGoal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radbtnDate1;
        private System.Windows.Forms.RadioButton radbtnDate2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblUnitHolder;
    }
}