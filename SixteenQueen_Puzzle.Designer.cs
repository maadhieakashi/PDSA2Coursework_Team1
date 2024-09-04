﻿namespace PDSA2Coursework_Team1
{
    partial class SixteenQueen_Puzzle
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "SixteenQueen_Puzzle";

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
    ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscs)).BeginInit();
    this.SuspendLayout();
    // 
    // numericUpDownDiscs
    // 
    this.numericUpDownDiscs.Location = new System.Drawing.Point(180, 20);
    this.numericUpDownDiscs.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
    this.numericUpDownDiscs.Name = "numericUpDownDiscs";
    this.numericUpDownDiscs.Size = new System.Drawing.Size(50, 20);
    this.numericUpDownDiscs.TabIndex = 0;
    this.numericUpDownDiscs.Value = new decimal(new int[] { 1, 0, 0, 0 });
    // 
    // textBoxMoveInput
    // 
    this.textBoxMoveInput.Location = new System.Drawing.Point(180, 57);
    this.textBoxMoveInput.Name = "textBoxMoveInput";
    this.textBoxMoveInput.Size = new System.Drawing.Size(200, 20);
    this.textBoxMoveInput.TabIndex = 1;
    // 
    // buttonStart
    // 
    this.buttonStart.Location = new System.Drawing.Point(180, 100);
    this.buttonStart.Name = "buttonStart";
    this.buttonStart.Size = new System.Drawing.Size(80, 23);
    this.buttonStart.TabIndex = 2;
    this.buttonStart.Text = "Start";
    this.buttonStart.UseVisualStyleBackColor = true;
    // 
    // buttonReset
    // 
    this.buttonReset.Location = new System.Drawing.Point(300, 100);
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
    this.labelMoveInput.Size = new System.Drawing.Size(121, 13);
    this.labelMoveInput.TabIndex = 5;
    this.labelMoveInput.Text = "Enter Move (e.g., A->C):";
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
    this.textBoxPlayerName.Location = new System.Drawing.Point(180, 158);
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
    this.labelPlayerName.Text = "Player's Name:";
    // 
    // labelInstructions
    // 
    this.labelInstructions.AutoSize = true;
    this.labelInstructions.Location = new System.Drawing.Point(30, 190);
    this.labelInstructions.Name = "labelInstructions";
    this.labelInstructions.Size = new System.Drawing.Size(263, 13);
    this.labelInstructions.TabIndex = 9;
    this.labelInstructions.Text = "Instructions: Move disks using format A->B (e.g., A->C).";
    // 
    // Form1
    // 
    this.ClientSize = new System.Drawing.Size(400, 220);
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
    this.Name = "Form1";
    ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscs)).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
}

        }

        #endregion
    }
}