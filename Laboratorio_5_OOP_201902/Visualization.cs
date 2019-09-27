using System;
using System.Collections.Generic;
using System.Text;
using Laboratorio_5_OOP_201902.Cards;

namespace Laboratorio_5_OOP_201902
{
    public static class Visualization
    {

        //Metodos
        public void ShowHand(Hand hand)
        {
            Console.WriteLine("Hand:");
            int count = 0;
            foreach (Card card in hand.Cards)
            {
                if (card.GetType().Name == nameof(CombatCard))
                {
                    count++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"|({count}) {card.Name} ({card.type}): {card.AttackPoints} |");
                    Console.ResetColor();
                }
                else
                {
                    count++;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"|({count}) {card.name} ({card.type}) |");
                    Console.ResetColor();
                }

            }
        }

        public void ShowDecks(List<Deck> decks)
        {
            Console.WriteLine("Select one Deck:");
            string option;
            Console.WriteLine("aa");
            option = Console.ReadLine();
        }
       


    }
}


