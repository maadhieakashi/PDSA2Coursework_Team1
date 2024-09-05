namespace PDSA2Coursework_Team1
{
    partial class MinimumCost
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnGenerate = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btncheck = new Guna.UI2.WinForms.Guna2Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelUser = new System.Windows.Forms.Panel();
            this.Panelcost = new System.Windows.Forms.Panel();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHomePage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnHomePage)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(28, 386);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 25);
            this.label5.TabIndex = 83;
            this.label5.Text = "Enter optimal assignment of cost:\r\n";
            // 
            // btnReset
            // 
            this.btnReset.BorderRadius = 5;
            this.btnReset.BorderThickness = 2;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.FillColor = System.Drawing.Color.Gold;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(283, 655);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(2);
            this.btnReset.Size = new System.Drawing.Size(188, 37);
            this.btnReset.TabIndex = 82;
            this.btnReset.Text = "RESET";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerate.FillColor = System.Drawing.Color.Yellow;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGenerate.ForeColor = System.Drawing.Color.Black;
            this.btnGenerate.Location = new System.Drawing.Point(538, 113);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnGenerate.Size = new System.Drawing.Size(111, 28);
            this.btnGenerate.TabIndex = 81;
            this.btnGenerate.Text = "Generate Costs";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btncheck
            // 
            this.btncheck.BorderRadius = 5;
            this.btncheck.BorderThickness = 2;
            this.btncheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncheck.FillColor = System.Drawing.Color.Gold;
            this.btncheck.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.ForeColor = System.Drawing.Color.Black;
            this.btncheck.Location = new System.Drawing.Point(28, 655);
            this.btncheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncheck.Name = "btncheck";
            this.btncheck.Padding = new System.Windows.Forms.Padding(2);
            this.btncheck.Size = new System.Drawing.Size(188, 37);
            this.btncheck.TabIndex = 80;
            this.btncheck.Text = "CHECK ANSWERS";
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(290, 603);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(182, 28);
            this.txtTotal.TabIndex = 79;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(28, 603);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 25);
            this.label4.TabIndex = 78;
            this.label4.Text = "Total Minimum Cost :";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(298, 76);
            this.txtPlayerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(182, 28);
            this.txtPlayerName.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(28, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 25);
            this.label3.TabIndex = 76;
            this.label3.Text = "Enter number of tasks :\r\n";
            // 
            // PanelUser
            // 
            this.PanelUser.Location = new System.Drawing.Point(32, 422);
            this.PanelUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelUser.Name = "PanelUser";
            this.PanelUser.Size = new System.Drawing.Size(293, 130);
            this.PanelUser.TabIndex = 75;
            // 
            // Panelcost
            // 
            this.Panelcost.Location = new System.Drawing.Point(32, 160);
            this.Panelcost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Panelcost.Name = "Panelcost";
            this.Panelcost.Size = new System.Drawing.Size(446, 130);
            this.Panelcost.TabIndex = 74;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(298, 113);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(182, 28);
            this.txtNumber.TabIndex = 73;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(28, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 72;
            this.label2.Text = "Enter player name :\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(348, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 41);
            this.label1.TabIndex = 71;
            this.label1.Text = "MINIMUM COST";
            // 
            // btnHomePage
            // 
            this.btnHomePage.BackColor = System.Drawing.Color.Transparent;
            this.btnHomePage.FillColor = System.Drawing.Color.SkyBlue;
            this.btnHomePage.Image = global::PDSA2Coursework_Team1.Properties.Resources.home_menu;
            this.btnHomePage.ImageRotate = 0F;
            this.btnHomePage.Location = new System.Drawing.Point(842, 7);
            this.btnHomePage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnHomePage.Size = new System.Drawing.Size(64, 68);
            this.btnHomePage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHomePage.TabIndex = 84;
            this.btnHomePage.TabStop = false;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // MinimumCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PDSA2Coursework_Team1.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 699);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PanelUser);
            this.Controls.Add(this.Panelcost);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MinimumCost";
            this.Text = "MinimumCost";
            ((System.ComponentModel.ISupportInitialize)(this.btnHomePage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2CircleButton btnGenerate;
        private Guna.UI2.WinForms.Guna2Button btncheck;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelUser;
        private System.Windows.Forms.Panel Panelcost;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnHomePage;
    }
}