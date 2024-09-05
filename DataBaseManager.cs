using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PDSA2Coursework_Team1
{
    public class DatabaseManager
    {
        // Define the connection string with the correct port number
        private static string connectionString = "server=localhost;port=3307;database=pdsa2cw;uid=root;pwd=1234;";
        private MySqlConnection connection;

        public DatabaseManager()
        {
            connection = new MySqlConnection(connectionString);
        }

        // Open connection to the database
        public void OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"An error occurred while opening the connection: {ex.Message}");
                // Handle exception as needed
            }
        }

        // Close connection db
        public void CloseConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"An error occurred while closing the connection: {ex.Message}");
                
            }
        }

        // Insert correct response with playername to db
        public void InsertSolution(string solution, string playerName)
        {
         string query = "INSERT INTO sixteen_queens_puzzle (Solution,PlayerName)VALUES(@solution, @playerName)";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@solution", solution);
                cmd.Parameters.AddWithValue("@playerName", playerName);


                OpenConnection();
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        // Retrieve all solutions
        public MySqlDataReader GetAllSolutions()
        {
            string query = "SELECT * FROM sixteen_queens_puzzle";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            OpenConnection();
            return cmd.ExecuteReader();
        }

        //SEQUENTIAL AND THREADED PART
        public static async Task SaveSequentialSolutionsToDatabaseAsync(List<List<int>> solutions)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    foreach (var solution in solutions)
                    {
                        var query = "INSERT INTO sequential_solutions (solution) VALUES (@solution)";
                        using (var command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@solution", string.Join(",", solution));
                            await command.ExecuteNonQueryAsync();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Error: {ex.Message}\nStack Trace: {ex.StackTrace}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General Error: {ex.Message}\nStack Trace: {ex.StackTrace}");
            }
        }

        public static async Task SaveThreadedSolutionsToDatabaseAsync(List<List<int>> solutions)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    foreach (var solution in solutions)
                    {
                        var query = "INSERT INTO threaded_solutions (solution) VALUES (@solution)";
                        using (var command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@solution", string.Join(",", solution));
                            await command.ExecuteNonQueryAsync();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Error: {ex.Message}\nStack Trace: {ex.StackTrace}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General Error: {ex.Message}\nStack Trace: {ex.StackTrace}");
            }
        }


    }
}
