using System;
using System.Collections.Generic;
using System.Linq;

namespace Texas_Hold_em
{
    internal class Deck
    {
        public List<string> cards = new List<string>() {"♠A", "♠2", "♠3", "♠4", "♠5", "♠6", "♠7", "♠8", "♠9", "♠10", "♠J", "♠Q", "♠K",
                          "♥A", "♥2", "♥3", "♥4", "♥5", "♥6", "♥7", "♥8", "♥9", "♥10", "♥J", "♥Q", "♥K",
                          "♣A", "♣2", "♣3", "♣4", "♣5", "♣6", "♣7", "♣8", "♣9", "♣10", "♣J", "♣Q", "♣K",
                          "♦A", "♦2", "♦3", "♦4", "♦5", "♦6", "♦7", "♦8", "♦9", "♦10", "♦J", "♦Q", "♦K"

                };

        public Dictionary<int, List<string>> hands = new Dictionary<int, List<string>>();

        public List<string> communCards = new List<string>();


        public List<string> Shuffle()
		{
			Random random = new Random();
			return cards.OrderBy(x => random.Next()).ToList();
        }


        public Dictionary<int, List<string>> DealHands(List<string> thisDeck, int numOfPlayers)
        {
            foreach (int j in Enumerable.Range(1, numOfPlayers))
            {
                List<string> thisHand = new List<string>();
                foreach (int n in Enumerable.Range((j * 2), 2))
                {
                    thisHand.Add(thisDeck[n]);
                }
                hands.Add(j, thisHand);
            }
            return hands;
        }
        

        public void Flop(List<string> cards, int numOfPlayers)
        {
            foreach (int i in Enumerable.Range((numOfPlayers * 2 + 2), 3))
            {
                communCards.Add(cards[i]);
            }
        }

        public void NextCard(List<string> cards, int numOfPlayers)
        {
            foreach (int i in Enumerable.Range((numOfPlayers * 2 + 2 + communCards.Count), 1))
            {
                communCards.Add(cards[i]);
            }
        }
    }
}
