﻿using System;
using System.Collections.Generic;
using DeckOfCards.Models;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            // Card c1 = new Card("Diamonds", "3", -1);
            // Console.WriteLine(c1.Display());

            Deck d1 = new Deck();
            d1.Shuffle();
            // d1.Shuffle();
            // d1.Display();
            // Console.WriteLine("====================================");
            // Card c1 = d1.Deal();
            // Console.WriteLine(c1.Display());
            // List<Card> hand = d1.Deal(5);
            // Console.Write("[ ");
            // foreach(Card c in hand)
            // {
            //     Console.Write( c.Display() + ", " );
            // }
            // Console.WriteLine("]");
            // Console.WriteLine(d1.Size);
            Player p1 = new Player(d1);
            p1.Draw(2);
            p1.Display();
            

        }
    }
}
