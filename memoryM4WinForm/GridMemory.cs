/***********************************************************************************************************************************
 *  
 *  M4 - DIVTEC - INFEE3 
 *  Author  :   Artiom Vallat
 *  Date    :   30.10.2020
 * 
 *  Description : 
 *      This class handles all the process from generating imagenames to loading the grid with images and all
 *      the interactions that the players can make with the cards.
 * 
 * 
 **********************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memoryM4WinForm
{
    public class GridMemory
    {
        private const int HIGHEST_DIFFICULTY = 8;   // Constant for the highest difficulty value (useful for generating the right amount of cards)

        private int clickCount = 0;             // Click counter to know if 2 cards were clicked
        private int gridCardsCount = 0;         // Counter of all teh cards
        private bool ComputerPlays = false;     // Defines if it's the computer turn to play

        private PictureBox pbClicked1;          // Store the first clicked Picturebox
        private PictureBox pbClicked2;          // Store the second clicked Picturebox
        private frmGame frmGameInstance;        // Main game form to store an instance of the actual game
        private PlayerIA computerPlayer;        // Computer player to store an instance of the IA      
        private Player currentPlayer;           // Store the player that is actually playing


        private const string CARD_BACK_NAME = "memorize_back_card"; // Name of the image resource for the cards back

        /// <summary>
        /// Constructor of GridMemory
        /// </summary>
        /// <param name="frmGameInstance">Instance of the game form</param>
        public GridMemory(frmGame gameInstance)
        {
            frmGameInstance = gameInstance;
        }
       

        /// <summary>
        /// Filling the grid of memory cards inside a panel
        /// </summary>
        /// <param name="cardCount">Number of cards that will be displayed regarding the difficulty</param>
        /// <param name="panMemory">Panel that will contain the cards</param>
        /// <param name="SubjectChoice">Name of the subject for the images</param>
        public void FillGrid(int cardCount, Panel panMemory, string SubjectChoice)
        {
            int gridSize = 0;
            int imageCount = 0;
            int x = 0;
            int y = 0;
            int cardSize = 100;
            int spaceSize = 10;

            gridCardsCount = cardCount;

            List<string> imageList = GenerateImageNames(SubjectChoice, cardCount);

            PictureBox pbImageGrid;

            if (cardCount > 0) {
                gridSize = Convert.ToInt32(Math.Sqrt(cardCount));

                // Adapt the size of the cards to fit in the game form properly
                if (cardCount > 36)
                {
                    cardSize = 90;
                    spaceSize = 5;
                }

                // Creating all pictureboxes with their properties
                for (int rowCount = 0; rowCount < gridSize; rowCount++)
                {
                    for (int colCount = 0; colCount < gridSize; colCount++)
                        {
                        pbImageGrid = new PictureBox
                        {
                            Location = new System.Drawing.Point(x, y),
                            Size = new System.Drawing.Size(cardSize, cardSize),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Image = (Image)Properties.Resources.ResourceManager.GetObject("memorize_back_card"), // Puts the back image
                            Name = imageList[imageCount], // Put the right name of the image
                            Tag = imageCount
                        };
                        pbImageGrid.MouseClick += ProcessClickedImage;
                        pbImageGrid.BackColor = Color.Azure;
                        panMemory.Controls.Add(pbImageGrid);

                        x += (cardSize+ spaceSize);
                        imageCount++;
                    }
                    x = 0; // Reset position for the first image of the next row
                    y += cardSize+ spaceSize;
                }
            }
        }

        /// <summary>
        /// Perform actions when an picturebox image is clicked
        /// </summary>
        /// <param name="sender">Picturebox clicked</param>
        /// <param name="e"></param>
        private void ProcessClickedImage(object sender, MouseEventArgs e)
        {
            if (ComputerPlays)
            {
                ComputerClick();
            }
            else
            {
                ClickImage(sender);
            }
        }

        /// <summary>
        /// Internal process for the computer click
        /// </summary>
        private void ComputerClick() {
            computerPlayer = frmGameInstance.GetCurrentPlayer() as PlayerIA;
            List<int> computerChoices = computerPlayer.PlaySelf(GetVisibleCards());
            foreach (int tag in computerChoices)
            {
                foreach (Control c in frmGameInstance.panMemory.Controls)
                {
                    if (c.Tag.ToString() == tag.ToString())
                    {
                        ClickImage(c);
                        System.Threading.Thread.Sleep(500);
                    }
                }
            }       
        }


       
        /// <summary>
        /// Management of the clicks on the pictureboxes
        /// </summary>
        /// <param name="sender">Clicked picturebox</param>
        private void ClickImage(object sender) {

            currentPlayer = frmGameInstance.GetCurrentPlayer();
            
            // Refresh the labels with the new current player stats
            frmGameInstance.SetTextForLabel(frmGameInstance.GetCurrentPlayer());

            ShowCard((PictureBox)sender); // Turns the card around to show the image
            switch (clickCount)
            {
                // First image clicked
                case 0:
                    pbClicked1 = (PictureBox)sender;
                    clickCount++;
                    break;
                // Second image clicked
                case 1:
                    // Do not allow click on the same picturebox by checking the tags
                    if (pbClicked1.Tag != ((PictureBox)sender).Tag)
                    {
                        currentPlayer.playerAttempts++; // Count the attempt anyway
                        clickCount = 0;
                        pbClicked2 = (PictureBox)sender;

                        if (CompareCards(pbClicked1.Name, pbClicked2.Name)) // Same images
                        {
                            System.Threading.Thread.Sleep(750);
                            pbClicked1.Hide();
                            pbClicked2.Hide();
                            currentPlayer.playerScore++;

                            if (!frmGameInstance.CheckGameFinished())
                            {
                                // Initiate the click again if the computer found a pair
                                if (ComputerPlays) ProcessClickedImage(null, null);
                            }
                            else
                            {
                                frmGameInstance.ShowScore();
                            }
                        }
                        else // Different images so hide them again
                        {
                            System.Threading.Thread.Sleep(1000); // Let the cards visible for a moment to remember the image
                            HideCards(pbClicked1, pbClicked2);
                            frmGameInstance.ChangePlayer();
                            if (frmGameInstance.GetCurrentPlayer() is PlayerIA) 
                            {
                                ComputerPlays = true;
                                ProcessClickedImage(null, null);
                            }
                            else
                            {
                                ComputerPlays = false;
                            }
                        }
                        
                    }
                    break;
                default:
                    break;
            }

            // Refresh the labels with the new current player stats
            frmGameInstance.SetTextForLabel(frmGameInstance.GetCurrentPlayer());
        }





        /// <summary>
        /// Get the tags of all visible pictureboxes
        /// </summary>
        /// <returns>List of tags</returns>
        private List<int> GetVisibleCards()
        {
            List<int> visibleCards = new List<int>();

            foreach (Control c in frmGameInstance.panMemory.Controls)
            {
                if (c.Visible)
                {
                    visibleCards.Add(int.Parse(c.Tag.ToString()));
                    Console.Write(c.Tag.ToString());
                }
            }
            Console.WriteLine();
            return visibleCards;
        }



        /// <summary>
        /// Changes the regular back image to the right theme image
        /// </summary>
        /// <param name="pictureBox">Clicked picturebox</param>
        public void ShowCard(PictureBox pictureBox) {
            pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(pictureBox.Name);
            pictureBox.Refresh();
        }

        /// <summary>
        /// Changes the card back to default image
        /// </summary>
        /// <param name="pbFirst">First picturebox</param>
        /// <param name="pbSecond">Second picturebox</param>
        public void HideCards(PictureBox pbFirst, PictureBox pbSecond)
        {
            pbFirst.Image = (Image)Properties.Resources.ResourceManager.GetObject(CARD_BACK_NAME);
            pbSecond.Image = (Image)Properties.Resources.ResourceManager.GetObject(CARD_BACK_NAME);
            pbFirst.Refresh();
            pbSecond.Refresh();
        }


        /// <summary>
        /// Comparing picturebox's names to know
        /// </summary>
        /// <param name="nameOne">First picturebox's name clicked</param>
        /// <param name="nameTwo">Second picturebox's name cliked</param>
        /// <returns>Boolean value of the comparison</returns>
        public Boolean CompareCards(String nameOne, String nameTwo) {
            return nameOne.Equals(nameTwo);
        }



        /// <summary>
        /// Create the list of names with a duplicate of each to form the pairs
        /// </summary>
        /// <param name="chosenSubject">Name of the chosen subject</param>
        /// <param name="cardCount">Number of different cards to generate</param>
        /// <returns>List of unsorted imagenames with the same name twice</returns>
        private List<string> GenerateImageNames(String chosenSubject, int cardCount)
        {
            // Create a list with all image names available
            List<string> allNames = new List<string>();
            for (int i = 1; i <= HIGHEST_DIFFICULTY*HIGHEST_DIFFICULTY/2; i++) 
            {
                allNames.Add(chosenSubject.ToLower() + i);
                
            }
            allNames = ShuffleImages(allNames); // Randomize the names to never pick the images in the same order

            // Pick the right amount of card names from all the available names
            List<string> names = new List<string>(); 
            for (int j = 0; j < cardCount/2; j++)
            {
                names.Add(allNames[j]);
            }
            
            // Duplicate values of the list to have the same name twice for the pairs
            names = names.SelectMany(t => Enumerable.Repeat(t, 2)).ToList();

            return ShuffleImages(names); // Shuffle images before returning the list to randomise the duplicates
        }

        /// <summary>
        /// Shuffle a list of imagenames strings
        /// </summary>
        /// <param name="imageNames">List of imagenames</param>
        /// <returns>List of shuffled strings</returns>
        private List<string> ShuffleImages(List<string> imageNames)
        {
            List<string> shuffledImages = imageNames;
            shuffledImages = imageNames.OrderBy(x => Guid.NewGuid().ToString()).ToList();

            return shuffledImages;
        }
    }
}
