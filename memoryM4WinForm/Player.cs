using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memoryM4WinForm
{
    public class Player
    {

        public Player(string name = "Player") {
            playerName = name;
        }

        public int playerScore { get; set; }
        public string playerName { get; set; }
        public int playerNumber { get; set; }
        public int playerAttempts { get; set; }


    }
}
