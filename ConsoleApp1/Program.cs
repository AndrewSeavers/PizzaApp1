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
                Console.WriteLine("Suitable for vegetarians");
            }
            else if (pizza == "pepperoni" || pizza == "meat feast")
            {
                Console.WriteLine("Not suitable for vegetarians");
            }
            else
            {
                Console.WriteLine("Unknown pizza. May contain meat!");
            }
            Console.ReadLine();

            pizza = Input("What type of pizza would you like? ");

            pizza = pizza.ToLower();

            switch(pizza)
            {
                case "cheese and tomato":
                case "margherita":
                    Console.WriteLine("Suitable for vegetarians");
                    break;
                case "meat feast":
                case "pepperoni":
                    Console.WriteLine("Not suitable for vegetarians");
                    break;
                default:
                    Console.WriteLine("Pizza unknown, may contain meat!");
                    break;
            }
            Console.ReadLine();
        }

        private static string Input(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
    }
}
