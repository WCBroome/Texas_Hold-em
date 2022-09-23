using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Texas_Hold_em
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            Deck thisDeck = new Deck();
            thisDeck.cards = thisDeck.Shuffle();
            thisDeck.DealHands(thisDeck.cards, 4);

            string output = "";
            foreach (KeyValuePair<int, List<string>> kvp in thisDeck.hands)
            {
                output += string.Format("Player = {0}, Hand = {1}", kvp.Key, String.Join(", ", kvp.Value.ToArray()));
                output += "\n";
            }
            Console.WriteLine(output);
        }

        
    }
}
