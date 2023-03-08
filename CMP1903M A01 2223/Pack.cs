using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        static List<Card> cards;
        public int currentCardIndex = 0;

        public Pack()
        {
            //Initialise the card pack here
            cards = new List<Card>();
            string[] Values = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

            foreach (string suit in suits)
            {
                foreach (string Value in Values)
                {
                    cards.Add(new Card { Suit = suit, Value = Value });
                }
            }
        }



        public bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            Random random = new Random();
            int i;
            int j;
            switch (typeOfShuffle)
            {
                case 1: // Fisher-Yates shuffle
                    for ( i = cards.Count - 1; i >= 1; i--)
                    {
                         j = random.Next(i + 1);
                        Card temp = cards[j];
                        cards[j] = cards[i];
                        cards[i] = temp;
                    }
                    break;
                case 2: // Riffle shuffle
                    List<Card> shuffledCards = new List<Card>();
                    int halfIndex = cards.Count / 2;
                 i = 0;
                 j = halfIndex;

                    while (i < halfIndex && j < cards.Count)
                    {
                        if (random.NextDouble() < 0.5)
                        {
                            shuffledCards.Add(cards[i]);
                            i++;
                        }
                        else
                        {
                            shuffledCards.Add(cards[j]);
                            j++;
                        }
                    }

                    while (i < halfIndex)
                    {
                        shuffledCards.Add(cards[i]);
                        i++;
                    }

                    while (j < cards.Count)
                    {
                        shuffledCards.Add(cards[j]);
                        j++;
                    }

                    cards = shuffledCards;
                    break;
                case 3: // No shuffle
                default:
                    break;
            }

            currentCardIndex = 0;

            return true;
        }
        public static Card DealCard()
        {
            //Deals one card
            return cards.First();
        }

        public static List<Card> DealCards(int amount)
        {
            //Deals the number of cards specified by 'amount'
            List<Card> dealtCards = new List<Card>();
            IEnumerable<Card> EnumerblesCards = cards.Take(amount);
            dealtCards = EnumerblesCards.ToList();
            return dealtCards;
        }
    }
}