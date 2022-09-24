using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_Hold_em
{
    internal class Chips
    {
        public int pot = new int();

        public Dictionary<int, int> playerChips = new Dictionary<int, int> {};

        public void CreatePlayerChips(int numOfPLayers, int startingMoney)
        {
            foreach (int i in Enumerable.Range(1, numOfPLayers))
            {
                playerChips.Add(i, startingMoney);
            }
        }
    }
}
