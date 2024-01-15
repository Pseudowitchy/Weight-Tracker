namespace Weight_Tracker
{
    partial class Menu
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
            this.btnRecord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRecent = new System.Windows.Forms.Button();
            this.btnProgress = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNewWeight = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRecord
            // 
            this.btnRecord.Enabled = false;
            this.btnRecord.Location = new System.Drawing.Point(80, 104);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(0);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(176, 32);
            this.btnRecord.TabIndex = 1;
            this.btnRecord.Text = "Record Current Weight";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.BtnRecord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Weight Tracker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "v2.0";
            // 
            // btnRecent
            // 
            this.btnRecent.Location = new System.Drawing.Point(80, 144);
            this.btnRecent.Margin = new System.Windows.Forms.Padding(0);
            this.btnRecent.Name = "btnRecent";
            this.btnRecent.Size = new System.Drawing.Size(176, 32);
            this.btnRecent.TabIndex = 2;
            this.btnRecent.Text = "Show/Edit Recent Entries";
            this.btnRecent.UseVisualStyleBackColor = true;
            this.btnRecent.Click += new System.EventHandler(this.BtnRecent_Click);
            // 
            // btnProgress
            // 
            this.btnProgress.Location = new System.Drawing.Point(80, 176);
            this.btnProgress.Margin = new System.Windows.Forms.Padding(0);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(176, 32);
            this.btnProgress.TabIndex = 3;
            this.btnProgress.Text = "Show Progress Chart";
            this.btnProgress.UseVisualStyleBackColor = true;
            this.btnProgress.Click += new System.EventHandler(this.BtnProgress_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(80, 224);
            this.btnOptions.Margin = new System.Windows.Forms.Padding(0);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(176, 32);
            this.btnOptions.TabIndex = 4;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.BtnOptions_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(16, 216);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 1);
            this.panel1.TabIndex = 7;
            // 
            // txtNewWeight
            // 
            this.txtNewWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewWeight.Location = new System.Drawing.Point(80, 72);
            this.txtNewWeight.Margin = new System.Windows.Forms.Padding(0);
            this.txtNewWeight.Name = "txtNewWeight";
            this.txtNewWeight.Size = new System.Drawing.Size(172, 28);
            this.txtNewWeight.TabIndex = 0;
            this.txtNewWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNewWeight.TextChanged += new System.EventHandler(this.TxtNewWeight_Change);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(252, 78);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(47, 18);
            this.lblUnit.TabIndex = 8;
            this.lblUnit.Text = "{unit}";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 264);
            this.Controls.Add(this.txtNewWeight);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnProgress);
            this.Controls.Add(this.btnRecent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.lblUnit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Weight Tracker";
            this.Activated += new System.EventHandler(this.FormFocus);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRecent;
        private System.Windows.Forms.Button btnProgress;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNewWeight;
        private System.Windows.Forms.Label lblUnit;
    }
}

