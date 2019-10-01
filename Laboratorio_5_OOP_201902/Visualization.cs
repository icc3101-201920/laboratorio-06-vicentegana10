using System;
using System.Collections.Generic;
using System.Text;
using Laboratorio_5_OOP_201902.Cards;

namespace Laboratorio_5_OOP_201902
{
    public class Visualization
    {

        //Metodos
        public void ShowHand(Hand hand)
        {
            Console.WriteLine("Hand: perro");
            int count = 0;
            foreach (Card card in hand.Cards)
            {
                if (card.GetType().Name == nameof(CombatCard))
                {
                    count++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"|({count}) {card.Name} ({card.Type}): |");
                    // falta {card.AttackPoints} despues de los 2 puntos.  aun no entiendo porque no me deja llamar a este atributo
                    Console.ResetColor();
                }
                else
                {
                    count++;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"|({count}) {card.Name} ({card.Type}) |");
                    Console.ResetColor();
                }

            }
        }

        public void ShowDecks(List<Deck> decks)
        {
            Console.WriteLine("Select one Deck:");
            Console.WriteLine("(0) Deck 1");
            Console.WriteLine("(1) Deck 2");
            //string option;
            //string option0 = "0";
            //string option1 = "1";
            //option = Console.ReadLine();
            //int optionAns = 3; // lo deje como 3 para crear la variable primero
            //if (option == option1)
            //{
            //    optionAns = 1;
            //}
            //if (option == option0)
            //{
            //    optionAns = 0;
            //}
            //return optionAns;
        }

        public void ShowCaptains(List<SpecialCard> captains)
        {
            Console.WriteLine("Select one Captain:");
            int counter2 =0;
            foreach (Card card in captains)
            {
                Console.WriteLine($"({counter2}) {card.Name}: {card.Effect} ");
                counter2++;
            }
        }

        public void GetUserInput(int maxInput, bool stopper = false)
        {
            Boolean b = true;
            while (b)
            {
                string input = Console.ReadLine();
                try
                {
                    int result = Int32.Parse(input);
                    if (-1 <= result & result <=maxInput & stopper)
                    {
                        b = false;
                    }
                    else
                    {
                        ConsoleError($"The option ({result}) is not valid, try again");
                    }
                    if (0 <= result & result <= maxInput & stopper==false)
                    {
                        b = false;
                    }
                    else
                    {
                        ConsoleError($"The option ({result}) is not valid, try again");
                    }
                }
                catch (FormatException)
                {
                    ConsoleError("Imput must be a number, try again");
                }

            }
        }

        public void ShowProgramMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(message);
            Console.ResetColor();
        }

        public void ConsoleError(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(message);
            Console.ResetColor();
        }

        public void ShowListOptions(List<string> options, string message = null)
        {
            if (message != null)
            {
                Console.WriteLine(message);
            }
            int counter3 = 0;
            foreach (string word in options)
            {
                Console.WriteLine($"({counter3}) {word}");
                counter3++;
            }
        }

        public void ClearConsole()
        {
            Console.Clear();
        }


    }
}
