using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memoryM4WinForm
{
    public class GridMemory
    {


        private frmGame frmGameInstance;

        public GridMemory(frmGame frmGameInstance)
        {
            this.frmGameInstance = frmGameInstance;
        }


        /// <summary>
        /// Filling the grid of memory cards inside a panel
        /// </summary>
        /// <param name="cardCount">Number of cards that will be displayed regarding the difficulty</param>
        public static void FillGrid(int cardCount, Panel panMemory)
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
                        pbImageGrid.Image = Properties.Resources.car1;
                        pbImageGrid.Name = "image" + imageCount;
                        pbImageGrid.Tag = imageCount;
                        pbImageGrid.MouseClick += ProcessClickedImage;
                        panMemory.Controls.Add(pbImageGrid);
                        
                        x += 110;
                        imageCount++;
                    }
                    x = 0;
                    y += 110;
                }


            }
        }

        private static void ProcessClickedImage(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Clicki clickkk");
        }

        private string GetRandomImage(string defaultSubject)
        {
            String imageName = defaultSubject;
            //int drawableId = getResources().getIdentifier(
            //                    name,               // the name of the resource
            //                    "drawable",         // type of resource
            //                    getPackageName())); // your app package name
            //imageView.setImageResource(drawableId);
            return imageName;
        }


    }
}
