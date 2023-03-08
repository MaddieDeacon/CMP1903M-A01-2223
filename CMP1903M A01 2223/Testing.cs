using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        public static void Test()
        {
            // creates a new instance of pack
            Pack Pack = new Pack();
            //shuffles pack
            Pack.shuffleCardPack(1);

            // Deal one card
            Card dealtCard = Pack.DealCard();
            Console.WriteLine("Dealt card: " + dealtCard.Value + " of " + dealtCard.Suit);

            //dealing 5 cards 
            Console.WriteLine("Dealing five cards:");
            List<Card> deck = Pack.DealCards(5);
            int count = 1;
            foreach (Card card in deck)
            {
                Console.WriteLine("Card " + count + ": " + card.Value + " of " + card.Suit);
                count++;
            }
        }
    }
}
