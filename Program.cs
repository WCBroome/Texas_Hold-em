using System;
using System.Runtime.CompilerServices;

namespace Texas_Hold_em
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Deck thisDeck = new Deck();
            thisDeck.cards = thisDeck.Shuffle();
            foreach (string i in thisDeck.cards)
            {
                Console.WriteLine(i);
            }
        }
    }
}
