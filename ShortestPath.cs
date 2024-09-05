using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
//using System.Text.Json; // For JSON serialization
using Newtonsoft.Json;


namespace PDSA2Coursework_Team1
{
    public partial class ShortestPath : Form
    {
        private Panel gridPanel;
        //private ComboBox cityDropdown;
        private Panel inputPanel;
        private Panel resultPanel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button homeButton;
        private Label resultLabel;
        private Label mainLabel;
        private Label nameLabel;
        private Label instructionLabel;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private Label selectedCityLabel;
        private string selectedCity;
        private int[,] distanceMatrix;
        private decimal dijkstraExecutionTime;
        private decimal bellmanFordExecutionTime; // Variable to store execution time
        public ShortestPath()
        {
            distanceMatrix = new int[9, 9];
            // Initialize the form components
            this.Text = "Identify Shortest Path";
            this.Size = new Size(1150, 800);

            this.BackgroundImage = Properties.Resources.bgImage1;
            this.BackgroundImageLayout = ImageLayout.Stretch; // Adjust as needed

            //Main Label
            mainLabel = new Label();
            mainLabel.Text = "IDENTIFY SHORTEST PATH";
            mainLabel.Location = new Point(420, 50);
            mainLabel.Size = new Size(200, 40);
            mainLabel.AutoSize = true;
            mainLabel.ForeColor = Color.White;
            mainLabel.Font = new Font(mainLabel.Font.FontFamily, 16, FontStyle.Bold);
            mainLabel.BackColor = Color.Transparent;
            this.Controls.Add(mainLabel);

            //PLayerLabel
            nameLabel = new Label();
            nameLabel.Text = "Player's Name:";
            nameLabel.Location = new Point(410, 116);
            nameLabel.Size = new Size(200, 40);
            nameLabel.AutoSize = true;
            nameLabel.ForeColor = Color.White;
            nameLabel.Font = new Font(mainLabel.Font.FontFamily, 14);
            nameLabel.BackColor = Color.Transparent;
            this.Controls.Add(nameLabel);

            //place holder player name
            playerNameTextBox = new System.Windows.Forms.TextBox();
            playerNameTextBox.Location = new Point(560, 120);
            playerNameTextBox.Size = new Size(200, 1000);
            playerNameTextBox.AutoSize = true;
            playerNameTextBox.Text = "Enter your name"; // Placeholder text
            playerNameTextBox.ForeColor = Color.Gray; // Color for placeholder text
            playerNameTextBox.Enter += PlayerNameTextBox_Enter;
            playerNameTextBox.Leave += PlayerNameTextBox_Leave;
            this.Controls.Add(playerNameTextBox);

            // Create and configure the panel for the grid
            gridPanel = new Panel();
            gridPanel.Location = new Point(20, 210);
            gridPanel.Size = new Size(500, 500);
            gridPanel.AutoScroll = true;
            this.Controls.Add(gridPanel);

            // Label for the randomly selected city
            selectedCityLabel = new Label();
            selectedCityLabel.Location = new Point(580, 210);
            selectedCityLabel.Size = new Size(200, 40);
            selectedCityLabel.AutoSize = true;
            selectedCityLabel.ForeColor = Color.White;
            selectedCityLabel.Font = new Font(mainLabel.Font.FontFamily, 14);
            selectedCityLabel.BackColor = Color.Transparent;
            this.Controls.Add(selectedCityLabel);



            // Instructional text above the input fields
            instructionLabel = new Label();
            instructionLabel.Text = "Input the shortest path and distance for other cities from the selected city.";
            instructionLabel.Location = new Point(578, 275);
            instructionLabel.Size = new Size(200, 40);
            instructionLabel.AutoSize = true;
            instructionLabel.ForeColor = Color.White;
            instructionLabel.Font = new Font(instructionLabel.Font.FontFamily, 12);
            instructionLabel.BackColor = Color.Transparent;
            this.Controls.Add(instructionLabel);

            // Create and configure the panel for input fields
            inputPanel = new Panel();
            inputPanel.Location = new Point(580, 315);
            inputPanel.Size = new Size(230, 335);
            inputPanel.BackColor = Color.LightGray;
            inputPanel.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(inputPanel);

            // Create and configure the submit button (visible by default)
            submitButton = new System.Windows.Forms.Button();
            submitButton.Text = "Submit Answers";
            submitButton.Location = new Point(580, 683);
            submitButton.Size = new Size(100, 30);
            submitButton.Click += SubmitButton_Click;
            submitButton.BackColor = Color.Yellow;
            submitButton.ForeColor = Color.Black;
            submitButton.Font = new Font(submitButton.Font.FontFamily, 10, FontStyle.Regular);
            submitButton.FlatStyle = FlatStyle.Flat;
            submitButton.FlatAppearance.BorderSize = 0;

            this.Controls.Add(submitButton);

            // Create and configure the reset button
            resetButton = new System.Windows.Forms.Button();
            resetButton.Text = "Reset";
            resetButton.Location = new Point(690, 683); // Next to the submit button
            resetButton.Size = new Size(100, 30);
            resetButton.Click += ResetButton_Click;
            resetButton.BackColor = Color.LawnGreen;
            resetButton.ForeColor = Color.Black;
            resetButton.Font = new Font(submitButton.Font.FontFamily, 10);
            resetButton.FlatStyle = FlatStyle.Flat;
            resetButton.FlatAppearance.BorderSize = 0;
            this.Controls.Add(resetButton);

            // Create and configure the home button
            homeButton = new System.Windows.Forms.Button();
            //homeButton.Text = "Home";
            homeButton.Location = new Point(1050, 20); // Next to the reset button
            homeButton.Size = new Size(65, 65);
            homeButton.BackColor = Color.Transparent;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatAppearance.MouseOverBackColor = Color.Transparent;



            try
            {
                homeButton.Image = Properties.Resources.home1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading home icon: " + ex.Message);
            }
            homeButton.ImageAlign = ContentAlignment.MiddleCenter;
            homeButton.Click += HomeButton_Click;
            this.Controls.Add(homeButton);



            resultPanel = new Panel();
            resultPanel.Location = new Point(845, 315);
            resultPanel.Size = new Size(330, 300);
            resultPanel.BackColor = Color.Transparent;
            resultPanel.ForeColor = Color.White;
            this.Controls.Add(resultPanel);

            // Populate the grid when the form loads
            this.Load += new EventHandler(GridForm_Load);
        }


        private void GridForm_Load(object sender, EventArgs e)
        {
            // Clear any existing controls
            gridPanel.Controls.Clear();

            // Grid size
            int n = 9;
            int cellWidth = gridPanel.ClientSize.Width / (n + 1);
            int cellHeight = 50;

            Random rnd = new Random();

            // Create header labels
            for (int i = 0; i <= n; i++)
            {
                Label lbl = new Label();
                lbl.Size = new Size(cellWidth, cellHeight);
                lbl.Location = new Point(i * cellWidth, 0);
                lbl.BorderStyle = BorderStyle.FixedSingle;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Text = i == 0 ? "City" : $"City {Convert.ToChar('A' + i - 1)}";
                gridPanel.Controls.Add(lbl);
            }

            // Create row headers and grid cells
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    Label lbl = new Label();
                    lbl.Size = new Size(cellWidth, cellHeight);
                    lbl.Location = new Point(j * cellWidth, i * cellHeight);
                    lbl.BorderStyle = BorderStyle.FixedSingle;
                    lbl.TextAlign = ContentAlignment.MiddleCenter;

                    if (i == 0 && j > 0)
                    {
                        lbl.Text = $"City {Convert.ToChar('A' + j - 1)}"; // Column Headers
                    }
                    else if (j == 0 && i > 0)
                    {
                        lbl.Text = $"City {Convert.ToChar('A' + i - 1)}"; // Row Headers
                    }
                    else if (i > 0 && j > 0)
                    {
                        // Fill the distance cell based on symmetry and zero diagonal
                        if (i == j)
                        {
                            lbl.Text = "0"; // Distance between the same cities
                            distanceMatrix[i - 1, j - 1] = 0;
                        }
                        else if (i > j)
                        {
                            // Random distance for the lower triangle and symmetric
                            int distance = rnd.Next(5, 51);
                            lbl.Text = $"{distance}";
                            distanceMatrix[i - 1, j - 1] = distance;
                            distanceMatrix[j - 1, i - 1] = distance;
                        }
                        else
                        {
                            lbl.Text = ""; // No distances in the upper triangle
                        }
                    }

                    gridPanel.Controls.Add(lbl);
                }
            }

            // Randomly select a city between A and I
            int randomIndex = rnd.Next(1, 10); // 1 to 9
            selectedCity = $"City {Convert.ToChar('A' + randomIndex - 1)}";
            selectedCityLabel.Text = $"Selected City: {selectedCity}";

            // Add input fields for the shortest path and distance for other cities
            AddInputFields(randomIndex);
        }

        private void PlayerNameTextBox_Enter(object sender, EventArgs e)
        {


            if (playerNameTextBox.Text == "Enter your name")
            {
                playerNameTextBox.Text = "";
                playerNameTextBox.ForeColor = Color.Black; // Text color when user starts typing
            }
        }

        private void PlayerNameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(playerNameTextBox.Text))
            {
                playerNameTextBox.Text = "Enter your name";
                playerNameTextBox.ForeColor = Color.Gray; // Placeholder text color
            }
        }

        private void AddInputFields(int selectedIndex)
        {
            inputPanel.Controls.Clear();

            int n = 9;
            int fieldHeight = 25;
            int yOffset = 0;

            // Labels for the input sections
            Label pathLabel = new Label();
            pathLabel.Text = "Shortest path";
            pathLabel.Location = new Point(70, yOffset);
            pathLabel.Size = new Size(80, fieldHeight);
            inputPanel.Controls.Add(pathLabel);

            Label distanceLabel = new Label();
            distanceLabel.Text = "Distance";
            distanceLabel.Location = new Point(160, yOffset);
            distanceLabel.Size = new Size(50, fieldHeight);
            inputPanel.Controls.Add(distanceLabel);

            yOffset += fieldHeight;

            for (int i = 1; i <= n; i++)
            {


                // Create label for the city
                Label cityLabel = new Label();
                cityLabel.Text = $"City {Convert.ToChar('A' + i - 1)}";
                cityLabel.Size = new Size(50, fieldHeight);
                cityLabel.Location = new Point(10, yOffset);
                inputPanel.Controls.Add(cityLabel);

                // Create input field for the shortest path
                System.Windows.Forms.TextBox pathTextBox = new System.Windows.Forms.TextBox();
                pathTextBox.Size = new Size(80, fieldHeight);
                pathTextBox.Location = new Point(70, yOffset);
                inputPanel.Controls.Add(pathTextBox);

                // Create input field for the distance
                System.Windows.Forms.TextBox distanceTextBox = new System.Windows.Forms.TextBox();
                distanceTextBox.Size = new Size(50, fieldHeight);
                distanceTextBox.Location = new Point(160, yOffset);



                inputPanel.Controls.Add(distanceTextBox);

                yOffset += fieldHeight + 10;

            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string playerName = playerNameTextBox.Text;
            if (playerName == "Enter your name" || string.IsNullOrWhiteSpace(playerName))
            {
                MessageBox.Show("Please enter your name before submitting.");
                return;
            }

            // Validate if all text fields are filled
            bool allFilled = inputPanel.Controls.OfType<System.Windows.Forms.TextBox>().All(tb => !string.IsNullOrEmpty(tb.Text));
            if (!allFilled)
            {
                MessageBox.Show("Please fill in all fields before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve user inputs into a list
            List<(string cityName, string path, int distance)> userInputs = new List<(string cityName, string path, int distance)>();
            var textBoxes = inputPanel.Controls.OfType<System.Windows.Forms.TextBox>().ToList();

            for (int i = 0; i < textBoxes.Count; i += 2)
            {
                System.Windows.Forms.TextBox pathTextBox = textBoxes[i];
                System.Windows.Forms.TextBox distanceTextBox = textBoxes[i + 1];

                string cityName = $"City {Convert.ToChar('A' + i / 2)}";

                if (int.TryParse(distanceTextBox.Text, out int distance))
                {
                    userInputs.Add((cityName, pathTextBox.Text, distance));
                }
                else
                {
                    MessageBox.Show($"Invalid distance for {cityName}. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Dijkstra Algorithm
            var (shortestPaths, shortestDistances) = DijkstraAlgorithm(Convert.ToInt32(selectedCity[5] - 'A'), distanceMatrix);
            List<(string cityName, string path, int distance)> dijkstraResults = new List<(string cityName, string path, int distance)>();

            for (int i = 0; i < 9; i++)
            {
                string cityName = $"City {Convert.ToChar('A' + i)}";
                dijkstraResults.Add((cityName, shortestPaths[i], shortestDistances[i]));
            }

            // Bellman-Ford Algorithm
            var (bellmanFordPaths, bellmanFordDistances) = BellmanFordAlgorithm(Convert.ToInt32(selectedCity[5] - 'A'), distanceMatrix);
            List<(string cityName, string path, int distance)> bellmanFordResults = new List<(string cityName, string path, int distance)>();

            for (int i = 0; i < 9; i++)
            {
                string cityName = $"City {Convert.ToChar('A' + i)}";
                bellmanFordResults.Add((cityName, bellmanFordPaths[i], bellmanFordDistances[i]));
            }

            // Display lists and execution times
            StringBuilder userInputsString = new StringBuilder("User Inputs:\n");
            foreach (var entry in userInputs)
            {
                userInputsString.AppendLine($"To {entry.cityName}: Path: {entry.path}, Distance: {entry.distance}");
            }
            MessageBox.Show(userInputsString.ToString(), "User Inputs");

            StringBuilder dijkstraResultsString = new StringBuilder("Dijkstra's Algorithm Results:\n");
            foreach (var entry in dijkstraResults)
            {
                dijkstraResultsString.AppendLine($"To {entry.cityName}: Path: {entry.path}, Distance: {entry.distance}");
            }
            MessageBox.Show(dijkstraResultsString.ToString(), "Dijkstra's Algorithm Results");

            StringBuilder bellmanFordResultsString = new StringBuilder("Bellman-Ford Algorithm Results:\n");
            foreach (var entry in bellmanFordResults)
            {
                bellmanFordResultsString.AppendLine($"To {entry.cityName}: Path: {entry.path}, Distance: {entry.distance}");
            }
            MessageBox.Show(bellmanFordResultsString.ToString(), "Bellman-Ford Algorithm Results");

            resultPanel.Controls.Clear();
            Label resultLabel = new Label();
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font(resultLabel.Font.FontFamily, 10);

            bool isEqualDijkstra = userInputs.SequenceEqual(dijkstraResults);
            bool isEqualBellmanFordResults = userInputs.SequenceEqual(bellmanFordResults);

            if (isEqualDijkstra || isEqualBellmanFordResults)
            {



                resultLabel.Text = "Your answers are correct.";
                SaveGameRecord(
                    playerName,
                    distanceMatrix,
                    userInputs,
                    dijkstraExecutionTime,
                    bellmanFordExecutionTime
                    );

            }

            else
            {
                //MessageBox.Show(" Your answers are incorrect", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Information);

                StringBuilder incorrectResults = new StringBuilder("Your answers are incorrect.\n\nCorrect answers:\n\n");

                incorrectResults.AppendLine("Dijkstra's Algorithm Results:");
                foreach (var entry in dijkstraResults)
                {
                    incorrectResults.AppendLine($"To {entry.cityName}: Path: {entry.path}, Distance: {entry.distance}");
                }

                resultLabel.Text = incorrectResults.ToString();

            }

            resultPanel.Controls.Add(resultLabel);

        }

        private (string[] Paths, int[] Distances) DijkstraAlgorithm(int startCity, int[,] graph)
        {
            int n = graph.GetLength(0);
            int[] distances = new int[n];
            bool[] shortestPathTreeSet = new bool[n];
            string[] paths = new string[n];

            // Initialize distances and paths
            for (int i = 0; i < n; i++)
            {
                distances[i] = int.MaxValue;
                paths[i] = "";
                shortestPathTreeSet[i] = false;
            }
            distances[startCity] = 0;
            paths[startCity] = $"{Convert.ToChar('A' + startCity)}";

            // Start timing
            Stopwatch stopwatch = Stopwatch.StartNew();

            // Find shortest paths
            for (int count = 0; count < n - 1; count++)
            {
                int u = MinDistance(distances, shortestPathTreeSet);
                shortestPathTreeSet[u] = true;

                for (int v = 0; v < n; v++)
                {
                    if (!shortestPathTreeSet[v] && graph[u, v] != 0 &&
                        distances[u] != int.MaxValue && distances[u] + graph[u, v] < distances[v])
                    {
                        distances[v] = distances[u] + graph[u, v];
                        paths[v] = $"{paths[u]}-{Convert.ToChar('A' + v)}";
                    }
                }
            }
            // Stop timing
            stopwatch.Stop();
            decimal executionTimeInSecondsDijkstra = (decimal)stopwatch.Elapsed.TotalMilliseconds; // Store the execution time
            return (paths, distances);
        }

        private int MinDistance(int[] distances, bool[] sptSet)
        {
            int min = int.MaxValue;
            int minIndex = -1;

            for (int v = 0; v < distances.Length; v++)
            {
                if (!sptSet[v] && distances[v] <= min)
                {
                    min = distances[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        private (string[] Paths, int[] Distances) BellmanFordAlgorithm(int startCity, int[,] graph)
        {
            int n = graph.GetLength(0);
            int[] distances = new int[n];
            string[] paths = new string[n];
            int[,] predecessors = new int[n, n];

            // Initialize distances and paths
            for (int i = 0; i < n; i++)
            {
                distances[i] = int.MaxValue;
                paths[i] = "";
                for (int j = 0; j < n; j++)
                {
                    predecessors[i, j] = -1;
                }
            }
            distances[startCity] = 0;
            paths[startCity] = $"{Convert.ToChar('A' + startCity)}";

            // Start timing
            Stopwatch stopwatch = Stopwatch.StartNew();

            // Relax edges |V| - 1 times
            for (int k = 1; k < n; k++)
            {
                for (int u = 0; u < n; u++)
                {
                    for (int v = 0; v < n; v++)
                    {
                        if (graph[u, v] != 0 && distances[u] != int.MaxValue && distances[u] + graph[u, v] < distances[v])
                        {
                            distances[v] = distances[u] + graph[u, v];
                            predecessors[v, u] = u;
                            paths[v] = $"{paths[u]}-{Convert.ToChar('A' + v)}";
                        }
                    }
                }
            }

            // Check for negative-weight cycles
            for (int u = 0; u < n; u++)
            {
                for (int v = 0; v < n; v++)
                {
                    if (graph[u, v] != 0 && distances[u] != int.MaxValue && distances[u] + graph[u, v] < distances[v])
                    {
                        MessageBox.Show("Graph contains negative weight cycle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return (paths, distances);
                    }
                }
            }

            // Stop timing
            stopwatch.Stop();
            // Store the execution time
            decimal executionTimeInSecondsBellmanFord = (decimal)stopwatch.Elapsed.TotalMilliseconds;
            return (paths, distances);


        }

        // Event handler for the Reset button
        private void ResetButton_Click(object sender, EventArgs e)
        {
            // Clear all the text fields in the input panel
            foreach (System.Windows.Forms.TextBox textBox in inputPanel.Controls.OfType<System.Windows.Forms.TextBox>())
            {
                textBox.Clear();
            }
            resultPanel.Controls.Clear();
        }

        // Event handler for the Home button
        private void HomeButton_Click(object sender, EventArgs e)
        {
            GameMenu gameMenu = new GameMenu(); 
            gameMenu.Show(); 
            this.Hide();
            
        }

        private void SaveGameRecord(
           string playerName,
           int[,] distanceMatrix,
           List<(string cityName, string path, int distance)> userInputs,
           decimal dijkstraExecutionTime,
           decimal bellmanFordExecutionTime)
        {
            // Serialize the distanceMatrix and userInputs to JSON
            string serializedDistanceMatrix = SerializeMatrix(distanceMatrix);
            string serializedUserInput = JsonConvert.SerializeObject(userInputs);

            string connectionString = "server=localhost;port=3307;database=pdsa2cw;uid=root;pwd=1234;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Corrected SQL query without extra quote and unnecessary newline characters
                string query = @"
            INSERT INTO GameRecords (
                PlayerName, 
                DistanceMatrix, 
                UserInputs, 
                DijkstraExecutionTime, 
                BellmanFordExecutionTime
            ) VALUES (
                @PlayerName, 
                @DistanceMatrix, 
                @UserInputs, 
                @DijkstraExecutionTime, 
                @BellmanFordExecutionTime
            )"
                ;

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Add parameters to the command
                    cmd.Parameters.AddWithValue("@PlayerName", playerName);
                    cmd.Parameters.AddWithValue("@DistanceMatrix", serializedDistanceMatrix);
                    cmd.Parameters.AddWithValue("@UserInputs", serializedUserInput);
                    cmd.Parameters.AddWithValue("@DijkstraExecutionTime", dijkstraExecutionTime);
                    cmd.Parameters.AddWithValue("@BellmanFordExecutionTime", bellmanFordExecutionTime);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private string SerializeMatrix(int[,] matrix)
        {
            // Serialize matrix to a JSON string
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            var matrixList = new List<List<int>>();

            for (int i = 0; i < rows; i++)
            {
                var row = new List<int>();
                for (int j = 0; j < cols; j++)
                {
                    row.Add(matrix[i, j]);
                }
                matrixList.Add(row);
            }

            return JsonConvert.SerializeObject(matrixList);
        }

        private void ShortestPath_Load(object sender, EventArgs e)
        {

        }

    }

}