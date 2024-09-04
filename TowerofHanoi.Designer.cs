namespace PDSA2Coursework_Team1
{
    partial class TowerofHanoi
    {
        private System.Windows.Forms.NumericUpDown numericUpDownDiscs;
        private System.Windows.Forms.TextBox textBoxMoveInput;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelDiscs;
        private System.Windows.Forms.Label labelMoveInput;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Label labelInstructions;

        private void InitializeComponent()
        {
            this.numericUpDownDiscs = new System.Windows.Forms.NumericUpDown();
            this.textBoxMoveInput = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelDiscs = new System.Windows.Forms.Label();
            this.labelMoveInput = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.gamemenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscs)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownDiscs
            // 
            this.numericUpDownDiscs.Location = new System.Drawing.Point(150, 20);
            this.numericUpDownDiscs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDiscs.Name = "numericUpDownDiscs";
            this.numericUpDownDiscs.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownDiscs.TabIndex = 0;
            this.numericUpDownDiscs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxMoveInput
            // 
            this.textBoxMoveInput.Location = new System.Drawing.Point(150, 58);
            this.textBoxMoveInput.Name = "textBoxMoveInput";
            this.textBoxMoveInput.Size = new System.Drawing.Size(200, 20);
            this.textBoxMoveInput.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(150, 100);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(80, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(250, 100);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(80, 23);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // labelDiscs
            // 
            this.labelDiscs.AutoSize = true;
            this.labelDiscs.Location = new System.Drawing.Point(30, 22);
            this.labelDiscs.Name = "labelDiscs";
            this.labelDiscs.Size = new System.Drawing.Size(88, 13);
            this.labelDiscs.TabIndex = 4;
            this.labelDiscs.Text = "Number of Discs:";
            // 
            // labelMoveInput
            // 
            this.labelMoveInput.AutoSize = true;
            this.labelMoveInput.Location = new System.Drawing.Point(30, 60);
            this.labelMoveInput.Name = "labelMoveInput";
            this.labelMoveInput.Size = new System.Drawing.Size(127, 13);
            this.labelMoveInput.TabIndex = 5;
            this.labelMoveInput.Text = "Enter Move (e.g., A to C):";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(30, 140);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 13);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "Status:";
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(150, 162);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(200, 20);
            this.textBoxPlayerName.TabIndex = 7;
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Location = new System.Drawing.Point(30, 165);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(77, 13);
            this.labelPlayerName.TabIndex = 8;
            this.labelPlayerName.Text = "Player\'s Name:";
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Location = new System.Drawing.Point(30, 190);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(239, 13);
            this.labelInstructions.TabIndex = 9;
            this.labelInstructions.Text = "Instructions: Use the format A to C to move discs.";
            // 
            // gamemenu
            // 
            this.gamemenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gamemenu.FlatAppearance.BorderSize = 0;
            this.gamemenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gamemenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamemenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gamemenu.Location = new System.Drawing.Point(265, 17);
            this.gamemenu.Name = "gamemenu";
            this.gamemenu.Size = new System.Drawing.Size(123, 23);
            this.gamemenu.TabIndex = 37;
            this.gamemenu.Text = "Game Menu";
            this.gamemenu.UseVisualStyleBackColor = false;
            this.gamemenu.Click += new System.EventHandler(this.gamemenu_Click);
            // 
            // TowerofHanoi
            // 
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.gamemenu);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelMoveInput);
            this.Controls.Add(this.labelDiscs);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxMoveInput);
            this.Controls.Add(this.numericUpDownDiscs);
            this.Name = "TowerofHanoi";
            this.Text = "Tower of Hanoi Game";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button gamemenu;
    }
}