using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pizza = Input("What kind of pizza would you like? ");

            pizza = pizza.ToLower();

            if (pizza == "cheese and tomato" || pizza == "margherita")
            {
                Print("Suitable for vegetarians", ConsoleColor.Green);
            }
            else if (pizza == "pepperoni" || pizza == "meat feast")
            {
                Print("Not suitable for vegetarians", ConsoleColor.Red);
            }
            else
            {
                Print("Unknown pizza. May contain meat!", ConsoleColor.DarkRed);
            }
            Console.ReadLine();

            pizza = Input("What type of pizza would you like? ");

            pizza = pizza.ToLower();

            switch(pizza)
            {
                case "cheese and tomato":
                case "margherita":
                    Print("Suitable for vegetarians", ConsoleColor.Green);
                    break;
                case "meat feast":
                case "pepperoni":
                    Print("Not suitable for vegetarians", ConsoleColor.Red);
                    break;
                default:
                    Print("Pizza unknown, may contain meat!", ConsoleColor.DarkRed);
                    break;
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Writes a line or just writes the parameters
        /// </summary>
        /// <param name="message">The parameter that will be written</param>
        /// <param name="colour">The colour that the given message will be</param>
        /// <param name="newLine">A boolean that decides whether the message should be on a new line or not</param>
        private static void Print(string message, ConsoleColor colour, bool newLine = true)
        {
            Console.ForegroundColor = colour;

            if (newLine)
                Console.WriteLine(message);
            else
                Console.Write(message);

            Console.ResetColor();
        }

        /// <summary>
        /// Ask a question
        /// </summary>
        /// <param name="question">The question to ask</param>
        /// <returns>The answer to the question</returns>
        private static string Input(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
    }
}
