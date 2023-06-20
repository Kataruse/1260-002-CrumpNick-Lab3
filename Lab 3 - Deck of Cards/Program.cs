/**
*--------------------------------------------------------------------
* File name: Program.cs
* Project name: 1260-002-CrumpNick-Project2
*--------------------------------------------------------------------
* Author’s name and email: Nick Crump, CRUMPNA@ETSU.ED
* Course-Section: CSCI 1260-002
* Creation Date: 2/13/2023
* -------------------------------------------------------------------
*/

namespace Lab_3___Deck_of_Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Console.WriteLine("--------------------DECK--------------------");
            Console.WriteLine(deck.ToString() + "\n");

            Console.WriteLine("--------------------SHUFFLED DECK--------------------");
            deck.Shuffle();
            Console.WriteLine(deck.ToString() + "\n");

            Deck deckNew = deck;
            Console.WriteLine("--------------------HAND 1 OF COPIED DECK--------------------");
            Console.WriteLine(deckNew.DealAHand(7).ToString() + "\n");

            Console.WriteLine("--------------------HAND 2 OF COPIED DECK--------------------");
            Console.WriteLine(deckNew.DealAHand(7).ToString() + "\n");
        }
    }
}