using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace PDSA2Coursework_Team1
{
    public partial class SixteenQueen_Puzzle : Form
    {
        private const int BoardSize = 16;
        private const int SquareSize = 30;
        private Image queenImage;
        private bool[,] queens;
        private bool submitClicked;
        private DatabaseManager dbConnecter;

        public SixteenQueen_Puzzle()
        {
            InitializeComponent();


            // queenImage = Image.FromFile(@"C:\Users\akash\source\repos\SixteenQnns\SixteenQns\Resources\queen.png");
            queenImage = Properties.Resources.queen;
            queens = new bool[BoardSize, BoardSize];
            submitClicked = false;

            //database connection
            dbConnecter = new DatabaseManager();

            // Attach event handler for the Get Maximum Solution button
            get_Maximum_Solution.Click += Get_Maximum_Solution_Click;
        }

        // Restart the chessboard 
        private void restartButton_Click(object sender, EventArgs e)
        {
            ClearBoard();
            positionTextBox.Clear();
            playersName.Clear();
            submitClicked = false;
            chessboardPanel.Invalidate();
        }

        // Clear the board by resetting the queens array
        private void ClearBoard()
        {
            Array.Clear(queens, 0, queens.Length);
        }

        // Draw the chessboard and queens on the panel
        private void chessboardPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    // Draw squares in alternating colors
                    Rectangle rect = new Rectangle(j * SquareSize, i * SquareSize, SquareSize, SquareSize);
                    g.FillRectangle((i + j) % 2 == 0 ? Brushes.White : Brushes.Tan, rect);

                    // Draw a queen if present
                    if (queens[i, j])
                    {
                        g.DrawImage(queenImage, rect);
                    }
                }
            }
        }

        // Handle mouse clicks to place or remove queens
        private void chessboardPanel_MouseClick(object sender, MouseEventArgs e)
        {
            int column = e.X / SquareSize; // Calculate clicked column
            int row = e.Y / SquareSize;    // Calculate clicked row

            if (IsWithinBoard(column, row))
            {
                if (CanPlaceQueen(row, column))
                {
                    ToggleQueen(row, column);
                    chessboardPanel.Invalidate();
                    UpdatePositionTextBox();
                }
            }
        }

        // Check if the clicked position is within the board limits
        private bool IsWithinBoard(int column, int row)
        {
            return column < BoardSize && row < BoardSize;
        }

        // Check if a queen can be placed at the clicked position
        private bool CanPlaceQueen(int row, int column)
        {
            return CountQueens() < 16 || queens[row, column];
        }

        // Toggle the presence of a queen at a specific position
        private void ToggleQueen(int row, int column)
        {
            queens[row, column] = !queens[row, column];
        }

        // Update the position text box with the current queens' positions
        private void UpdatePositionTextBox()
        {
            var positions = new List<string>();
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    if (queens[i, j])
                    {
                        positions.Add($"{{{i},{j}}}");
                    }
                }
            }
            positionTextBox.Text = string.Join(",", positions);
        }

        // Handle manual input of positions via the text box
        private void positionTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ParseAndPlaceQueensFromTextBox();
                chessboardPanel.Invalidate();
            }
        }

        // Parse the input from the text box and place queens on the board
        private void ParseAndPlaceQueensFromTextBox()
        {
            var input = positionTextBox.Text.Split(new[] { ',', '}' }, StringSplitOptions.RemoveEmptyEntries);
            ClearBoard();

            for (int i = 0; i < input.Length; i += 2)
            {
                if (int.TryParse(input[i].Trim('{', ' '), out int row) &&
                    int.TryParse(input[i + 1].Trim(), out int column) &&
                    IsWithinBoard(column, row))
                {
                    queens[row, column] = true;
                }
            }
        }

        // Handle the submission of a solution
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (submitClicked)
            {
                MessageBox.Show("solution is correct. Try another!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (CountQueens() != 16)
            {
                MessageBox.Show("Please place exactly 16 queens on the board.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidSolution())
            {
                MessageBox.Show("Solution is incorrect. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            submitClicked = true;
            string solution = positionTextBox.Text;
            string playerName = playersName.Text;

            // Save solution to the database
            dbConnecter.InsertSolution(solution, playerName);

            MessageBox.Show("solution has already been recognized. Try another", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Count the number of queens currently on the board
        private int CountQueens()
        {
            int count = 0;
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    if (queens[i, j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        // Validate the solution by checking rows, columns, and diagonals
        private bool IsValidSolution()
        {
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    if (queens[i, j] && !IsSafe(i, j))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        // Check if a queen is safe at the given position
        private bool IsSafe(int row, int col)
        {
            for (int i = 0; i < BoardSize; i++)
            {
                if (i != row && (queens[i, col] || (col - row + i >= 0 && col - row + i < BoardSize && queens[i, col - row + i]) ||
                                 (col + row - i >= 0 && col + row - i < BoardSize && queens[i, col + row - i])))
                {
                    return false;
                }
            }
            return true;
        }

        // Handle the click event to find maximum solutions using both sequential and threaded methods

        private async void Get_Maximum_Solution_Click(object sender, EventArgs e)
        {
            // Clear previous results
            s_time.Text = "Calculating...";
            t_time.Text = "Calculating...";
            int NumberOfSolutions = 50;
            // Sequential Solution
            var sequentialStopwatch = Stopwatch.StartNew();
            var sequentialSolutions = FindSolutionsSequentially(NumberOfSolutions);
            sequentialStopwatch.Stop();
            s_time.Text = sequentialStopwatch.Elapsed.TotalSeconds.ToString("F2");

            // Save sequential solutions to database

            await DatabaseManager.SaveSequentialSolutionsToDatabaseAsync(sequentialSolutions);

            // Threaded Solution
            var threadedStopwatch = Stopwatch.StartNew();
            var threadedSolutions = await FindSolutionsThreadedAsync(NumberOfSolutions);
            threadedStopwatch.Stop();
            t_time.Text = threadedStopwatch.Elapsed.TotalSeconds.ToString("F2");

            // Save threaded solutions to database
            await DatabaseManager.SaveThreadedSolutionsToDatabaseAsync(threadedSolutions);
        }

        // Find solutions using a sequential algorithm
        private List<List<int>> FindSolutionsSequentially(int numberOfSolutions)
        {
            var solutions = new List<List<int>>();
            Solve(new int[BoardSize], 0, solutions, numberOfSolutions);
            return solutions;
        }

        // Recursive backtracking algorithm to solve the puzzle
        private void Solve(int[] board, int row, List<List<int>> solutions, int maxSolutions)
        {
            if (solutions.Count >= maxSolutions)
                return;

            if (row == BoardSize)
            {
                solutions.Add(board.ToList());
                return;
            }

            for (int col = 0; col < BoardSize; col++)
            {
                if (IsSafe(board, row, col))
                {
                    board[row] = col;
                    Solve(board, row + 1, solutions, maxSolutions);
                    board[row] = -1; // Backtrack
                }
            }
        }

        // Overloaded IsSafe method for the algorithmic logic
        private bool IsSafe(int[] board, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                if (board[i] == col || Math.Abs(board[i] - col) == Math.Abs(i - row))
                {
                    return false;
                }
            }
            return true;
        }

        // Find solutions using a threaded algorithm
        private Task<List<List<int>>> FindSolutionsThreadedAsync(int numberOfSolutions)
        {
            return Task.Run(() => FindSolutionsSequentially(numberOfSolutions));
        }

        private void gamemenu_Click(object sender, EventArgs e)
        {
            GameMenu GameMenuForm = new GameMenu();
            GameMenuForm.Show();
            this.Hide();
        }
    }
}
