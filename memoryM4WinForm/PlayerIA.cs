using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memoryM4WinForm
{
    class PlayerIA : Player
    {


        public Random randomGen = new Random();
        

        /// <summary>
        ///  Constructor of an IA player
        /// </summary>
        public PlayerIA(string name)
        {
            playerName = name;
        }


        /// <summary>
        /// Computer plays by choosing two tags of cards
        /// </summary>
        /// <param name="maxTag"></param>
        /// <returns>List of selected tags</returns>
        public List<int> PlaySelf(List<int> availableTags) {
            List<int> cardsTagList = new List<int>();
            int indexTag;



            if (availableTags.Count() == 2) {
                Console.WriteLine("Plus que 2");
            }

            do
            {
                // Generate two random indexes to pick from the list of available tags
                indexTag = randomGen.Next(0, availableTags.Count());
                if (!cardsTagList.Contains(availableTags[indexTag]))
                    cardsTagList.Add(availableTags[indexTag]);

            } while (cardsTagList.Count < 2);
            
            return cardsTagList;
        }

    }
}
