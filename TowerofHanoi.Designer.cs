namespace PDSA2Coursework_Team1
{
    partial class TowerofHanoi
    {
        private System.ComponentModel.IContainer components = null;

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
            this.numericUpDownDiscs = new System.Windows.Forms.NumericUpDown();
            this.textBoxNumberOfMoves = new System.Windows.Forms.TextBox();
            this.textBoxMoveInput = new System.Windows.Forms.TextBox();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelMoveCount = new System.Windows.Forms.Label();
            this.groupBoxRodA = new System.Windows.Forms.GroupBox();
            this.groupBoxRodB = new System.Windows.Forms.GroupBox();
            this.groupBoxRodC = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GameMenu_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscs)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownDiscs
            // 
            this.numericUpDownDiscs.Location = new System.Drawing.Point(200, 50);
            this.numericUpDownDiscs.Name = "numericUpDownDiscs";
            this.numericUpDownDiscs.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDiscs.TabIndex = 0;
            // 
            // textBoxNumberOfMoves
            // 
            this.textBoxNumberOfMoves.Location = new System.Drawing.Point(200, 90);
            this.textBoxNumberOfMoves.Name = "textBoxNumberOfMoves";
            this.textBoxNumberOfMoves.Size = new System.Drawing.Size(120, 20);
            this.textBoxNumberOfMoves.TabIndex = 1;
            // 
            // textBoxMoveInput
            // 
            this.textBoxMoveInput.Location = new System.Drawing.Point(200, 126);
            this.textBoxMoveInput.Name = "textBoxMoveInput";
            this.textBoxMoveInput.Size = new System.Drawing.Size(120, 20);
            this.textBoxMoveInput.TabIndex = 2;
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(200, 166);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(120, 20);
            this.textBoxPlayerName.TabIndex = 3;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(279, 276);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(109, 276);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 211);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "Status";
            // 
            // labelMoveCount
            // 
            this.labelMoveCount.AutoSize = true;
            this.labelMoveCount.Location = new System.Drawing.Point(12, 224);
            this.labelMoveCount.Name = "labelMoveCount";
            this.labelMoveCount.Size = new System.Drawing.Size(65, 13);
            this.labelMoveCount.TabIndex = 7;
            this.labelMoveCount.Text = "Move Count";
            // 
            // groupBoxRodA
            // 
            this.groupBoxRodA.Location = new System.Drawing.Point(428, 50);
            this.groupBoxRodA.Name = "groupBoxRodA";
            this.groupBoxRodA.Size = new System.Drawing.Size(120, 60);
            this.groupBoxRodA.TabIndex = 8;
            this.groupBoxRodA.TabStop = false;
            this.groupBoxRodA.Text = "Rod A";
            // 
            // groupBoxRodB
            // 
            this.groupBoxRodB.Location = new System.Drawing.Point(428, 126);
            this.groupBoxRodB.Name = "groupBoxRodB";
            this.groupBoxRodB.Size = new System.Drawing.Size(120, 60);
            this.groupBoxRodB.TabIndex = 9;
            this.groupBoxRodB.TabStop = false;
            this.groupBoxRodB.Text = "Rod B";
            // 
            // groupBoxRodC
            // 
            this.groupBoxRodC.Location = new System.Drawing.Point(428, 206);
            this.groupBoxRodC.Name = "groupBoxRodC";
            this.groupBoxRodC.Size = new System.Drawing.Size(120, 60);
            this.groupBoxRodC.TabIndex = 10;
            this.groupBoxRodC.TabStop = false;
            this.groupBoxRodC.Text = "Rod C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Number of Discs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Number of Moves";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sequence of Moves";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Player Name";
            // 
            // GameMenu_btn
            // 
            this.GameMenu_btn.Location = new System.Drawing.Point(428, 12);
            this.GameMenu_btn.Name = "GameMenu_btn";
            this.GameMenu_btn.Size = new System.Drawing.Size(119, 21);
            this.GameMenu_btn.TabIndex = 15;
            this.GameMenu_btn.Text = "Game Menu";
            this.GameMenu_btn.UseVisualStyleBackColor = true;
            this.GameMenu_btn.Click += new System.EventHandler(this.GameMenu_btn_Click);
            // 
            // TowerofHanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(583, 333);
            this.Controls.Add(this.GameMenu_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxRodC);
            this.Controls.Add(this.groupBoxRodB);
            this.Controls.Add(this.groupBoxRodA);
            this.Controls.Add(this.labelMoveCount);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.textBoxMoveInput);
            this.Controls.Add(this.textBoxNumberOfMoves);
            this.Controls.Add(this.numericUpDownDiscs);
            this.Name = "TowerofHanoi";
            this.Text = "Tower of Hanoi";
            this.Load += new System.EventHandler(this.TowerofHanoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.NumericUpDown numericUpDownDiscs;
        private System.Windows.Forms.TextBox textBoxNumberOfMoves;
        private System.Windows.Forms.TextBox textBoxMoveInput;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelMoveCount;
        private System.Windows.Forms.GroupBox groupBoxRodA;
        private System.Windows.Forms.GroupBox groupBoxRodB;
        private System.Windows.Forms.GroupBox groupBoxRodC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GameMenu_btn;
    }
}