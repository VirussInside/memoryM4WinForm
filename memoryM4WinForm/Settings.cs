using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memoryM4WinForm
{
    class Settings
    {

        // Settings fields
        private int myDifficulty;
        private int playerCount;
        private int mySubject;


        /// <summary>
        /// Settings constructor
        /// </summary>
        public Settings()
        {
        }

        /// <summary>
        /// Enumeration of possible difficulties, easy starts at 4 as its the minimum 4x4 grid of images
        /// </summary>
        enum DifficultyLevel
        {
            EASY = 4,
            MEDIUM,
            HARD
        }

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

        /// <summary>
        /// Property for the difficulty
        /// </summary>
        public int Difficulty
        {
            get => myDifficulty;
            set => myDifficulty = value;
        }

        /// <summary>
        /// Property for the difficulty
        /// </summary>
        public int Subject
        {
            get => mySubject;
            set => mySubject = value;
        }










    }
}
