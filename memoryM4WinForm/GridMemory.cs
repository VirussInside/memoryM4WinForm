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
        // Number of different images available
        private const int IMAGES_AVAILABLE = 36;
        
        private frmGame frmGameInstance;

        public GridMemory(frmGame frmGameInstance)
        {
            this.frmGameInstance = frmGameInstance;
        }


        /// <summary>
        /// Filling the grid of memory cards inside a panel
        /// </summary>
        /// <param name="cardCount">Number of cards that will be displayed regarding the difficulty</param>
        public static void FillGrid(int cardCount, Panel panMemory, string SubjectChoice)
        {
            int gridSize = 0;
            int imageCount = 1;
            int x = 0;
            int y = 0;

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
                        pbImageGrid.Image = (Image)Properties.Resources.ResourceManager.GetObject(SubjectChoice+imageCount); // Retrieve an image by its name
                        pbImageGrid.Name = "image" + imageCount;
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

        private static void ProcessClickedImage(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Clicki clickkk");
        }

        private static string GetRandomImage(string imageName)
        {
            //int drawableId = getResources().getIdentifier(
            //                    name,               // the name of the resource
            //                    "drawable",         // type of resource
            //                    getPackageName())); // your app package name
            //imageView.setImageResource(drawableId);
            return imageName;
        }


        /// <summary>
        /// Load all images for the given subject
        /// </summary>
        /// <returns></returns>
        private static string[] LoadImages(String subjectName)
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            string[] imageNames = myAssembly.GetManifestResourceNames();

            foreach (string image in imageNames)
            {
                // Remove image from list if its not part of the subject

                //if (Left(image, 6) != "nature")
                //{
                //    //
                //}

            }

            return imageNames;
        }


    }
}
