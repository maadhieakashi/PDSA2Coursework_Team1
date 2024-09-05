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
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace PDSA2Coursework_Team1
{
    public partial class MinimumCost : Form
    {
        private Random random = new Random();
        private Panel panelResult;
        private int[,] costMatrix;
        private int[,] userMatrix;
        private TextBox[,] textBoxes;
        private Stopwatch stopwatch = new Stopwatch();
        private Panel PanelResult; // Panel to display results
        private int userTotalCost;  // Variable to store user's total cost
        List<(int employee, int task, int cost)> userInput;
        private List<(int employee, int task, int cost)> optimalAssignment;
        private int totalCost;
        int n;
        public MinimumCost()
        {
            InitializeComponent();
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

            // Check if txtPlayerName is empty
            if (string.IsNullOrWhiteSpace(txtPlayerName.Text))
            {
                // Display a message to the user
                MessageBox.Show("Please enter a player name in the Player Name text box.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Optionally, you can set focus back to txtPlayerName to prompt the user to enter a name
                txtPlayerName.Focus();

            }

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber.Text, out n) && n > 0)
            {
                costMatrix = new int[n, n]; // Initialize matrix here
                random = new Random(); // Initialize the random number generator

                Panelcost.Visible = true;
                Panelcost.Controls.Clear(); // Clear any previous grid if it exists

                PanelUser.Visible = true;
                PanelUser.Controls.Clear(); // Clear any previous grid if it exists

                // Initialize TableLayoutPanel for cost matrix
                TableLayoutPanel table = new TableLayoutPanel
                {
                    RowCount = n + 1, // One extra row for headers
                    ColumnCount = n + 1, // One extra column for headers
                    AutoSize = true,
                    CellBorderStyle = TableLayoutPanelCellBorderStyle.None, // No individual cell borders
                    AutoScroll = false // Prevent auto scrollbars
                };

                // Add header cells (T1, T2, ..., Tn)
                for (int i = 1; i <= n; i++)
                {
                    var headerLabel = new Label
                    {
                        Text = $"T{i}",
                        TextAlign = ContentAlignment.MiddleCenter,
                        Padding = new Padding(5),
                        Margin = new Padding(0), // No margin to eliminate spacing
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    table.Controls.Add(headerLabel, i, 0);
                }

                // Add header cells (E1, E2, ..., En)
                for (int i = 1; i <= n; i++)
                {
                    var headerLabel = new Label
                    {
                        Text = $"E{i}",
                        TextAlign = ContentAlignment.MiddleCenter,
                        Padding = new Padding(5),
                        Margin = new Padding(0), // No margin to eliminate spacing
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    table.Controls.Add(headerLabel, 0, i);
                }

                // Populate the grid with random values between $20 and $200
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        int cost = random.Next(20, 201);
                        costMatrix[i, j] = cost;
                        var cellLabel = new Label
                        {
                            Text = $"${cost}",
                            TextAlign = ContentAlignment.MiddleCenter,
                            Padding = new Padding(5),
                            Margin = new Padding(0), // No margin to eliminate spacing
                            BorderStyle = BorderStyle.FixedSingle
                        };
                        table.Controls.Add(cellLabel, j + 1, i + 1); // Add cost value to the table
                    }
                }

                // Add the table to the panel
                Panelcost.Controls.Add(table);

                // Calculate and set panel size based on the size of the table
                Panelcost.Width = table.PreferredSize.Width;
                Panelcost.Height = table.PreferredSize.Height;

                // Initialize TableLayoutPanel for user input
                TableLayoutPanel table1 = new TableLayoutPanel
                {
                    RowCount = n + 1, // One extra row for headers
                    ColumnCount = 3, // Three columns for "Employee," "Tasks," "Cost"
                    AutoSize = true,
                    CellBorderStyle = TableLayoutPanelCellBorderStyle.None, // No individual cell borders
                    AutoScroll = false // Prevent auto scrollbars
                };

                // Add top row headers ("Employee," "Tasks," "Cost")
                var headerLabels = new[] { "Employee", "Tasks", "Cost" };
                for (int i = 0; i < headerLabels.Length; i++)
                {
                    var headerLabel = new Label
                    {
                        Text = headerLabels[i],
                        TextAlign = ContentAlignment.MiddleCenter,
                        Padding = new Padding(5),
                        Margin = new Padding(0), // No margin to eliminate spacing
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    table1.Controls.Add(headerLabel, i, 0);
                }

                // Add first column headers ("E1," "E2," ..., "En")
                for (int i = 1; i <= n; i++)
                {
                    var headerLabel = new Label
                    {
                        Text = $"E{i}",
                        TextAlign = ContentAlignment.MiddleCenter,
                        Padding = new Padding(5),
                        Margin = new Padding(0), // No margin to eliminate spacing
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    table1.Controls.Add(headerLabel, 0, i); // First column for "Employee" headers
                }

                // Add text boxes in "Tasks" and "Cost" columns
                textBoxes = new TextBox[n, 2]; // 2 columns: "Tasks" and "Cost"
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 0; j < 2; j++) // Only two columns: "Tasks" and "Cost"
                    {
                        var cellText = new TextBox
                        {
                            TextAlign = HorizontalAlignment.Center,
                            Padding = new Padding(5),
                            Margin = new Padding(0), // No margin to eliminate spacing
                            BorderStyle = BorderStyle.FixedSingle
                        };

                        // Store the TextBox reference in the array
                        textBoxes[i - 1, j] = cellText;

                        // Add the text box to the table
                        table1.Controls.Add(cellText, j + 1, i); // Column index shifted by 1 to account for the "Employee" column
                    }
                }

                // Add the table to the panel
                PanelUser.Controls.Add(table1);

                // Calculate and set panel size based on the size of the table
                PanelUser.Width = table1.PreferredSize.Width;
                PanelUser.Height = table1.PreferredSize.Height;
            }
            else
            {
                MessageBox.Show("Please enter a valid number greater than 0.");
            }

            stopwatch.Start();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    // Display a message to the user
                    MessageBox.Show("Please complete the optimal assignment.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();

            // Record the time taken to solve
            TimeSpan elapsedTime = stopwatch.Elapsed;

            // After validation, call the HungarianAlgorithm and store the result
            var (optimalAssignment, totalCost) = HungarianAlgorithm(costMatrix);
            // List to store user input
            List<(int employee, int task, int cost)> userInput = new List<(int employee, int task, int cost)>();

            // Loop through each employee (row in PanelUser)
            for (int i = 0; i < n; i++)
            {
                // Get the task and cost values entered by the user
                if (int.TryParse(textBoxes[i, 0].Text, out int task) && int.TryParse(textBoxes[i, 1].Text, out int cost))
                {
                    // Add the tuple (employee index, task, cost) to the userInput list
                    userInput.Add((i, task - 1, cost)); // Subtract 1 from task to match zero-based index of optimalAssignment
                }
                else
                {
                    // Handle invalid input (optional)
                    MessageBox.Show($"Invalid input at row {i + 1}. Please enter valid integers for Task and Cost.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }







            //UserPanel validation
            bool allValid = true;
            string message = string.Empty;

            // Check each text box in the "Tasks" and "Cost" columns
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    var textBox = textBoxes[i, j];
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        // Check for empty text boxes
                        allValid = false;
                        message += $"Text box at row {i + 1}, column {(j == 0 ? "Tasks" : "Cost")} is empty.\n";
                    }
                    else
                    {
                        // Check for non-integer values
                        if (!int.TryParse(textBox.Text, out _))
                        {
                            allValid = false;
                            message += $"Text box at row {i + 1}, column {(j == 0 ? "Tasks" : "Cost")} does not contain a valid integer.\n";
                        }
                    }
                }
            }



            // Display message if any validation failed
            if (!allValid)
            {
                MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Optimal assignment values are valid.", "Validation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            //Total Cost text box validation
            // Validate txtTotal
            if (string.IsNullOrWhiteSpace(txtTotal.Text))
            {
                // Display a message if the txtTotal is empty
                MessageBox.Show("Please enter a value in the Total text box.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTotal.Focus(); // Optionally, set focus to the txtTotal text box
                return;
            }
            else if (!int.TryParse(txtTotal.Text, out _))
            {
                // Display a message if the value in txtTotal is not an integer
                MessageBox.Show("Please enter a valid integer in the Total text box.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTotal.Focus(); // Optionally, set focus to the txtTotal text box
                return;
            }

            // If everything is valid, proceed with the rest of your code
            MessageBox.Show("Total value is valid.", "Validation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Now compare userInput with optimalAssignment (optional)
            bool isEqual = userInput.SequenceEqual(optimalAssignment);


            int userEnteredTotalCost = Convert.ToInt32(txtTotal.Text);

            bool isCostEqual = userEnteredTotalCost == totalCost;
            // Check the user-entered total cost in txtTotal

            // Compare user-entered total cost with the result from HungarianAlgorithm

            if (isEqual && !isCostEqual)
            {
                MessageBox.Show(" Your optimal assignment is correct but total minimum cost is incorrect", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                displayResult();
            }

            else if (!isEqual && isCostEqual)
            {
                MessageBox.Show(" Your total minimum cost is correct but optimal assignment is incorrect", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                displayResult();
            }

            else if (!isEqual && !isCostEqual)
            {
                MessageBox.Show(" Both your  optimal assignment and total  minimum cost are incorrect", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                displayResult();
            }

            else
            {
                MessageBox.Show("Congratulations!, Your answers are correct", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (isEqual && isCostEqual)
                {


                    // Convert TimeSpan to float (total seconds)
                    float timeTakenInSeconds = (float)elapsedTime.TotalSeconds;

                    // Insert into the database
                    InsertRecord(
                        txtPlayerName.Text,
                        int.Parse(txtNumber.Text),
                        timeTakenInSeconds,  // Pass the converted time
                        userInput,
                        totalCost
                    );

                    MessageBox.Show("Congratulations!, Your answers are correct", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset txtPlayerName
            txtPlayerName.Text = "";

            // Reset txtTotal
            txtTotal.Text = "";

            // Reset txtNumber
            txtNumber.Text = "";

            // Reset all textboxes in PanelUser
            foreach (Control control in PanelUser.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
            }
        }

        private void displayResult()
        {
            try
            {
                // Call the Hungarian Algorithm with the generated cost matrix
                var (optimalAssignment, totalCost) = HungarianAlgorithm(costMatrix);

                // Use a StringBuilder to gather all the information into one string
                StringBuilder resultMessage = new StringBuilder();
                resultMessage.AppendLine("Optimal Assignment:");
                foreach (var (employee, task, cost) in optimalAssignment)
                {
                    resultMessage.AppendLine($"Employee {employee + 1} -> Task {task + 1} with Cost {cost}");
                }

                resultMessage.AppendLine($"Total Minimum Cost: {totalCost}");

                // Display everything in a single MessageBox
                MessageBox.Show(resultMessage.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static (List<(int, int, int)>, int) HungarianAlgorithm(int[,] costMatrix)
        {
            int n = costMatrix.GetLength(0);
            int[,] matrix = (int[,])costMatrix.Clone();

            // Step 1: Row Reduction
            RowReduction(matrix, n);

            // Step 2: Column Reduction
            ColumnReduction(matrix, n);

            // Step 3: Mark Zeros
            bool[,] zeroMarks = MarkZeros(matrix, n);

            // Step 4: Find Optimal Assignment
            List<(int, int, int)> optimalAssignment = FindOptimalAssignment(zeroMarks, costMatrix, n);

            // Step 5: Calculate Total Cost
            int totalCost = CalculateTotalCost(optimalAssignment);

            return (optimalAssignment, totalCost);
        }

        private static void RowReduction(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int minValue = int.MaxValue;
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < minValue)
                    {
                        minValue = matrix[i, j];
                    }
                }
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] -= minValue;
                }
            }
        }

        private static void ColumnReduction(int[,] matrix, int n)
        {
            for (int j = 0; j < n; j++)
            {
                int minValue = int.MaxValue;
                for (int i = 0; i < n; i++)
                {
                    if (matrix[i, j] < minValue)
                    {
                        minValue = matrix[i, j];
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    matrix[i, j] -= minValue;
                }
            }
        }

        private static bool[,] MarkZeros(int[,] matrix, int n)
        {
            bool[,] zeroMarks = new bool[n, n];
            bool[] coveredRows = new bool[n];
            bool[] coveredColumns = new bool[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == 0 && !coveredRows[i] && !coveredColumns[j])
                    {
                        zeroMarks[i, j] = true;
                        coveredRows[i] = true;
                        coveredColumns[j] = true;
                    }
                }
            }

            return zeroMarks;
        }

        private static List<(int, int, int)> FindOptimalAssignment(bool[,] zeroMarks, int[,] costMatrix, int n)
        {
            var assignment = new List<(int, int, int)>();
            bool[] assignedRows = new bool[n];
            bool[] assignedCols = new bool[n];

            // Ensure every employee gets a task assignment
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (zeroMarks[i, j] && !assignedRows[i] && !assignedCols[j])
                    {
                        assignment.Add((i, j, costMatrix[i, j]));
                        assignedRows[i] = true;
                        assignedCols[j] = true;
                        break;
                    }
                }
            }

            // Handle remaining unassigned employees/tasks
            for (int i = 0; i < n; i++)
            {
                if (!assignedRows[i])
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (!assignedCols[j])
                        {
                            assignment.Add((i, j, costMatrix[i, j]));
                            assignedRows[i] = true;
                            assignedCols[j] = true;
                            break;
                        }
                    }
                }
            }

            return assignment;
        }

        private static int CalculateTotalCost(List<(int, int, int)> assignment)
        {
            return assignment.Sum(item => item.Item3);
        }

        private void InsertRecord(string playerName, int numberOfTasks, float timeTaken, List<(int employee, int task, int cost)> userInput, int totalCost)
        {
            string connectionString = "Server=localhost;Database=pdsa2cw;Uid=root;Pwd=1234;";

            // Serialize userInput to JSON
            string serializedUserInput = JsonConvert.SerializeObject(userInput);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO UserRecords (PlayerName, NumberOfTasks, TimeTakenInSeconds, UserInputs, TotalCost) " +
                               "VALUES (@PlayerName, @NumberOfTasks, @TimeTaken, @UserInputs, @TotalCost)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PlayerName", playerName);
                    cmd.Parameters.AddWithValue("@NumberOfTasks", numberOfTasks);
                    cmd.Parameters.AddWithValue("@TimeTaken", timeTaken);
                    cmd.Parameters.AddWithValue("@UserInputs", serializedUserInput);
                    cmd.Parameters.AddWithValue("@TotalCost", totalCost);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            GameMenu gameMenu = new GameMenu(); // Create an instance of the GameMenu form
            gameMenu.Show(); // Show the GameMenu form
            this.Hide();
        }
    }
}