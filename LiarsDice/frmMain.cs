using System;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Collections.Generic;

namespace LiarsDice
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Close Button

        /// <summary>
        /// Close the application on click and after user confirmation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExitApplication_Click(object sender, EventArgs e)
        {

            // Create MessageBox and ask if user is sure they want to quit
            DialogResult confirmClose = MessageBox.Show("Are you sure you want to quit?\nQuitting will result in any current game progress being lost.", "Are you sure?", MessageBoxButtons.YesNo);
            // If yes...
            if (confirmClose == DialogResult.Yes)
                // Close the application
                Application.Exit();
        }

        #endregion

        #region How To Play Button

        /// <summary>
        /// Open a new window that displays the rule of the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            // Create a new instance of the frmRules Form
            frmRules Rules = new frmRules();
            // And show it to the user
            Rules.Show();
        }

        #endregion

        #region Delete Profile Button

        /// <summary>
        /// Delete the profile that is currently selected in lstProfiles ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            if (lstProfiles.SelectedItems.Count == 1 && lstProfiles.SelectedIndex != -1)
            {
                DialogResult response = MessageBox.Show("Are you sure you want to delete the profile?\nThis cannot be undone!  All stats will be lost forever!", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (response == DialogResult.Yes)
                {
                    string firstName = lstProfiles.SelectedItem.ToString().Remove(lstProfiles.SelectedItem.ToString().Length - 3);
                    string lastInitial = lstProfiles.SelectedItem.ToString()[lstProfiles.SelectedItem.ToString().Length - 2].ToString();

                    // Set Connection String for the Database
                    string connectionString = Properties.Settings.Default.dbPlayersConnectionString;
                    SqlConnection connection = new SqlConnection(connectionString);

                    // Open the connection to the database
                    if (connection.State != System.Data.ConnectionState.Open)
                        connection.Open();

                    // SQL to get first and last name from table
                    SqlCommand command = new SqlCommand(
                        "DELETE FROM PlayerStats WHERE FirstName='" + firstName + "' AND LastName LIKE '" + lastInitial + "%';", connection);

                    // Execute command
                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }

            loadListBox();
        }

        #endregion

        #region Load Profile Button

        /// <summary>
        /// Load the profile that is currently selected in lstProfiles ListBox and open the New Game/Stats Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadProfile_Click(object sender, EventArgs e)
        {
            if (lstProfiles.SelectedItems.Count == 1 && lstProfiles.SelectedIndex != -1)
            {
                // Create PlayerProfile for the selected player
                PlayerProfile selectedPlayer = new PlayerProfile();

                // Set Connection String for the Database
                string connectionString = Properties.Settings.Default.dbPlayersConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);

                // Open the connection to the database
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                // SQL to get all selected player's information from table
                SqlCommand command = new SqlCommand(
                    "SELECT FirstName, LastName, GamesPlayed, GamesWon, GamesLost, BetsPlaced, LiarsCalled, BetsLost, BetsWon, DiceLost, DiceWon, PerfectGames " +
                    "FROM PlayerStats " +
                    "WHERE FirstName='" + lstProfiles.SelectedItem.ToString().Remove(lstProfiles.SelectedItem.ToString().Length - 3) + "' " +
                    "AND LastName LIKE '" + lstProfiles.SelectedItem.ToString()[lstProfiles.SelectedItem.ToString().Length - 2] + "%';",
                    connection);

                // Open reader to get query results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // While there are results to get...
                    while (reader.Read())
                    {
                        // Get all information and store in selectedPlayer
                        selectedPlayer.firstName = reader[0].ToString();
                        selectedPlayer.lastName = reader[1].ToString();
                        selectedPlayer.gamesPlayed = (int)reader[2];
                        selectedPlayer.gamesWon = (int)reader[3];
                        selectedPlayer.gamesLost = (int)reader[4];
                        selectedPlayer.betsPlaced = (int)reader[5];
                        selectedPlayer.liarsCalled = (int)reader[6];
                        selectedPlayer.betsLost = (int)reader[7];
                        selectedPlayer.betsWon = (int)reader[8];
                        selectedPlayer.diceLost = (int)reader[9];
                        selectedPlayer.diceTaken = (int)reader[10];
                        selectedPlayer.perfectGames = (int)reader[11];
                        selectedPlayer.fullName = selectedPlayer.firstName + " " + selectedPlayer.lastName;
                    }
                }

                // Close the database
                connection.Close();

                // Pass the selected player's profile to the game form
                frmGame gameWindow = new frmGame(selectedPlayer);
                gameWindow.ShowDialog();
            }
        }

        #endregion

        #region New Profile Button

        /// <summary>
        /// Open a second window to allow the user to create a new profile.  Reload lstProfiles ListBox after completion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewProfile_Click(object sender, EventArgs e)
        {
            frmNewProfile newProfile = new frmNewProfile();
            newProfile.ShowDialog();
            loadListBox();
        }

        #endregion

        #region Form Load

        /// <summary>
        /// On form load, populate the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            loadListBox();
        }

        #endregion

        #region Functions

        /// <summary>
        /// Pull the first and last names from the database and add them to the lstProfiles List Box.
        /// </summary>
        private void loadListBox()
        {
            // Player's first name
            string firstName;
            // Player's last name
            string lastName;
            // Player's first name and last initial
            string fullName;
            // List of all players' full names
            List<string> names = new List<string>();

            // Set Connection String for the Database
            string connectionString = Properties.Settings.Default.dbPlayersConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            // Open the connection to the database
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            // SQL to get first and last name from table
            SqlCommand command = new SqlCommand(
                "SELECT FirstName, LastName FROM PlayerStats;", connection);

            // Open reader to get query results
            using (SqlDataReader reader = command.ExecuteReader())
            {
                // While there are results to get...
                while (reader.Read())
                {
                    // Get first and last name as strings
                    firstName = reader[0].ToString();
                    lastName = reader[1].ToString();

                    // Get first name and last initil in one string
                    fullName = firstName + " " + lastName[0].ToString().ToUpper() + ".";

                    // Add names to list
                    names.Add(fullName);
                }
            }

            connection.Close();

            // Clear List Contents
            lstProfiles.Items.Clear();
            // And add the new names to the list
            foreach (string name in names)
            {
                lstProfiles.Items.Add(name);
            }
        }

        #endregion
    }
}
