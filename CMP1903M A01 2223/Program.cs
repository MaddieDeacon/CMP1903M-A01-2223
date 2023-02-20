using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Program
    {
        static void Main(string[] args)
        {
// creates a new instance of pack
            Pack Pack = new Pack();
            //shuffles pack
            Pack.shuffleCardPack(1);

            // Deal one card
            Card dealtCard = Pack.DealCard();
            Console.WriteLine($"Dealt card: {dealtCard}");

            //dealing 5 cards 
            Console.WriteLine("Dealing five cards:");
            for (int i = 0; i < 5; i++)
            {
                Card card = Pack.DealCard();

                if (card == null)
                {
                    break;
                }

                Console.WriteLine(card);
            }


            



