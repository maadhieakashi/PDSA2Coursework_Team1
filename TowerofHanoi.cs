using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PDSA2Coursework_Team1
{
    public partial class TowerofHanoi : Form
    {
        private Stack<int> rodA;
        private Stack<int> rodB;
        private Stack<int> rodC;
        private int totalDiscs;
        private int moveCount;
        private Stopwatch stopwatch;

        public TowerofHanoi()
        {
            InitializeComponent();
            buttonStart.Click += buttonStart_Click;
            buttonReset.Click += buttonReset_Click;
            textBoxMoveInput.KeyPress += textBoxMoveInput_KeyPress;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Validate Player Name
            if (string.IsNullOrWhiteSpace(textBoxPlayerName.Text))
            {
                MessageBox.Show("Please enter your name.");
                return;
            }

            // Validate Number of Discs
            if (numericUpDownDiscs.Value <= 0)
            {
                MessageBox.Show("Please enter a valid number of discs.");
                return;
            }

            // Validate Number of Moves
            int numMoves;
            if (!int.TryParse(textBoxNumberOfMoves.Text, out numMoves) || numMoves < 1)
            {
                MessageBox.Show("Please enter a valid number of moves.");
                return;
            }

            InitializeGame();
            stopwatch = Stopwatch.StartNew();
        }

        private void InitializeGame()
        {
            totalDiscs = (int)numericUpDownDiscs.Value;
            moveCount = 0;
            rodA = new Stack<int>();
            rodB = new Stack<int>();
            rodC = new Stack<int>();

            for (int i = totalDiscs; i > 0; i--)
            {
                rodA.Push(i);
            }

            UpdateRodsDisplay();
            labelStatus.Text = "Game Started!";
            labelMoveCount.Text = $"Number of Moves: {moveCount}";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            stopwatch.Reset();
            labelStatus.Text = "Game Reset!";
            labelMoveCount.Text = "Number of Moves: 0";
            textBoxMoveInput.Clear();
            textBoxPlayerName.Clear();
            numericUpDownDiscs.Value = 0;
            textBoxNumberOfMoves.Clear();
            InitializeGame();
        }

        private void textBoxMoveInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                ProcessMove();
            }
        }

        private void ProcessMove()
        {
            string move = textBoxMoveInput.Text.Trim().ToUpper();
            if (string.IsNullOrEmpty(move) || move.Length != 2)
            {
                MessageBox.Show("Please enter a valid move (e.g., AB).");
                return;
            }

            char fromRod = move[0];
            char toRod = move[1];

            if (!IsValidMove(fromRod, toRod))
            {
                MessageBox.Show("Invalid move.");
                return;
            }

            MoveDisc(fromRod, toRod);
            moveCount++;
            labelMoveCount.Text = $"Number of Moves: {moveCount}";

            if (rodC.Count == totalDiscs)
            {
                stopwatch.Stop();
                labelStatus.Text = $"Game Over! Time Taken: {stopwatch.Elapsed.TotalSeconds:F2} seconds";
                SaveResult();
            }
            else
            {
                UpdateRodsDisplay();
            }
        }

        private bool IsValidMove(char fromRod, char toRod)
        {
            Stack<int> sourceStack = GetRodStack(fromRod);
            Stack<int> destinationStack = GetRodStack(toRod);

            if (sourceStack == null || destinationStack == null || sourceStack.Count == 0)
                return false;

            if (destinationStack.Count == 0 || sourceStack.Peek() < destinationStack.Peek())
                return true;

            return false;
        }

        private void MoveDisc(char fromRod, char toRod)
        {
            Stack<int> sourceStack = GetRodStack(fromRod);
            Stack<int> destinationStack = GetRodStack(toRod);

            if (sourceStack == null || destinationStack == null || sourceStack.Count == 0)
                return;

            int disc = sourceStack.Pop();
            destinationStack.Push(disc);
        }

        private Stack<int> GetRodStack(char rod)
        {
            switch (rod)
            {
                case 'A':
                    return rodA;
                case 'B':
                    return rodB;
                case 'C':
                    return rodC;
                default:
                    return null;
            }
        }

        private void UpdateRodsDisplay()
        {
            groupBoxRodA.Text = $"Rod A: {string.Join(", ", rodA)}";
            groupBoxRodB.Text = $"Rod B: {string.Join(", ", rodB)}";
            groupBoxRodC.Text = $"Rod C: {string.Join(", ", rodC)}";
        }

        private void SaveResult()
        {
            string playerName = textBoxPlayerName.Text;
            double elapsedTime = stopwatch.Elapsed.TotalSeconds;

            using (SqlConnection connection = new SqlConnection("server=localhost;port=3307;database=pdsa2cw;uid=root;pwd=1234;"))
            {
                connection.Open();
                string query = "INSERT towerofhanoi (PlayerName, Discs, Moves, TimeTaken) VALUES (@PlayerName, @Discs, @Moves, @TimeTaken)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PlayerName", playerName);
                    command.Parameters.AddWithValue("@Discs", totalDiscs);
                    command.Parameters.AddWithValue("@Moves", moveCount);
                    command.Parameters.AddWithValue("@TimeTaken", elapsedTime);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void GameMenu_btn_Click(object sender, EventArgs e)
        {
            GameMenu GameMenuForm = new GameMenu();
            GameMenuForm.Show();
            this.Hide();

        }

        private void TowerofHanoi_Load(object sender, EventArgs e)
        {

        }
    }
}