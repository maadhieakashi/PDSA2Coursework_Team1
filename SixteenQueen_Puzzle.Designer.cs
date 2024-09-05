namespace PDSA2Coursework_Team1
{
    partial class SixteenQueen_Puzzle
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Panel chessboardPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.RestartButton = new System.Windows.Forms.Button();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.chessboardPanel = new System.Windows.Forms.Panel();
            this.Solutionlbl = new System.Windows.Forms.Label();
            this.col = new System.Windows.Forms.Label();
            this.col2 = new System.Windows.Forms.Label();
            this.col1 = new System.Windows.Forms.Label();
            this.col6 = new System.Windows.Forms.Label();
            this.col5 = new System.Windows.Forms.Label();
            this.col4 = new System.Windows.Forms.Label();
            this.col3 = new System.Windows.Forms.Label();
            this.col9 = new System.Windows.Forms.Label();
            this.col8 = new System.Windows.Forms.Label();
            this.col7 = new System.Windows.Forms.Label();
            this.col12 = new System.Windows.Forms.Label();
            this.col11 = new System.Windows.Forms.Label();
            this.col10 = new System.Windows.Forms.Label();
            this.col15 = new System.Windows.Forms.Label();
            this.col14 = new System.Windows.Forms.Label();
            this.col13 = new System.Windows.Forms.Label();
            this.row13 = new System.Windows.Forms.Label();
            this.row14 = new System.Windows.Forms.Label();
            this.row15 = new System.Windows.Forms.Label();
            this.row12 = new System.Windows.Forms.Label();
            this.row11 = new System.Windows.Forms.Label();
            this.row10 = new System.Windows.Forms.Label();
            this.row7 = new System.Windows.Forms.Label();
            this.row8 = new System.Windows.Forms.Label();
            this.row9 = new System.Windows.Forms.Label();
            this.row3 = new System.Windows.Forms.Label();
            this.row4 = new System.Windows.Forms.Label();
            this.row5 = new System.Windows.Forms.Label();
            this.row6 = new System.Windows.Forms.Label();
            this.row1 = new System.Windows.Forms.Label();
            this.row2 = new System.Windows.Forms.Label();
            this.row = new System.Windows.Forms.Label();
            this.playeyLbl = new System.Windows.Forms.Label();
            this.playersName = new System.Windows.Forms.TextBox();
            this.GameMenu = new System.Windows.Forms.Button();
            this.get_Maximum_Solution = new System.Windows.Forms.Button();
            this.t_time = new System.Windows.Forms.TextBox();
            this.s_time = new System.Windows.Forms.TextBox();
            this.lthreaded = new System.Windows.Forms.Label();
            this.lSequential = new System.Windows.Forms.Label();
            this.intro1 = new System.Windows.Forms.Label();
            this.intro2 = new System.Windows.Forms.Label();
            this.para1 = new System.Windows.Forms.Label();
            this.para2 = new System.Windows.Forms.Label();
            this.para3 = new System.Windows.Forms.Label();
            this.para4 = new System.Windows.Forms.Label();
            this.instruction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.Black;
            this.RestartButton.FlatAppearance.BorderSize = 0;
            this.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RestartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RestartButton.Location = new System.Drawing.Point(577, 90);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(119, 23);
            this.RestartButton.TabIndex = 0;
            this.RestartButton.Text = "Reset";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(9, 136);
            this.positionTextBox.MaximumSize = new System.Drawing.Size(550, 20);
            this.positionTextBox.MinimumSize = new System.Drawing.Size(400, 20);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(550, 20);
            this.positionTextBox.TabIndex = 1;
            this.positionTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.positionTextBox_KeyDown);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Black;
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.submitButton.Location = new System.Drawing.Point(577, 134);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(119, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // chessboardPanel
            // 
            this.chessboardPanel.BackColor = System.Drawing.Color.Transparent;
            this.chessboardPanel.Location = new System.Drawing.Point(51, 192);
            this.chessboardPanel.Name = "chessboardPanel";
            this.chessboardPanel.Size = new System.Drawing.Size(480, 480);
            this.chessboardPanel.TabIndex = 3;
            this.chessboardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.chessboardPanel_Paint);
            this.chessboardPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chessboardPanel_MouseClick);
            // 
            // Solutionlbl
            // 
            this.Solutionlbl.AutoSize = true;
            this.Solutionlbl.BackColor = System.Drawing.Color.Transparent;
            this.Solutionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Solutionlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Solutionlbl.Location = new System.Drawing.Point(6, 120);
            this.Solutionlbl.Name = "Solutionlbl";
            this.Solutionlbl.Size = new System.Drawing.Size(53, 13);
            this.Solutionlbl.TabIndex = 4;
            this.Solutionlbl.Text = "Solution";
            // 
            // col
            // 
            this.col.BackColor = System.Drawing.Color.Transparent;
            this.col.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.col.Location = new System.Drawing.Point(51, 169);
            this.col.Margin = new System.Windows.Forms.Padding(0);
            this.col.Name = "col";
            this.col.Size = new System.Drawing.Size(30, 20);
            this.col.TabIndex = 5;
            this.col.Text = "0";
            this.col.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // col2
            // 
            this.col2.BackColor = System.Drawing.Color.Transparent;
            this.col2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.col2.Location = new System.Drawing.Point(112, 169);
            this.col2.Margin = new System.Windows.Forms.Padding(0);
            this.col2.Name = "col2";
            this.col2.Size = new System.Drawing.Size(30, 20);
            this.col2.TabIndex = 6;
            this.col2.Text = "2";
            this.col2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // col1
            // 
            this.col1.BackColor = System.Drawing.Color.Transparent;
            this.col1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.col1.Location = new System.Drawing.Point(82, 169);
            this.col1.Margin = new System.Windows.Forms.Padding(0);
            this.col1.Name = "col1";
            this.col1.Size = new System.Drawing.Size(30, 20);
            this.col1.TabIndex = 7;
            this.col1.Text = "1";
            this.col1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // col6
            // 
            this.col6.BackColor = System.Drawing.Color.Transparent;
            this.col6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.col6.Location = new System.Drawing.Point(232, 169);
            this.col6.Margin = new System.Windows.Forms.Padding(0);
            this.col6.Name = "col6";
            this.col6.Size = new System.Drawing.Size(30, 20);
            this.col6.TabIndex = 8;
            this.col6.Text = "6";
            this.col6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // col5
            // 
            this.col5.BackColor = System.Drawing.Color.Transparent;
            this.col5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.col5.Location = new System.Drawing.Point(202, 169);
            this.col5.Margin = new System.Windows.Forms.Padding(0);
            this.col5.Name = "col5";
            this.col5.Size = new System.Drawing.Size(30, 20);
            this.col5.TabIndex = 9;
            this.col5.Text = "5";
            this.col5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // col4
            // 
            this.col4.BackColor = System.Drawing.Color.Transparent;
            this.col4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.col4.Location = new System.Drawing.Point(172, 169);
            this.col4.Margin = new System.Windows.Forms.Padding(0);
            this.col4.Name = "col4";
            this.col4.Size = new System.Drawing.Size(30, 20);
            this.col4.TabIndex = 10;
            this.col4.Text = "4";
            this.col4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // col3
            // 
            this.col3.BackColor = System.Drawing.Color.Transparent;
            this.col3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.col3.Location = new System.Drawing.Point(142, 169);
            this.col3.Margin = new System.Windows.Forms.Padding(0);
            this.col3.Name = "col3";
            this.col3.Size = new System.Drawing.Size(30, 20);
            this.col3.TabIndex = 11;
            this.col3.Text = "3";
            this.col3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // col9
            // 
            this.col9.BackColor = System.Drawing.Color.Transparent;
            this.col9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.col9.Location = new System.Drawing.Point(322, 169);
            this.col9.Margin = new System.Windows.Forms.Padding(0);
            this.col9.Name = "col9";
            this.col9.Size = new System.Drawing.Size(30, 20);
            this.col9.TabIndex = 12;
            this.col9.Text = "9";
            this.col9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // col8
            // 
            this.col8.BackColor = System.Drawing.Color.Transparent;
            this.col8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.col8.Location = new System.Drawing.Point(292, 169);
            this.col8.Margin = new System.Windows.Forms.Padding(0);
            this.col8.Name = "col8";
            this.col8.Size = new System.Drawing.Size(30, 20);
            this.col8.TabIndex = 13;
            this.col8.Text = "8";
            this.col8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // col7
            // 
            this.col7.BackColor = System.Drawing.Color.Transparent;
            this.col7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.col7.Location = new System.Drawing.Point(262, 169);
            this.col7.Margin = new System.Windows.Forms.Padding(0);
            this.col7.Name = "col7";
            this.col7.Size = new System.Drawing.Size(30, 20);
            this.col7.TabIndex = 14;
            this.col7.Text = "7";
            this.col7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // col12
            // 
            this.col12.BackColor = System.Drawing.Color.Transparent;
            this.col12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.col12.Location = new System.Drawing.Point(412, 169);
            this.col12.Margin = new System.Windows.Forms.Padding(0);
            this.col12.Name = "col12";
            this.col12.Size = new System.Drawing.Size(30, 20);
            this.col12.TabIndex = 10;
            this.col12.Text = "12";
            this.col12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // col11
            // 
            this.col11.BackColor = System.Drawing.Color.Transparent;
            this.col11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.col11.Location = new System.Drawing.Point(382, 169);
            this.col11.Margin = new System.Windows.Forms.Padding(0);
            this.col11.Name = "col11";
            this.col11.Size = new System.Drawing.Size(30, 20);
            this.col11.TabIndex = 11;
            this.col11.Text = "11";
            this.col11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // col10
            // 
            this.col10.BackColor = System.Drawing.Color.Transparent;
            this.col10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.col10.Location = new System.Drawing.Point(352, 169);
            this.col10.Margin = new System.Windows.Forms.Padding(0);
            this.col10.Name = "col10";
            this.col10.Size = new System.Drawing.Size(30, 20);
            this.col10.TabIndex = 12;
            this.col10.Text = "10";
            this.col10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // col15
            // 
            this.col15.BackColor = System.Drawing.Color.Transparent;
            this.col15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.col15.Location = new System.Drawing.Point(502, 169);
            this.col15.Margin = new System.Windows.Forms.Padding(0);
            this.col15.Name = "col15";
            this.col15.Size = new System.Drawing.Size(30, 20);
            this.col15.TabIndex = 15;
            this.col15.Text = "15";
            this.col15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // col14
            // 
            this.col14.BackColor = System.Drawing.Color.Transparent;
            this.col14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.col14.Location = new System.Drawing.Point(472, 169);
            this.col14.Margin = new System.Windows.Forms.Padding(0);
            this.col14.Name = "col14";
            this.col14.Size = new System.Drawing.Size(30, 20);
            this.col14.TabIndex = 16;
            this.col14.Text = "14";
            this.col14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // col13
            // 
            this.col13.BackColor = System.Drawing.Color.Transparent;
            this.col13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.col13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.col13.Location = new System.Drawing.Point(442, 169);
            this.col13.Margin = new System.Windows.Forms.Padding(0);
            this.col13.Name = "col13";
            this.col13.Size = new System.Drawing.Size(30, 20);
            this.col13.TabIndex = 17;
            this.col13.Text = "13";
            this.col13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // row13
            // 
            this.row13.BackColor = System.Drawing.Color.Transparent;
            this.row13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row13.ForeColor = System.Drawing.SystemColors.Control;
            this.row13.Location = new System.Drawing.Point(19, 582);
            this.row13.Margin = new System.Windows.Forms.Padding(0);
            this.row13.Name = "row13";
            this.row13.Size = new System.Drawing.Size(30, 30);
            this.row13.TabIndex = 33;
            this.row13.Text = "13";
            this.row13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // row14
            // 
            this.row14.BackColor = System.Drawing.Color.Transparent;
            this.row14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row14.ForeColor = System.Drawing.SystemColors.Control;
            this.row14.Location = new System.Drawing.Point(19, 612);
            this.row14.Margin = new System.Windows.Forms.Padding(0);
            this.row14.Name = "row14";
            this.row14.Size = new System.Drawing.Size(30, 30);
            this.row14.TabIndex = 32;
            this.row14.Text = "14";
            this.row14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // row15
            // 
            this.row15.BackColor = System.Drawing.Color.Transparent;
            this.row15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row15.ForeColor = System.Drawing.SystemColors.Control;
            this.row15.Location = new System.Drawing.Point(19, 642);
            this.row15.Margin = new System.Windows.Forms.Padding(0);
            this.row15.Name = "row15";
            this.row15.Size = new System.Drawing.Size(30, 30);
            this.row15.TabIndex = 31;
            this.row15.Text = "15";
            this.row15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // row12
            // 
            this.row12.BackColor = System.Drawing.Color.Transparent;
            this.row12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row12.ForeColor = System.Drawing.SystemColors.Control;
            this.row12.Location = new System.Drawing.Point(19, 552);
            this.row12.Margin = new System.Windows.Forms.Padding(0);
            this.row12.Name = "row12";
            this.row12.Size = new System.Drawing.Size(30, 30);
            this.row12.TabIndex = 23;
            this.row12.Text = "12";
            this.row12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // row11
            // 
            this.row11.BackColor = System.Drawing.Color.Transparent;
            this.row11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row11.ForeColor = System.Drawing.SystemColors.Control;
            this.row11.Location = new System.Drawing.Point(19, 522);
            this.row11.Margin = new System.Windows.Forms.Padding(0);
            this.row11.Name = "row11";
            this.row11.Size = new System.Drawing.Size(30, 30);
            this.row11.TabIndex = 25;
            this.row11.Text = "11";
            this.row11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // row10
            // 
            this.row10.BackColor = System.Drawing.Color.Transparent;
            this.row10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row10.ForeColor = System.Drawing.SystemColors.Control;
            this.row10.Location = new System.Drawing.Point(19, 492);
            this.row10.Margin = new System.Windows.Forms.Padding(0);
            this.row10.Name = "row10";
            this.row10.Size = new System.Drawing.Size(30, 30);
            this.row10.TabIndex = 27;
            this.row10.Text = "10";
            this.row10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // row7
            // 
            this.row7.BackColor = System.Drawing.Color.Transparent;
            this.row7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row7.ForeColor = System.Drawing.SystemColors.Control;
            this.row7.Location = new System.Drawing.Point(19, 402);
            this.row7.Margin = new System.Windows.Forms.Padding(0);
            this.row7.Name = "row7";
            this.row7.Size = new System.Drawing.Size(30, 30);
            this.row7.TabIndex = 30;
            this.row7.Text = "7";
            this.row7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // row8
            // 
            this.row8.BackColor = System.Drawing.Color.Transparent;
            this.row8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row8.ForeColor = System.Drawing.SystemColors.Control;
            this.row8.Location = new System.Drawing.Point(19, 432);
            this.row8.Margin = new System.Windows.Forms.Padding(0);
            this.row8.Name = "row8";
            this.row8.Size = new System.Drawing.Size(30, 30);
            this.row8.TabIndex = 29;
            this.row8.Text = "8";
            this.row8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // row9
            // 
            this.row9.BackColor = System.Drawing.Color.Transparent;
            this.row9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row9.ForeColor = System.Drawing.SystemColors.Control;
            this.row9.Location = new System.Drawing.Point(19, 462);
            this.row9.Margin = new System.Windows.Forms.Padding(0);
            this.row9.Name = "row9";
            this.row9.Size = new System.Drawing.Size(30, 30);
            this.row9.TabIndex = 28;
            this.row9.Text = "9";
            this.row9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // row3
            // 
            this.row3.BackColor = System.Drawing.Color.Transparent;
            this.row3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row3.ForeColor = System.Drawing.SystemColors.Control;
            this.row3.Location = new System.Drawing.Point(19, 282);
            this.row3.Margin = new System.Windows.Forms.Padding(0);
            this.row3.Name = "row3";
            this.row3.Size = new System.Drawing.Size(30, 30);
            this.row3.TabIndex = 26;
            this.row3.Text = "3";
            this.row3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // row4
            // 
            this.row4.BackColor = System.Drawing.Color.Transparent;
            this.row4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row4.ForeColor = System.Drawing.SystemColors.Control;
            this.row4.Location = new System.Drawing.Point(19, 312);
            this.row4.Margin = new System.Windows.Forms.Padding(0);
            this.row4.Name = "row4";
            this.row4.Size = new System.Drawing.Size(30, 30);
            this.row4.TabIndex = 24;
            this.row4.Text = "4";
            this.row4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // row5
            // 
            this.row5.BackColor = System.Drawing.Color.Transparent;
            this.row5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row5.ForeColor = System.Drawing.SystemColors.Control;
            this.row5.Location = new System.Drawing.Point(19, 342);
            this.row5.Margin = new System.Windows.Forms.Padding(0);
            this.row5.Name = "row5";
            this.row5.Size = new System.Drawing.Size(30, 30);
            this.row5.TabIndex = 22;
            this.row5.Text = "5";
            this.row5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // row6
            // 
            this.row6.BackColor = System.Drawing.Color.Transparent;
            this.row6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row6.ForeColor = System.Drawing.SystemColors.Control;
            this.row6.Location = new System.Drawing.Point(19, 372);
            this.row6.Margin = new System.Windows.Forms.Padding(0);
            this.row6.Name = "row6";
            this.row6.Size = new System.Drawing.Size(30, 30);
            this.row6.TabIndex = 21;
            this.row6.Text = "6";
            this.row6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // row1
            // 
            this.row1.BackColor = System.Drawing.Color.Transparent;
            this.row1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row1.ForeColor = System.Drawing.SystemColors.Control;
            this.row1.Location = new System.Drawing.Point(19, 222);
            this.row1.Margin = new System.Windows.Forms.Padding(0);
            this.row1.Name = "row1";
            this.row1.Size = new System.Drawing.Size(30, 30);
            this.row1.TabIndex = 20;
            this.row1.Text = "1";
            this.row1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // row2
            // 
            this.row2.BackColor = System.Drawing.Color.Transparent;
            this.row2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row2.ForeColor = System.Drawing.SystemColors.Control;
            this.row2.Location = new System.Drawing.Point(19, 252);
            this.row2.Margin = new System.Windows.Forms.Padding(0);
            this.row2.Name = "row2";
            this.row2.Size = new System.Drawing.Size(30, 30);
            this.row2.TabIndex = 19;
            this.row2.Text = "2";
            this.row2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // row
            // 
            this.row.BackColor = System.Drawing.Color.Transparent;
            this.row.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row.ForeColor = System.Drawing.SystemColors.Control;
            this.row.Location = new System.Drawing.Point(19, 192);
            this.row.Margin = new System.Windows.Forms.Padding(0);
            this.row.Name = "row";
            this.row.Size = new System.Drawing.Size(30, 30);
            this.row.TabIndex = 18;
            this.row.Text = "0";
            this.row.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playeyLbl
            // 
            this.playeyLbl.AutoSize = true;
            this.playeyLbl.BackColor = System.Drawing.Color.Transparent;
            this.playeyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playeyLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playeyLbl.Location = new System.Drawing.Point(6, 72);
            this.playeyLbl.Name = "playeyLbl";
            this.playeyLbl.Size = new System.Drawing.Size(78, 13);
            this.playeyLbl.TabIndex = 34;
            this.playeyLbl.Text = "Player Name";
            // 
            // playersName
            // 
            this.playersName.Location = new System.Drawing.Point(9, 92);
            this.playersName.Name = "playersName";
            this.playersName.Size = new System.Drawing.Size(283, 20);
            this.playersName.TabIndex = 35;
            // 
            // GameMenu
            // 
            this.GameMenu.BackColor = System.Drawing.Color.Black;
            this.GameMenu.FlatAppearance.BorderSize = 0;
            this.GameMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GameMenu.Location = new System.Drawing.Point(699, 12);
            this.GameMenu.Name = "GameMenu";
            this.GameMenu.Size = new System.Drawing.Size(123, 40);
            this.GameMenu.TabIndex = 36;
            this.GameMenu.Text = "Game Menu";
            this.GameMenu.UseVisualStyleBackColor = false;
            this.GameMenu.Click += new System.EventHandler(this.gamemenu_Click);
            // 
            // get_Maximum_Solution
            // 
            this.get_Maximum_Solution.BackColor = System.Drawing.Color.Black;
            this.get_Maximum_Solution.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.get_Maximum_Solution.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get_Maximum_Solution.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.get_Maximum_Solution.Location = new System.Drawing.Point(542, 522);
            this.get_Maximum_Solution.Name = "get_Maximum_Solution";
            this.get_Maximum_Solution.Size = new System.Drawing.Size(171, 45);
            this.get_Maximum_Solution.TabIndex = 41;
            this.get_Maximum_Solution.Text = "Get Maximum Solutions";
            this.get_Maximum_Solution.UseVisualStyleBackColor = false;
            // 
            // t_time
            // 
            this.t_time.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.t_time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.t_time.Location = new System.Drawing.Point(643, 615);
            this.t_time.Name = "t_time";
            this.t_time.Size = new System.Drawing.Size(70, 20);
            this.t_time.TabIndex = 40;
            this.t_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // s_time
            // 
            this.s_time.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.s_time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.s_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.s_time.Location = new System.Drawing.Point(643, 582);
            this.s_time.Name = "s_time";
            this.s_time.Size = new System.Drawing.Size(70, 20);
            this.s_time.TabIndex = 39;
            this.s_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lthreaded
            // 
            this.lthreaded.AutoSize = true;
            this.lthreaded.BackColor = System.Drawing.Color.Transparent;
            this.lthreaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lthreaded.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lthreaded.Location = new System.Drawing.Point(539, 618);
            this.lthreaded.Name = "lthreaded";
            this.lthreaded.Size = new System.Drawing.Size(92, 13);
            this.lthreaded.TabIndex = 38;
            this.lthreaded.Text = "Threaded Time";
            // 
            // lSequential
            // 
            this.lSequential.AutoSize = true;
            this.lSequential.BackColor = System.Drawing.Color.Transparent;
            this.lSequential.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSequential.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lSequential.Location = new System.Drawing.Point(539, 582);
            this.lSequential.Name = "lSequential";
            this.lSequential.Size = new System.Drawing.Size(98, 13);
            this.lSequential.TabIndex = 37;
            this.lSequential.Text = "Sequential Time";
            // 
            // intro1
            // 
            this.intro1.AutoSize = true;
            this.intro1.BackColor = System.Drawing.Color.Transparent;
            this.intro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intro1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.intro1.Location = new System.Drawing.Point(12, 24);
            this.intro1.Name = "intro1";
            this.intro1.Size = new System.Drawing.Size(684, 17);
            this.intro1.TabIndex = 44;
            this.intro1.Text = "The 8 Queens Puzzle is over 170 years old, where you\'ll see that the 16 Queens Pu" +
    "zzle has over 14 million\r\n";
            // 
            // intro2
            // 
            this.intro2.AutoSize = true;
            this.intro2.BackColor = System.Drawing.Color.Transparent;
            this.intro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intro2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.intro2.Location = new System.Drawing.Point(12, 41);
            this.intro2.Name = "intro2";
            this.intro2.Size = new System.Drawing.Size(270, 17);
            this.intro2.TabIndex = 45;
            this.intro2.Text = "possible answers (but can you find one?!)";
            // 
            // para1
            // 
            this.para1.AutoSize = true;
            this.para1.BackColor = System.Drawing.Color.Transparent;
            this.para1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.para1.Location = new System.Drawing.Point(539, 351);
            this.para1.Name = "para1";
            this.para1.Size = new System.Drawing.Size(283, 13);
            this.para1.TabIndex = 47;
            this.para1.Text = "The objective is to place all 16 queens on the chessboard ";
            // 
            // para2
            // 
            this.para2.AutoSize = true;
            this.para2.BackColor = System.Drawing.Color.Transparent;
            this.para2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.para2.Location = new System.Drawing.Point(539, 364);
            this.para2.Name = "para2";
            this.para2.Size = new System.Drawing.Size(259, 13);
            this.para2.TabIndex = 48;
            this.para2.Text = "without any queens being able to capture each other.";
            // 
            // para3
            // 
            this.para3.AutoSize = true;
            this.para3.BackColor = System.Drawing.Color.Transparent;
            this.para3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.para3.Location = new System.Drawing.Point(539, 407);
            this.para3.Name = "para3";
            this.para3.Size = new System.Drawing.Size(272, 13);
            this.para3.TabIndex = 49;
            this.para3.Text = "Remember, a queen can capture another piece if it is on";
            // 
            // para4
            // 
            this.para4.AutoSize = true;
            this.para4.BackColor = System.Drawing.Color.Transparent;
            this.para4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.para4.Location = new System.Drawing.Point(537, 420);
            this.para4.Name = "para4";
            this.para4.Size = new System.Drawing.Size(279, 13);
            this.para4.TabIndex = 50;
            this.para4.Text = " the same row, column, vertically, horizontally, or diagonal.";
            // 
            // instruction
            // 
            this.instruction.AutoSize = true;
            this.instruction.BackColor = System.Drawing.Color.Transparent;
            this.instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.instruction.Location = new System.Drawing.Point(539, 321);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(148, 13);
            this.instruction.TabIndex = 51;
            this.instruction.Text = "INSTRUCTION TO PLAY";
            // 
            // SixteenQueen_Puzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::PDSA2Coursework_Team1.Properties.Resources.bgimge;
            this.ClientSize = new System.Drawing.Size(834, 697);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.para4);
            this.Controls.Add(this.para3);
            this.Controls.Add(this.para2);
            this.Controls.Add(this.para1);
            this.Controls.Add(this.intro2);
            this.Controls.Add(this.intro1);
            this.Controls.Add(this.get_Maximum_Solution);
            this.Controls.Add(this.t_time);
            this.Controls.Add(this.s_time);
            this.Controls.Add(this.lthreaded);
            this.Controls.Add(this.lSequential);
            this.Controls.Add(this.GameMenu);
            this.Controls.Add(this.playersName);
            this.Controls.Add(this.playeyLbl);
            this.Controls.Add(this.row15);
            this.Controls.Add(this.row14);
            this.Controls.Add(this.row13);
            this.Controls.Add(this.row12);
            this.Controls.Add(this.row11);
            this.Controls.Add(this.row10);
            this.Controls.Add(this.row9);
            this.Controls.Add(this.row8);
            this.Controls.Add(this.row7);
            this.Controls.Add(this.row6);
            this.Controls.Add(this.row5);
            this.Controls.Add(this.row4);
            this.Controls.Add(this.row3);
            this.Controls.Add(this.row2);
            this.Controls.Add(this.row1);
            this.Controls.Add(this.row);
            this.Controls.Add(this.col15);
            this.Controls.Add(this.col14);
            this.Controls.Add(this.col13);
            this.Controls.Add(this.col12);
            this.Controls.Add(this.col11);
            this.Controls.Add(this.col10);
            this.Controls.Add(this.col9);
            this.Controls.Add(this.col8);
            this.Controls.Add(this.col7);
            this.Controls.Add(this.col6);
            this.Controls.Add(this.col5);
            this.Controls.Add(this.col4);
            this.Controls.Add(this.col3);
            this.Controls.Add(this.col1);
            this.Controls.Add(this.col2);
            this.Controls.Add(this.col);
            this.Controls.Add(this.Solutionlbl);
            this.Controls.Add(this.chessboardPanel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.RestartButton);
            this.Name = "SixteenQueen_Puzzle";
            this.Text = "Sixteen Queens Puzzle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label Solutionlbl;
        private System.Windows.Forms.Label col;
        private System.Windows.Forms.Label col1;
        private System.Windows.Forms.Label col2;
        private System.Windows.Forms.Label col3;
        private System.Windows.Forms.Label col4;
        private System.Windows.Forms.Label col5;
        private System.Windows.Forms.Label col6;
        private System.Windows.Forms.Label col7;
        private System.Windows.Forms.Label col8;
        private System.Windows.Forms.Label col9;
        private System.Windows.Forms.Label col10;
        private System.Windows.Forms.Label col11;
        private System.Windows.Forms.Label col12;
        private System.Windows.Forms.Label col13;
        private System.Windows.Forms.Label col14;
        private System.Windows.Forms.Label col15;
        private System.Windows.Forms.Label row15;
        private System.Windows.Forms.Label row14;
        private System.Windows.Forms.Label row13;
        private System.Windows.Forms.Label row12;
        private System.Windows.Forms.Label row11;
        private System.Windows.Forms.Label row10;
        private System.Windows.Forms.Label row9;
        private System.Windows.Forms.Label row8;
        private System.Windows.Forms.Label row7;
        private System.Windows.Forms.Label row6;
        private System.Windows.Forms.Label row5;
        private System.Windows.Forms.Label row4;
        private System.Windows.Forms.Label row3;
        private System.Windows.Forms.Label row2;
        private System.Windows.Forms.Label row1;
        private System.Windows.Forms.Label row;
        private System.Windows.Forms.Label playeyLbl;
        private System.Windows.Forms.TextBox playersName;
        private System.Windows.Forms.Button GameMenu;
        private System.Windows.Forms.Button get_Maximum_Solution;
        private System.Windows.Forms.TextBox t_time;
        private System.Windows.Forms.TextBox s_time;
        private System.Windows.Forms.Label lthreaded;
        private System.Windows.Forms.Label lSequential;
        private System.Windows.Forms.Label intro1;
        private System.Windows.Forms.Label intro2;
        private System.Windows.Forms.Label para1;
        private System.Windows.Forms.Label para2;
        private System.Windows.Forms.Label para3;
        private System.Windows.Forms.Label para4;
        private System.Windows.Forms.Label instruction;
    }
}