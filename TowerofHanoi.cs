using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PDSA2Coursework_Team1
{
    public partial class TowerofHanoi : Form
    {
        private Stack<int> sourceRod;
        private Stack<int> auxiliaryRod;
        private Stack<int> destinationRod;
        private int totalDiscs;
        private Stopwatch stopwatch;

        public TowerofHanoi()
        {
            InitializeComponent();
            buttonStart.Click += new EventHandler(buttonStart_Click);
            buttonReset.Click += new EventHandler(buttonReset_Click);
            textBoxMoveInput.KeyPress += new KeyPressEventHandler(textBoxMoveInput_KeyPress);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPlayerName.Text))
            {
                MessageBox.Show("Please enter your name.");
                return;
            }

            totalDiscs = (int)numericUpDownDiscs.Value;
            InitializeRods();
            stopwatch = Stopwatch.StartNew();
            labelStatus.Text = "Enter your moves in the format A to C:";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            numericUpDownDiscs.Value = 1;
            textBoxMoveInput.Clear();
            textBoxPlayerName.Clear();
            labelStatus.Text = "Status:";
            InitializeRods();
        }

        private void InitializeRods()
        {
            sourceRod = new Stack<int>();
            auxiliaryRod = new Stack<int>();
            destinationRod = new Stack<int>();

            for (int i = totalDiscs; i >= 1; i--)
            {
                sourceRod.Push(i);
            }
        }

        private void ProcessMove(string move)
        {
            if (string.IsNullOrWhiteSpace(move) || move.Length != 7 || move[1] != ' ' || move[3] != ' ' ||
                move[2] != 't' || move[4] != 'o' || move[5] != ' ')
            {
                MessageBox.Show("Invalid move format. Use format A to C.");
                return;
            }

            char fromRod = move[0];
            char toRod = move[6];

            Stack<int> fromStack = GetStack(fromRod);
            Stack<int> toStack = GetStack(toRod);

            if (fromStack.Count == 0)
            {
                MessageBox.Show($"No discs on rod {fromRod} to move.");
                return;
            }

            int disc = fromStack.Pop();

            if (toStack.Count > 0 && toStack.Peek() < disc)
            {
                MessageBox.Show("Cannot place a larger disc on top of a smaller disc.");
                fromStack.Push(disc); // Return the disc to the original rod
                return;
            }

            toStack.Push(disc);

            if (IsPuzzleSolved())
            {
                stopwatch.Stop();
                TimeSpan duration = stopwatch.Elapsed;
                labelStatus.Text = "Puzzle solved!";
                MessageBox.Show("Congratulations! You've solved the puzzle.");
                SaveGameResult(textBoxPlayerName.Text, true, duration);
            }
            else
            {
                labelStatus.Text = "Move successful. Enter next move:";
            }
        }

        private Stack<int> GetStack(char rod)
        {
            return rod switch
            {
                'A' => sourceRod,
                'B' => auxiliaryRod,
                'C' => destinationRod,
                _ => throw new ArgumentException("Invalid rod identifier")
            };
        }

        private bool IsPuzzleSolved()
        {
            return destinationRod.Count == totalDiscs;
        }

        private void SaveGameResult(string playerName, bool isValid, TimeSpan duration)
        {
            // Save the game result to the database or a file
            MessageBox.Show($"Player: {playerName}\nResult: {(isValid ? "Correct" : "Incorrect")}\nDuration: {duration.TotalSeconds} seconds");
        }

        private void textBoxMoveInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ProcessMove(textBoxMoveInput.Text);
                textBoxMoveInput.Clear();
                e.Handled = true; // Prevents the beep sound on Enter key press
            }
        }
    }
}