/***********************************************************************************************************************************
 *  MEMORIZE
 *  M4 - DIVTEC - INFEE3 
 *  Author  :   Artiom Vallat
 *  Date    :   30.10.2020
 * 
 *  Description : 
 *      Class of a standard player with his autoproperties
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
    public class Player
    {
        /// <summary>
        /// Constructor of the player
        /// </summary>
        /// <param name="name">Name of the player</param>
        public Player(string name = "Player") {
            playerName = name;
        }


        /// <summary>
        /// Autoproperties for the player
        /// </summary>
        public int playerScore { get; set; }        // Score of the play (counter of found pairs)
        public string playerName { get; set; }      // Name of the player
        public bool playerTie { get; set; }         // Special tie player if everyone has the same score
        public int playerAttempts { get; set; }     // Attempts counter to find the pairs

    }
}
