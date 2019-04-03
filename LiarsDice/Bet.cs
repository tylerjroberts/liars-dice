using System.Windows.Forms;

namespace LiarsDice
{
    /// <summary>
    /// Information about the bets that are placed
    /// </summary>
    public class Bet
    {

        #region Public Properties

        // Quantity of dice being bet
        public int quantity;

        // Value of dice being bet
        public int value;

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor, defaults to 0 on start of rounds
        /// </summary>
        public Bet()
        {
            quantity = 0;
            value = 0;
        }

        /// <summary>
        /// Custructor that takes all parameters.  Used every turn.
        /// </summary>
        /// <param name="quantity">The quantity of dice being bet</param>
        /// <param name="value">The value on the dice being bet</param>
        public Bet(int quantity, int value)
        {
            this.quantity = quantity;
            this.value = value;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Verify that the bet is a valid bet
        /// </summary>
        /// <param name="quantity">The quantity of dice on the current bet</param>
        /// <param name="value">The value of the dice on the current bet</param>
        /// <param name="previousBet">The previous bet that must be increased</param>
        public void VerifyBet(int quantity, int value, Bet previousBet)
        {
            VerifyQuantity(quantity);
            VerifyValue(value);

            #region Error Checking

            if (previousBet.value == 1 && value == 1)
            {
                if (quantity <= previousBet.quantity)
                {
                    MessageBox.Show("Bet Verification Error\nA bet cannot hold a lesser or equal quantity than a previous bet\nunless the value is increased.\n\nThe application must now close.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            if (previousBet.value == 1 && value != 1)
            {
                if (quantity < previousBet.quantity * 2)
                {
                    MessageBox.Show("Bet Verification Error\nA bet cannot hold a lesser quantity than double the number of Wildcards bet on the previous turn.\n\nThe application must now close.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            if (previousBet.value != 1 && value == 1)
            {
                if (quantity * 2 <= previousBet.quantity)
                {
                    MessageBox.Show("Bet Verification Error\nA bet cannot hold a lesser or equal quantity than half the number of dice bet on the previous turn.\n\nThe application must now close.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            if (previousBet.value != 1 && value != 1)
            {
                if (value == previousBet.value && quantity <= previousBet.quantity)
                {
                    MessageBox.Show("Bet Verification Error\nA bet must be a higher quantity of dice if the value of dice does not change.\n\nThe application must now close.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }

                if (value < previousBet.value)
                {
                    MessageBox.Show("Bet Verification Error\nA bet must be a equal to or higher value than the previous bet unless\n\nthe application must now close.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }

            #endregion
        }

        /// <summary>
        /// Sets the bet to a new bet amount
        /// </summary>
        /// <param name="quantity">The number of dice being bet</param>
        /// <param name="value">The value on the dice being bet</param>
        public void PlaceBet(int quantity, int value)
        {
            VerifyBet(quantity, value, this);

            this.quantity = quantity;
            this.value = value;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Verify that the quantity of dice bet is at least 1 die
        /// </summary>
        /// <param name="quantity">The number of dice bet</param>
        private void VerifyQuantity(int quantity)
        {
            if (quantity < 1)
            {
                MessageBox.Show("Bet Verification Error\nYou must bet a quantity of at least one of any die\n\nThe application must now close.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Verify that the value of dice is between 1 and a 6
        /// </summary>
        /// <param name="value">The value of the dice</param>
        private void VerifyValue(int value)
        {
            if (value < 1 || value > 6)
            {
                MessageBox.Show("Bet Verification Error\nYou must bet a value of 1, 2, 3, 4, 5, or 6.\n\nThe application must now close.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        #endregion
    }
}
