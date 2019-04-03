using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LiarsDice
{
    public partial class frmGame : Form
    {
        #region Variables, Lists, Classes

        // Transfer player profile
        PlayerProfile currentPlayerProfile;

        // Create Player for each player at the table
        Player player1 = new Player("Player 1");
        Player player2 = new Player("Player 2");
        Player player3 = new Player("Player 3");
        Player player4 = new Player("Player 4");
        Player player5 = new Player("Player 5");

        // Create an additional Player to serve as a placeholder for the currentBet
        Player currentBet = new Player("placeholder");

        // Track the current turn per hand
        int currentTurn = 1;

        #endregion

        public frmGame(PlayerProfile selectedPlayer)
        {
            InitializeComponent();

            // Load the currently selected player
            currentPlayerProfile = selectedPlayer;
        }

        #region Buttons

        #region Start Button

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            startGame();
        }

        #endregion

        #region Place Bet Button

        /// <summary>
        /// Place the bet that is designated by the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlaceBet_Click(object sender, EventArgs e)
        {
            nextTurn();
        }

        #endregion

        #region Call Liar Button

        /// <summary>
        /// Call previous player a liar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCallLiar_Click(object sender, EventArgs e)
        {
            callLiar(player1);
        }

        #endregion

        #endregion

        #region Functions

        /// <summary>
        /// Roll the dice multiple times
        /// </summary>
        /// <param name="rolls">The number of times to roll the dice</param>
        void animateDice(int rolls)
        {
            for ( int i = 0; i < rolls; i++ )
            {
                rollDice();
                wait(90);
            }
        }

        /// <summary>
        /// Set a random value for each die on the table
        /// </summary>
        void rollDice()
        {
            // Set random selector for rolling dice
            Random rndSelector = new Random();
            int selector;

            // Create list of all dice on the table
            List<PictureBox> dice = new List<PictureBox> {
                picPlayerDice1, picPlayerDice2, picPlayerDice3, picPlayerDice4, picPlayerDice5,
                picCPU2Dice1, picCPU2Dice2, picCPU2Dice3, picCPU2Dice4, picCPU2Dice5,
                picCPU3Dice1, picCPU3Dice2, picCPU3Dice3, picCPU3Dice4, picCPU3Dice5,
                picCPU4Dice1, picCPU4Dice2, picCPU4Dice3, picCPU4Dice4, picCPU4Dice5,
                picCPU5Dice1, picCPU5Dice2, picCPU5Dice3, picCPU5Dice4, picCPU5Dice5
            };

            // Loop through all dice on the table and...
            foreach ( PictureBox die in dice )
            {
                // Get a random value (1-6) for each die
                selector = rndSelector.Next(1, 7);

                // Set the tag to the value of the die and the image to reflect the value
                switch ( selector )
                {
                    case 1:
                        die.Tag = 1;
                        die.Image = Properties.Resources.plainWildcard;
                        break;
                    case 2:
                        die.Tag = 2;
                        die.Image = Properties.Resources.plainTwo;
                        break;
                    case 3:
                        die.Tag = 3;
                        die.Image = Properties.Resources.plainThree;
                        break;
                    case 4:
                        die.Tag = 4;
                        die.Image = Properties.Resources.plainFour;
                        break;
                    case 5:

                        die.Tag = 5;
                        die.Image = Properties.Resources.plainFive;
                        break;
                    case 6:
                        die.Tag = 6;
                        die.Image = Properties.Resources.plainSix;
                        break;
                }

            }

            updateDiceLists();
        }

        /// <summary>
        /// When dice are rolled, update all of the player's lists
        /// </summary>
        void updateDiceLists()
        {
            if ( player1.dice.Count >= 1 )
            {
                player1.dice[0] = (int)picPlayerDice1.Tag;
            }
            if ( player1.dice.Count >= 2 )
            {
                player1.dice[1] = (int)picPlayerDice2.Tag;
            }
            if ( player1.dice.Count >= 3 )
            {
                player1.dice[2] = (int)picPlayerDice3.Tag;
            }
            if ( player1.dice.Count >= 4 )
            {
                player1.dice[3] = (int)picPlayerDice4.Tag;
            }
            if ( player1.dice.Count >= 5 )
            {
                player1.dice[4] = (int)picPlayerDice5.Tag;
            }
            if ( player2.dice.Count >= 1 )
            {
                player2.dice[0] = (int)picCPU2Dice1.Tag;
            }
            if ( player2.dice.Count >= 2 )
            {
                player2.dice[1] = (int)picCPU2Dice2.Tag;
            }
            if ( player2.dice.Count >= 3 )
            {
                player2.dice[2] = (int)picCPU2Dice3.Tag;
            }
            if ( player2.dice.Count >= 4 )
            {
                player2.dice[3] = (int)picCPU2Dice4.Tag;
            }
            if ( player2.dice.Count >= 5 )
            {
                player2.dice[4] = (int)picCPU2Dice5.Tag;
            }
            if ( player3.dice.Count >= 1 )
            {
                player3.dice[0] = (int)picCPU3Dice1.Tag;
            }
            if ( player3.dice.Count >= 2 )
            {
                player3.dice[1] = (int)picCPU3Dice2.Tag;
            }
            if ( player3.dice.Count >= 3 )
            {
                player3.dice[2] = (int)picCPU3Dice3.Tag;
            }
            if ( player3.dice.Count >= 4 )
            {
                player3.dice[3] = (int)picCPU3Dice4.Tag;
            }
            if ( player3.dice.Count >= 5 )
            {
                player3.dice[4] = (int)picCPU3Dice5.Tag;
            }
            if ( player4.dice.Count >= 1 )
            {
                player4.dice[0] = (int)picCPU4Dice1.Tag;
            }
            if ( player4.dice.Count >= 2 )
            {
                player4.dice[1] = (int)picCPU4Dice2.Tag;
            }
            if ( player4.dice.Count >= 3 )
            {
                player4.dice[2] = (int)picCPU4Dice3.Tag;
            }
            if ( player4.dice.Count >= 4 )
            {
                player4.dice[3] = (int)picCPU4Dice4.Tag;
            }
            if ( player4.dice.Count >= 5 )
            {
                player4.dice[4] = (int)picCPU4Dice5.Tag;
            }
            if ( player5.dice.Count >= 1 )
            {
                player5.dice[0] = (int)picCPU5Dice1.Tag;
            }
            if ( player5.dice.Count >= 2 )
            {
                player5.dice[1] = (int)picCPU5Dice2.Tag;
            }
            if ( player5.dice.Count >= 3 )
            {
                player5.dice[2] = (int)picCPU5Dice3.Tag;
            }
            if ( player5.dice.Count >= 4 )
            {
                player5.dice[3] = (int)picCPU5Dice4.Tag;
            }
            if ( player5.dice.Count >= 5 )
            {
                player5.dice[4] = (int)picCPU5Dice5.Tag;
            }
        }

        /// <summary>
        /// Change all DPU dice on the table to question marks to hide the values without changing the values
        /// </summary>
        void hideCPUDice()
        {
            // Create list of all CPUs' dice on the table
            List<PictureBox> dice = new List<PictureBox> {
                picCPU2Dice1, picCPU2Dice2, picCPU2Dice3, picCPU2Dice4, picCPU2Dice5,
                picCPU3Dice1, picCPU3Dice2, picCPU3Dice3, picCPU3Dice4, picCPU3Dice5,
                picCPU4Dice1, picCPU4Dice2, picCPU4Dice3, picCPU4Dice4, picCPU4Dice5,
                picCPU5Dice1, picCPU5Dice2, picCPU5Dice3, picCPU5Dice4, picCPU5Dice5
            };

            // Loop through all dice on the table
            foreach ( PictureBox die in dice )
            {
                // Change image to unknown to hide values without changing the values
                die.Image = Properties.Resources.plainUnknown;
            }
        }

        /// <summary>
        /// Change the image of all dice from a question mark to reflect their actual value
        /// </summary>
        void revealCPUDice()
        {
            // Create list of all CPUs' dice on the table
            List<PictureBox> dice = new List<PictureBox> {
                picCPU2Dice1, picCPU2Dice2, picCPU2Dice3, picCPU2Dice4, picCPU2Dice5,
                picCPU3Dice1, picCPU3Dice2, picCPU3Dice3, picCPU3Dice4, picCPU3Dice5,
                picCPU4Dice1, picCPU4Dice2, picCPU4Dice3, picCPU4Dice4, picCPU4Dice5,
                picCPU5Dice1, picCPU5Dice2, picCPU5Dice3, picCPU5Dice4, picCPU5Dice5
            };

            // Loop through all dice on the table
            foreach ( PictureBox die in dice )
            {
                // Use their tag and update the image
                // Changing each dice to red or green depending on the bet
                switch ( die.Tag )
                {
                    case 1:
                        die.Image = Properties.Resources.goodWildcard;
                        break;
                    case 2:
                        die.Image = Properties.Resources.badTwo;
                        if ( currentBet.bet.value == 2 )
                            die.Image = Properties.Resources.goodTwo;
                        break;
                    case 3:
                        die.Image = Properties.Resources.badThree;
                        if ( currentBet.bet.value == 3 )
                            die.Image = Properties.Resources.goodThree;
                        break;
                    case 4:
                        die.Image = Properties.Resources.badFour;
                        if ( currentBet.bet.value == 4 )
                            die.Image = Properties.Resources.goodFour;
                        break;
                    case 5:
                        die.Image = Properties.Resources.badFive;
                        if ( currentBet.bet.value == 5 )
                            die.Image = Properties.Resources.goodFive;
                        break;
                    case 6:
                        die.Image = Properties.Resources.badSix;
                        if ( currentBet.bet.value == 6 )
                            die.Image = Properties.Resources.goodSix;
                        break;
                }
            }
        }

        /// <summary>
        /// Timer Function
        /// Written by Said
        /// Found on StackOverflow
        /// </summary>
        /// <param name="milliseconds">The number of milliseconds to wait</param>
        void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if ( milliseconds == 0 || milliseconds < 0 )
                return;
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) => {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while ( timer1.Enabled )
            {
                Application.DoEvents();
            }
        }

        /// <summary>
        /// Loop through all players turns until it is the user's turn again
        /// </summary>
        private void nextTurn()
        {
            // Stores a value (0-4) to represent who's turn it currently is.
            int playerTurnPosition = 1;

            int currentOdds = getOdds(currentBet);

            // Main Game Loop
            while ( playerTurnPosition <= 5 )
            {
                // Determine who's turn it is
                switch ( playerTurnPosition )
                {
                    // Player 1's Turn
                    case 1:
                        // Determine intended bet an update the player's bet
                        if ( numDice1.Value > 0 )
                        {
                            player1.PlaceBet((int)numDice1.Value, 1);
                        } else if ( numDice2.Value > 0 )
                        {
                            player1.PlaceBet((int)numDice2.Value, 2);
                        } else if ( numDice3.Value > 0 )
                        {
                            player1.PlaceBet((int)numDice3.Value, 3);
                        } else if ( numDice4.Value > 0 )
                        {
                            player1.PlaceBet((int)numDice4.Value, 4);
                        } else if ( numDice5.Value > 0 )
                        {
                            player1.PlaceBet((int)numDice5.Value, 5);
                        } else if ( numDice6.Value > 0 )
                        {
                            player1.PlaceBet((int)numDice6.Value, 6);
                        }

                        // Submit the bet
                        updateCurrentBet(player1);

                        pnlPlaceYourBet.Visible = false;
                        break;

                    // Player 2's Turn
                    case 2:
                        // Give player time to see the board before a new turn is taken
                        wait(1000);
                        if ( player2.dice.Count > 0 )
                        {
                            // If there is less than a 35% chance of the bet being true...
                            if ( currentOdds < 35 )
                            {
                                // Call LIAR!
                                callLiar(player2);
                                // Break the while loop and set up next turn
                                pnlPlaceYourBet.Visible = true;
                                currentBet.bet.quantity = 0;
                                currentBet.bet.value = 0;
                                animateDice(10);
                                hideCPUDice();
                                return;
                            }
                            // Otherwise, place a new bet by...
                            else
                            {
                                // Setting the current player's bet to the current bet
                                player2.bet.quantity = currentBet.bet.quantity;
                                int newBetOdds = 0;
                                Random increaseAmount = new Random();

                                // Waiting a random amount of time to immitate thinking
                                wait(increaseAmount.Next(1000, 5000));
                                bool betPlaced = false;

                                //Loop through available bets until a bet is randomly found
                                for ( int i = 1; i <= 6 && !betPlaced; i++ )
                                {
                                    // Set bet value to the curren iteration
                                    player2.bet.value = i;

                                    // Attempt 15 random new bets and test their quantities
                                    for ( int j = 0; j < 15; j++ )
                                    {
                                        //Reset the current quantity
                                        player2.bet.quantity = currentBet.bet.quantity;

                                        // Get a random new quantity up to four more than the current bet
                                        player2.bet.quantity += increaseAmount.Next(0, 2);

                                        // Test the odds of the current bet being true
                                        newBetOdds = getOdds(player2);

                                        // If the odds are at least 30%...
                                        if ( newBetOdds >= 30 )
                                        {
                                            // Place the bet and break the loop
                                            player2.PlaceBet(player2.bet.quantity, player2.bet.value);
                                            betPlaced = true;
                                            updateCurrentBet(player2);
                                            break;
                                        }
                                    }
                                }

                                // If the loop has completed and no bet was placed, just call LIAR!
                                if ( !betPlaced )
                                    callLiar(player2);
                            }
                        }
                        break;

                    // Player 3's Turn
                    case 3:
                        // Give player time to see the board before a new turn is taken
                        wait(1000);
                        if ( player3.dice.Count > 0 )
                        {
                            // If there is less than a 35% chance of the bet being true...
                            if ( currentOdds < 35 )
                            {
                                // Call LIAR!
                                callLiar(player3);
                                // Break the while loop and set up next turn
                                pnlPlaceYourBet.Visible = true;
                                currentBet.bet.quantity = 0;
                                currentBet.bet.value = 0;
                                animateDice(10);
                                hideCPUDice();
                                return;
                            }
                            // Otherwise, place a new bet by...
                            else
                            {
                                // Setting the current player's bet to the current bet
                                player3.bet.quantity = currentBet.bet.quantity;
                                int newBetOdds = 0;
                                Random increaseAmount = new Random();

                                // Waiting a random amount of time to immitate thinking
                                wait(increaseAmount.Next(1000, 5000));
                                bool betPlaced = false;

                                //Loop through available bets until a bet is randomly found
                                for ( int i = 1; i <= 6 && !betPlaced; i++ )
                                {
                                    // Set bet value to the curren iteration
                                    player3.bet.value = i;

                                    // Attempt 15 random new bets and test their quantities
                                    for ( int j = 0; j < 15; j++ )
                                    {
                                        //Reset the current quantity
                                        player3.bet.quantity = currentBet.bet.quantity;

                                        // Get a random new quantity up to four more than the current bet
                                        player3.bet.quantity += increaseAmount.Next(0, 4);

                                        // Test the odds of the current bet being true
                                        newBetOdds = getOdds(player3);

                                        // If the odds are at least 30%...
                                        if ( newBetOdds > 30 )
                                        {
                                            // Place the bet and break the loop
                                            player3.PlaceBet(player3.bet.quantity, player3.bet.value);
                                            betPlaced = true;
                                            break;
                                        }
                                    }
                                }

                                // If the loop has completed and no bet was placed, just call LIAR!
                                if ( !betPlaced )
                                    callLiar(player3);
                            }
                        }
                        break;

                    // Player 4's Turn
                    case 4:
                        // Give player time to see the board before a new turn is taken
                        wait(1000);
                        if ( player4.dice.Count > 0 )
                        {
                            // If there is less than a 35% chance of the bet being true...
                            if ( currentOdds < 35 )
                            {
                                // Call LIAR!
                                callLiar(player4);
                                // Break the while loop and set up next turn
                                pnlPlaceYourBet.Visible = true;
                                currentBet.bet.quantity = 0;
                                currentBet.bet.value = 0;
                                animateDice(10);
                                hideCPUDice();
                                return;
                            }
                            // Otherwise, place a new bet by...
                            else
                            {
                                // Setting the current player's bet to the current bet
                                player4.bet.quantity = currentBet.bet.quantity;
                                int newBetOdds = 0;
                                Random increaseAmount = new Random();

                                // Waiting a random amount of time to immitate thinking
                                wait(increaseAmount.Next(1000, 5000));
                                bool betPlaced = false;

                                //Loop through available bets until a bet is randomly found
                                for ( int i = 1; i <= 6 && !betPlaced; i++ )
                                {
                                    // Set bet value to the curren iteration
                                    player4.bet.value = i;

                                    // Attempt 15 random new bets and test their quantities
                                    for ( int j = 0; j < 15; j++ )
                                    {
                                        //Reset the current quantity
                                        player4.bet.quantity = currentBet.bet.quantity;

                                        // Get a random new quantity up to four more than the current bet
                                        player4.bet.quantity += increaseAmount.Next(0, 4);

                                        // Test the odds of the current bet being true
                                        newBetOdds = getOdds(player4);

                                        // If the odds are at least 30%...
                                        if ( newBetOdds > 30 )
                                        {
                                            // Place the bet and break the loop
                                            player4.PlaceBet(player4.bet.quantity, player4.bet.value);
                                            betPlaced = true;
                                            break;
                                        }
                                    }
                                }

                                // If the loop has completed and no bet was placed, just call LIAR!
                                if ( !betPlaced )
                                    callLiar(player4);
                            }
                        }
                        break;

                    // Player 5's Turn
                    case 5:
                        // Give player time to see the board before a new turn is taken
                        wait(1000);
                        if ( player5.dice.Count > 0 )
                        {
                            // If there is less than a 35% chance of the bet being true...
                            if ( currentOdds < 35 )
                            {
                                // Call LIAR!
                                callLiar(player5);
                                // Break the while loop and set up next turn
                                pnlPlaceYourBet.Visible = true;
                                currentBet.bet.quantity = 0;
                                currentBet.bet.value = 0;
                                animateDice(10);
                                hideCPUDice();
                                return;
                            }
                            // Otherwise, place a new bet by...
                            else
                            {
                                // Setting the current player's bet to the current bet
                                player5.bet.quantity = currentBet.bet.quantity;
                                int newBetOdds = 0;
                                Random increaseAmount = new Random();

                                // Waiting a random amount of time to immitate thinking
                                wait(increaseAmount.Next(1000, 5000));
                                bool betPlaced = false;

                                //Loop through available bets until a bet is randomly found
                                for ( int i = 1; i <= 6 && !betPlaced; i++ )
                                {
                                    // player5 bet value to the curren iteration
                                    player2.bet.value = i;

                                    // Attempt 15 random new bets and test their quantities
                                    for ( int j = 0; j < 15; j++ )
                                    {
                                        //Reset the current quantity
                                        player5.bet.quantity = currentBet.bet.quantity;

                                        // Get a random new quantity up to four more than the current bet
                                        player5.bet.quantity += increaseAmount.Next(0, 4);

                                        // Test the odds of the current bet being true
                                        newBetOdds = getOdds(player5);

                                        // If the odds are at least 30%...
                                        if ( newBetOdds > 30 )
                                        {
                                            // Place the bet and break the loop
                                            player5.PlaceBet(player5.bet.quantity, player5.bet.value);
                                            betPlaced = true;
                                            break;
                                        }
                                    }
                                }

                                // If the loop has completed and no bet was placed, just call LIAR!
                                if ( !betPlaced )
                                    callLiar(player5);
                            }
                        }
                        break;
                }
                // Move to the next player
                currentTurn++;
                playerTurnPosition++;
                updateValidOptions();
            }

            // Reveal the player's controls
            pnlPlaceYourBet.Visible = true;
        }

        /// <summary>
        /// Stops current hand and determines a winner
        /// </summary>
        /// <param name="currentPlayer">The player who calls liar</param>
        private void callLiar(Player currentPlayer)
        {
            // Notify the player somebody has called LIAR!
            MessageBox.Show(currentPlayer.name + " has called LIAR!", "LIAR!", MessageBoxButtons.OK);

            // Reveal all of the dice
            revealCPUDice();

            // Get count of correct dice
            int actualQuantity = 0;
            List<Player> players = new List<Player> { player1, player2, player3, player4, player5 };

            // For each player
            foreach ( Player player in players )
            {
                // For each die the player has
                foreach ( int die in player.dice )
                {
                    // Check if the die is a applicable to the bet
                    if ( die == currentBet.bet.value || die == 1 )
                        actualQuantity++;
                }
            }

            // If the bet was a lie...
            if ( actualQuantity < currentBet.bet.quantity )
            {
                // Tell the player
                MessageBox.Show("There were only " + actualQuantity.ToString() + " dice!\nThe bet was a LIE!", "LIAR!", MessageBoxButtons.OK);

                // Determine who placed the bet
                foreach ( Player player in players )
                {
                    // If the player did place the bet...
                    if ( player.name == currentBet.name )
                    {
                        // Take te player's die
                        player.LoseDie();

                        // End the loop
                        break;
                    }
                }
            }
            // Otherwise...
            else
            {
                // Tell the player
                MessageBox.Show("There were actually " + actualQuantity.ToString() + " dice!\nThe bet was TRUE!", "TRUE!", MessageBoxButtons.OK);

                //Take a die from the player who called LIAR!
                currentPlayer.LoseDie();
            }
        }

        /// <summary>
        /// Start the game
        /// </summary>
        private void startGame()
        {
            // Roll The Dice
            animateDice(30);

            // Hide the CPUs' Dice
            hideCPUDice();

            // Toggle the center screen button/panel
            btnStartGame.Visible = false;
            pnlBets.Visible = true;

            // Set the valid bet options
            updateValidOptions();

            // Reveal betting controls
            pnlPlaceYourBet.Visible = true;
        }

        /// <summary>
        /// Determine what the valid betting options are and set the Numeric Up Down controls to reflect it
        /// </summary>
        private void updateValidOptions()
        {
            // Load all of the Numeric Up Down controls into a list
            List<NumericUpDown> bettingDice = new List<NumericUpDown> { numDice1, numDice2, numDice3, numDice4, numDice5, numDice6 };

            // Determine if it is a new hand
            // If it is...
            if ( currentTurn == 1 )
            {
                // Set defaults
                bettingDice[0].Minimum = 0;
                bettingDice[1].Minimum = 0;
                bettingDice[2].Minimum = 0;
                bettingDice[3].Minimum = 0;
                bettingDice[4].Minimum = 0;
                bettingDice[5].Minimum = 0;
                return;
            }

            // Check to see the value of the bet
            // If it is a wildcard...
            if ( currentBet.bet.value == 1 )
            {
                // Set each of the dice
                bettingDice[0].Minimum = currentBet.bet.quantity + 1;
                bettingDice[1].Minimum = currentBet.bet.quantity * 2;
                bettingDice[2].Minimum = currentBet.bet.quantity * 2;
                bettingDice[3].Minimum = currentBet.bet.quantity * 2;
                bettingDice[4].Minimum = currentBet.bet.quantity * 2;
                bettingDice[5].Minimum = currentBet.bet.quantity * 2;
            }
            // If it is not a wildcard...
            else
            {
                //Set the wildcard value
                bettingDice[0].Minimum = (int)(Math.Ceiling((double)currentBet.bet.quantity / 2));

                // Loop through dice to set the minimum value
                for ( int i = 1; i < 6; i++ )
                {
                    // If the dice is a higher value..
                    if ( i + 1 > currentBet.bet.value )
                    {
                        // Set the minimum quantity to the bet quantity
                        bettingDice[i].Minimum = currentBet.bet.quantity;
                    }
                    // Otherwise...
                    else
                    {
                        // Increase the minimum quantity by one
                        bettingDice[i].Minimum = currentBet.bet.quantity + 1;
                    }
                }
            }

            // Set the maximum value for all betting dice
            foreach ( NumericUpDown option in bettingDice )
            {
                option.Maximum = player1.dice.Count + player2.dice.Count + player3.dice.Count + player4.dice.Count + player5.dice.Count;
            }

        }

        /// <summary>
        /// Update the current bet
        /// </summary>
        /// <param name="newBet">The new bet to be repaced with</param>
        private void updateCurrentBet(Player submittingPlayer)
        {
            // Update the current bet
            currentBet.bet.PlaceBet(submittingPlayer.bet.quantity, submittingPlayer.bet.value);
            currentBet.name = submittingPlayer.name;

            // Update the current bet label
            lblCurrentBetQuantity.Text = currentBet.bet.quantity.ToString();
            lblPlacedByPlayer.Text = currentBet.name;

            // Update the current bet image
            switch ( currentBet.bet.value )
            {
                case 1:
                    picCurrentBetValue.Image = Properties.Resources.plainWildcard;
                    break;
                case 2:
                    picCurrentBetValue.Image = Properties.Resources.plainTwo;
                    break;
                case 3:
                    picCurrentBetValue.Image = Properties.Resources.plainThree;
                    break;
                case 4:
                    picCurrentBetValue.Image = Properties.Resources.plainFour;
                    break;
                case 5:
                    picCurrentBetValue.Image = Properties.Resources.plainFive;
                    break;
                case 6:
                    picCurrentBetValue.Image = Properties.Resources.plainSix;
                    break;
            }
        }

        /// <summary>
        /// Determine the odds of the previous bet being true
        /// </summary>
        private int getOdds(Player currentPlayer)
        {
            // If no bet is placed, cancel calculation
            if ( currentBet.bet.value == 0 )
                return 100;

            // The odds of the current bet being true
            int odds = 0;

            // The total number of dice on the table
            int totalDice = player1.dice.Count + player2.dice.Count + player3.dice.Count + player4.dice.Count + player5.dice.Count;

            // The adjust quantity and total dice after accounting for the player's hand
            int adjustedBetQuantity = currentBet.bet.quantity;
            int adjustedTotal = totalDice - currentPlayer.dice.Count;
            foreach ( int die in currentPlayer.dice )
            {
                if ( die == currentBet.bet.value && adjustedBetQuantity != 1)
                {
                    adjustedBetQuantity--;
                }
            }

            if ( currentPlayer.bet.value == 1 )
            {
                // Combination Probability Formula
                odds = (int)(100 * (1 / ((factorial(3 * adjustedTotal)) / (factorial(adjustedBetQuantity) * factorial((3 * adjustedTotal) - adjustedBetQuantity)))));
            } else
            {
                // Combination Probability Formula
                odds = (int)(100 * (1 / ((factorial(6 * adjustedTotal)) / (factorial(adjustedBetQuantity) * factorial((6 * adjustedTotal) - adjustedBetQuantity)))));

            }

            MessageBox.Show("The odds are " + odds.ToString());
            return odds;
        }

        private int factorial(int initialNumber)
        {
            int answer = initialNumber;

            for ( int i = initialNumber - 1; i > 0; i-- )
            {
                answer *= i;
            }

            return answer;
        }

        #endregion


    }
}
