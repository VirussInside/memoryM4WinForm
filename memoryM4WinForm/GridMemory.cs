/***********************************************************************************************************************************
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
        // Number of different images available (x2 to know the max grid size)
        private const int IMAGES_AVAILABLE = 8; // This number MUST equal the smallest image count of each subjects to prevent blank images or errors
        
        private static string firstClicked = "";
        private static string secondClicked = "";
        private static int attemptsCount = 0;
        private static frmGame gameInstanceUse;


        /// <summary>
        /// Constructor of GridMemory
        /// </summary>
        /// <param name="frmGameInstance">Instance of the game form</param>
        public GridMemory(frmGame gameInstance)
        {
            gameInstanceUse = gameInstance;
        }

        public string FirstClicked    
        {
            get => firstClicked;
            set => firstClicked = value;
        }

        public string SecondClicked    // the Name property
        {
            get => secondClicked;
            set => secondClicked = value;
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
                        pbImageGrid = new PictureBox();
                        pbImageGrid.Location = new System.Drawing.Point(x, y);
                        pbImageGrid.Size = new System.Drawing.Size(100, 100);
                        pbImageGrid.SizeMode = PictureBoxSizeMode.StretchImage;
                        pbImageGrid.Image = (Image)Properties.Resources.ResourceManager.GetObject(imageList[imageCount]); // Select an image from the the list
                        pbImageGrid.Name = imageList[imageCount];
                        pbImageGrid.Tag = imageCount;
                        pbImageGrid.MouseClick += ProcessClickedImage;
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
        private static void ProcessClickedImage(object sender, MouseEventArgs e)
        {
            PictureBox clickedPic = sender as PictureBox;

            if (firstClicked.Length == 0)
            {
                firstClicked = clickedPic.Name;
            }
            else
            {
                secondClicked = clickedPic.Name;
            }


            if (firstClicked.Length >0 && secondClicked.Length >0)
            {
                if (firstClicked.Equals(secondClicked))
                {
                    MessageBox.Show("YEAH");
                }
                else
                {
                    MessageBox.Show("NOOOOOO");
                }

                firstClicked = "";
                secondClicked = "";
                attemptsCount++;

                // HOW TO ACCESS LABEL IN ANOTHER FORM ? 
                //gameInstanceUse.lbAttempts = attemptsCount;
            }
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
                names.Add( chosenSubject.ToLower() + i);
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
