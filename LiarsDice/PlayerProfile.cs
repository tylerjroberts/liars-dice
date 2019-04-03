namespace LiarsDice
{
    /// <summary>
    /// Holds all the information about a player and their statistics
    /// </summary>
    public class PlayerProfile
    {
        #region Public Properties

        // The combined first and last name of the player
        public string fullName;

        // The player's first name
        public string firstName;

        // The player's last name
        public string lastName;

        // The number of games the player has completed
        public int gamesPlayed;

        // The number of games the player has won
        public int gamesWon;

        // The number of games the player has lost
        public int gamesLost;

        // The number of bets the player has placed
        public int betsPlaced;

        // The number of times the player has called another player a liar
        public int liarsCalled;

        // The number of times the player has been called a liar and lost
        public int betsLost;

        // The number of times a player has been called a liar and won
        public int betsWon;

        // The number of dice the player has lost
        public int diceLost;

        // The number of dice the player has forced another player to lose
        public int diceTaken;

        // the number of times the player has won a game without losing a die
        public int perfectGames;

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor with all Parameters
        /// Loaded from a file for stats screen and post-game update
        /// </summary>
        /// <param name="fullName">The combined first and last name of the player</param>
        /// <param name="firstName">The player's first name</param>
        /// <param name="lastName">The player's last name</param>
        /// <param name="gamesPlayed">The number of games the player has completed</param>
        /// <param name="gamesWon">The number of games the player has won</param>
        /// <param name="gamesLost">The number of games the player has lost</param>
        /// <param name="betsPlaced">The number of bets the palyer has placed</param>
        /// <param name="liarsCalled">The number of times the player has called another player a liar</param>
        /// <param name="betsLost">The number of times the player has been called a liar and lost</param>
        /// <param name="betsWon">The number of times the player has been called a liar and won</param>
        /// <param name="diceLost">The number of dice the player has lost</param>
        /// <param name="diceTaken">The number of dice the player has forced another player to lose</param>
        /// <param name="perfectGames">The number of times the player has won a game without losing a die</param>
        /// 
        public PlayerProfile(string fullName, string firstName, string lastName, int gamesPlayed, int gamesWon, int gamesLost, int betsPlaced, int liarsCalled, int betsLost, int betsWon, int diceLost, int diceTaken, int perfectGames)
        {
            this.fullName = fullName;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gamesPlayed = gamesPlayed;
            this.gamesWon = gamesWon;
            this.gamesLost = gamesLost;
            this.betsPlaced = betsPlaced;
            this.liarsCalled = liarsCalled;
            this.betsLost = betsLost;
            this.betsWon = betsWon;
            this.diceLost = diceLost;
            this.diceTaken = diceTaken;
            this.perfectGames = perfectGames;
        }

        /// <summary>
        /// Blank Constructor used for stat tracking during game
        /// </summary>
        public PlayerProfile()
        {
            this.fullName = "";
            this.firstName = "";
            this.lastName = "";
            this.gamesPlayed = 0;
            this.gamesWon = 0;
            this.gamesLost = 0;
            this.betsPlaced = 0;
            this.liarsCalled = 0;
            this.betsLost = 0;
            this.betsWon = 0;
            this.diceLost = 0;
            this.diceTaken = 0;
            this.perfectGames = 0;
        }

        #endregion
    }
}
