using System.Collections.Generic;

namespace LiarsDice
{
    /// <summary>
    /// Contains all of the information about a player in the current game
    /// </summary>
    public class Player
    {

        #region Public Properties

        // The information about the previous
        public Bet bet = new Bet();

        // A list of the values of the dice a player has
        public List<int> dice = new List<int> { 1, 1, 1, 1, 1};

        // The name of the player
        public string name;

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Player(string name)
        {
            this.name = name;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Place a new bet
        /// </summary>
        /// <param name="quantity">The number of dice being bet</param>
        /// <param name="value">The value on the dice being bet</param>
        public void PlaceBet(int quantity, int value)
        {
            // Update the bet
            bet.PlaceBet(quantity, value);
        }

        /// <summary>
        /// Drop the total dice count of the player
        /// </summary>
        public void LoseDie()
        {
            // If the player still has dice...
            if (dice.Count > 0)
            {
                // Remove the last die in the list
                dice.RemoveAt(dice.Count - 1);
            }
        }

        #endregion

    }
}
