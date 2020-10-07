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
        //enum Difficulty
        //{
        //    EASY = 4,
        //    MEDIUM,
        //    HARD
        //}


        /// <summary>
        /// Enumeration of the available subjects
        /// </summary>
        enum Subject_Theme
        {
            AUSTRALIA,
            FOOD,
            CARS,
            NATURE
        }

        // Settings fields
        private int myDifficulty;
        private int playerCount;
        private Subject_Theme _subject;

        /// <summary>
        /// Property for the difficulty
        /// </summary>
        public int Difficulty
        {
            get => myDifficulty;
            set => myDifficulty = value;
        }


        public Settings()
        {
        }









    }
}
