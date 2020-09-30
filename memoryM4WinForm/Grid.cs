using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memoryM4WinForm
{
    public class Grid
    {


        private frmGame frmGame;

        public Grid(frmGame frmGameInstance)
        {
            this.frmGame = frmGameInstance;
        }


        /// <summary>
        /// Filling the grid of memory cards inside a panel
        /// </summary>
        /// <param name="cardCount">Number of cards that will be displayed regarding the difficulty</param>
        public void FillGrid(int cardCount)
        {

            int gridSize = 0;
            int imageCount = 1;
            int x = 0;
            int y = 0;

            PictureBox pbImageGrid;

            if (cardCount > 0) {
                gridSize = Convert.ToInt32(Math.Sqrt(cardCount));

                for (int colCount = 0; colCount < gridSize; colCount++)
                {
                    for (int rowCount = 0; rowCount < gridSize; rowCount++)
                    {
                        pbImageGrid = new PictureBox();
                        pbImageGrid.Location = new System.Drawing.Point(x, y);
                        pbImageGrid.Size = new System.Drawing.Size(100, 100);
                        pbImageGrid.Image = Properties.Resources.car1;
                        pbImageGrid.Name = "image" + imageCount;

                        frmGame.panMemory.Controls.Add(pbImageGrid);

                        x += 110;
                        imageCount++;
                    }
                    y += 110;
                }


            }
        }



        // DELEGATE CODE EXAMPLE
        /*
        public class MyClass
        {
            Action<String> labelSetter;

            public MyClass(Action<String> labelSetter)
            {
                this.labelSetter = labelSetter;
            }

            public void MyMethod()
            {
                labelSetter("outside");
            }
        }

        public void buttonOut_Click(object sender, EventArgs e)
        {
            var outside = new MyClass(UpdateLabel);
            outside.MyMethod();
        }
        */


    }
}
