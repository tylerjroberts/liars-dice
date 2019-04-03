using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiarsDice
{
    public partial class frmNewProfile : Form
    {
        public frmNewProfile()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create the profile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateProfile_Click(object sender, EventArgs e)
        {
            // If no first name is given...
            if (txtFirstName.Text == string.Empty)
            {
                // Throw an error
                MessageBox.Show("You must enter your first name!");
                // and change focus to txtFirstName Textbox
                txtFirstName.Focus();
            }
            // If no last name is given...
            if (txtLastName.Text == string.Empty)
            {
                // Throw an error
                MessageBox.Show("You must enter your last name!");
                // and change focus to txtLastName Textbox
                txtLastName.Focus();
            }
            // If a first and last name is given...
            if (txtFirstName.Text != string.Empty && txtLastName.Text != string.Empty)
            {
                // Create the profile and add it to the database
                CreateProfile(txtFirstName.Text, txtLastName.Text);
                // and close the window
                this.Close();
            }
        }

        /// <summary>
        /// Upload the data from the textboxes into a new profile in the database
        /// </summary>
        /// <param name="firstName">First name from txtFirstName textbox</param>
        /// <param name="lastName">Last name from txtLastName textbox</param>
        private void CreateProfile(string firstName, string lastName)
        {
            // Set the SQL connection string
            string connectionString = Properties.Settings.Default.dbPlayersConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            // Open the database
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            // Set the command to add the required information
            SqlCommand command = new SqlCommand(
                "INSERT INTO PlayerStats (FirstName, LastName, GamesPlayed, GamesWon, GamesLost, BetsPlaced, LiarsCalled, BetsLost, BetsWon, DiceLost, DiceWon, PerfectGames) " +
                "VALUES ('" + firstName + "', '" + lastName + "', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);",
                connection);

            // Execute the command
            command.ExecuteNonQuery();

            // Close the database
            connection.Close();
        }
    }
}
