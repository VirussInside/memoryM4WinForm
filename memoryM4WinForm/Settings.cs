using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memoryM4WinForm
{
    public class Settings
    {

        // Settings fields
        private int myDifficulty;
        private int myPlayerCount;
        private int myCardsCount;
        private string mySubject;


        /// <summary>
        /// Settings constructor
        /// </summary>
        public Settings(int Difficulty = 4, int PlayerCount = 1, string Subject = "nature")
        {
            myDifficulty = Difficulty;
            myPlayerCount = PlayerCount;
            mySubject = Subject;
            myCardsCount = (int)Math.Pow(Difficulty,2);
        }

        /// <summary>
        /// Enumeration of possible difficulties, easy starts at 4 as its the minimum 4x4 grid of images
        /// </summary>
        enum DifficultyLevel
        {
            EASY = 4,
            MEDIUM = 6,
            HARD = 8
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
        /// Property for the subject
        /// </summary>
        public String Subject
        {
            get => mySubject;
            set => mySubject = value;
        }

        /// <summary>
        /// Property for the number of cards
        /// </summary>
        public int CardsCount
        {
            get => myCardsCount;
        }

        /// <summary>
        /// Property for the subject
        /// </summary>
        public int PlayerCount
        {
            get => myPlayerCount;
            set => myPlayerCount = value;
        }










    }
}
