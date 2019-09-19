using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace quantumLeap.UserMenu
{
    class Menu
    {
        public void MenuItems()
        {
            while (true)
            {
                var welcomeMessage = "  Welcome to Quantum! Please enter a number to make your selection or type exit to end the game.";

                var option1TakeALeap = "     1. Take your next leap";
                var option2FundMoreProject = "     2. Fund more projects";
                var option3LeapHistory = "     3. List leap history";

                Console.WriteLine(welcomeMessage);
                Console.WriteLine();

                Console.WriteLine(option1TakeALeap);
                Console.WriteLine(option2FundMoreProject);
                Console.WriteLine(option3LeapHistory);

                var userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    // Leap class/method will be call here.

                    Console.WriteLine("you are leaping");
                    break;
                }
                else if (userInput == "2")
                {
                    // Fund more project calss/method will be call here.

                    Console.WriteLine("Add more fund method/class will be call");
                    break;
                }
                else if (userInput == "3")
                {
                    // Leap History class/method will be call here.

                    Console.WriteLine("List leap history class/method will be called.");
                    break;
                } 
                else if (userInput.ToLower() == "exit")
                {
                    break;
                } else
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a number or type exit to end the game!");
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
        }
    }
}
