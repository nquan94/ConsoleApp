using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            User();

            while (true)
            {
                ColorMessage(ConsoleColor.Green, "Guess a number from 1 to 100!");

                Random random = new Random();
                int correctNumber = random.Next(1, 100);
                int guess = 0;

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        ColorMessage(ConsoleColor.Cyan, "Please enter an actual number!");

                        continue;
                    }

                    guess = Int32.Parse(input);
                    if (guess != correctNumber)
                    {
                        ColorMessage(ConsoleColor.Red, "Wrong number, please try again!");

                        continue;
                    }

                }

                ColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!");

                Console.WriteLine("Play again [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }
        static void User()
        {
            ColorMessage(ConsoleColor.Blue, "What is your name?");

            string name = Console.ReadLine();

            Console.WriteLine("Hello {0}, Let's play a game...", name);
            Console.ReadLine();
        }
        static void ColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
