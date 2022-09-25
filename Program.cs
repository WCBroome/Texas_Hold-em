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
            Testing test = new Testing();
            Deck thisDeck = new Deck();
            thisDeck.DealHands(thisDeck.cards, 4);
            thisDeck.Flop(thisDeck.cards, 4);
            thisDeck.NextCard(thisDeck.cards, 4);
            thisDeck.NextCard(thisDeck.cards, 4);
            test.PrintHandsDict(thisDeck.hands);

            foreach (string i in thisDeck.communCards)
            {
                Console.WriteLine(i);
            }
        }
    }
}
