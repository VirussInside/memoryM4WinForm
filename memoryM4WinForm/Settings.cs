/***********************************************************************************************************************************
 *  MEMORIZE
 *  M4 - DIVTEC - INFEE3 
 *  Author  :   Artiom Vallat
 *  Date    :   30.10.2020
 * 
 *  Description : 
 *      Class for the settings selected during a the game (player count, diffuclty, subjects)
 * 
 * 
 **********************************************************************************************************************************/

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
        private int myDifficulty;   // Difficulty level
        private int myPlayerCount;  // Number of players during the game
        private int myCardsCount;   // Total of cards in the game
        private string mySubject;   // Subject for the images


        /// <summary>
        /// Settings constructor with default values (Easiest diffuclty, one player and nature subject)
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
