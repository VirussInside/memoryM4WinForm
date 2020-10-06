﻿/***********************************************************************************************************************************
 *  
 *  M4 - DIVTEC - INFEE3 
 *  Author  :   Artiom Vallat
 *  Date    :   01.10.2020
 * 
 *  Description : 
 *      This class handles all the process from generating imagenames to loading the grid with images
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
        
        private const int IMAGES_AVAILABLE = 8; // This number MUST equal the smallest image count of each subjects to prevent blank images or errors (x2 to know total cards count of the game)
        private const string CARD_BACK_NAME = "memorize_back_card"; // Name of the image resource for the cards back


        private static PictureBox pbClicked1;
        private static PictureBox pbClicked2;

        private static int attemptsCount = 0;
        private static int clickCount = 0;
        private static frmGame gameInstanceUse;


        /// <summary>
        /// Constructor of GridMemory
        /// </summary>
        /// <param name="frmGameInstance">Instance of the game form</param>
        public GridMemory(frmGame gameInstance)
        {
            gameInstanceUse = gameInstance;
        }

        /// <summary>
        /// Filling the grid of memory cards inside a panel
        /// </summary>
        /// <param name="cardCount">Number of cards that will be displayed regarding the difficulty</param>
        public void FillGrid(int cardCount, Panel panMemory, string SubjectChoice)
        {
            int gridSize = 0;
            int imageCount = 0;
            int x = 0;
            int y = 0;
            List<string> imageList = GenerateImageNames(SubjectChoice);

            PictureBox pbImageGrid;

            if (cardCount > 0) {
                gridSize = Convert.ToInt32(Math.Sqrt(cardCount));

                for (int rowCount = 0; rowCount < gridSize; rowCount++)
                {
                    for (int colCount = 0; colCount < gridSize; colCount++)
                        {
                        pbImageGrid = new PictureBox
                        {
                            Location = new System.Drawing.Point(x, y),
                            Size = new System.Drawing.Size(100, 100),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Image = (Image)Properties.Resources.ResourceManager.GetObject("memorize_back_card"), // Puts the back image
                            Name = imageList[imageCount], // Put the right name of the image
                            Tag = imageCount
                        };
                        pbImageGrid.MouseClick += ProcessClickedImageAsync;
                        pbImageGrid.BackColor = Color.Azure;
                        panMemory.Controls.Add(pbImageGrid);

                        x += 110;
                        imageCount++;
                    }
                    x = 0; // Reset position for the first image of the next row
                    y += 110;
                }
            }
        }

        /// <summary>
        /// Perform actions when an picturebox image is clicked
        /// </summary>
        /// <param name="sender">Picturebox clicked</param>
        /// <param name="e"></param>
        private static void ProcessClickedImageAsync(object sender, MouseEventArgs e)
        {
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
                    if (pbClicked1.Tag != ((PictureBox)sender).Tag)
                    {
                        pbClicked2 = (PictureBox)sender;
                        if (CompareCards(pbClicked1.Name, pbClicked2.Name)) // Same images
                        {
                            // Remove card from game and show label of attempts and points TODO ARTIOM
                        }
                        else // Different images so hide them again
                        {
                            System.Threading.Thread.Sleep(2500); // wait for 2.5 seconds to let some time to remeber the position of the card

                            // HOW TO BLOCK FOR ANOTHER CLICK DURING WAIT ? 

                            HideCards(pbClicked1, pbClicked2);
                        }
                        clickCount = 0;
                        attemptsCount++;
                    }
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Changes the regular back image to the right theme image
        /// </summary>
        /// <param name="pictureBox">Clicked picturebox</param>
        public static void ShowCard(PictureBox pictureBox) {
            pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(pictureBox.Name);
            pictureBox.Refresh();
        }

        /// <summary>
        /// Changes the card back to default image
        /// </summary>
        /// <param name="pbFirst">First picturebox</param>
        /// <param name="pbSecond">Second picturebox</param>
        public static void HideCards(PictureBox pbFirst, PictureBox pbSecond)
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
        public static Boolean CompareCards(String nameOne, String nameTwo) {
            return nameOne.Equals(nameTwo);
        }



        /// <summary>
        /// Create the list of image names with a duplicate of each
        /// </summary>
        /// <param name="chosenSubject">Name of the chosen subject</param>
        /// <returns>List of unsorted imagenames with the same name twice</returns>
        private static List<string> GenerateImageNames(String chosenSubject)
        {
            List<string> names = new List<string>();
            for (int i = 0; i < IMAGES_AVAILABLE; i++)
            {
                names.Add(chosenSubject.ToLower() + i);
            }
            
            // Duplicate values of the list to have the same name twice
            names = names.SelectMany(t => Enumerable.Repeat(t, 2)).ToList();

            return ShuffleImages(names); // Shuffle image before returning
        }

        /// <summary>
        /// Shuffle a list of imagenames strings
        /// </summary>
        /// <param name="imageNames">List of imagenames</param>
        /// <returns>List of shuffled strings</returns>
        private static List<string> ShuffleImages(List<string> imageNames)
        {
            List<string> shuffledImages = imageNames;
            shuffledImages = imageNames.OrderBy(x => Guid.NewGuid().ToString()).ToList();

            return shuffledImages;
        }
    }
}
