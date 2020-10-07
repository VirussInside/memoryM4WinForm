using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memoryM4WinForm
{
    class Settings
    {
        /// <summary>
        /// Enumeration of possible difficulties, easy starts at 4 as its the minimum 4x4 grid of images
        /// </summary>
        enum Difficulty
        {
            EASY = 4,
            MEDIUM,
            HARD
        }


        /// <summary>
        /// Enumeration of the available subjects
        /// </summary>
        enum Subject
        {
            AUSTRALIA,
            FOOD,
            CARS,
            NATURE
        }

        // Settings fields
        private Difficulty myDifficulty;
        private int playerCount;

        public Settings() {
        }









    }
}
