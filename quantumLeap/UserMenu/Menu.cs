using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using QuantumLeap;
using Leap = quantumLeap.Leaps.Leap;

namespace quantumLeap.UserMenu
{
    class Menu
    {
        public void MenuItems()
        {
            while (true)
            {
                var welcomeMessage = "  Welcome to Quantum Leap! Please enter a number to make your selection or type exit to end the game.";

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
                    var leap = new Leap();
                    var leapRepo = new LeapRepository();

                    var quantumLeap = leap.createALeap();
                    Console.WriteLine($"{quantumLeap.Leaper} you have lept to, {quantumLeap.Date} {quantumLeap.Location}, you're apparently {quantumLeap.Host}");
                    leapRepo.SaveNewLeap(quantumLeap);
                    var menu = new Menu();
                    menu.MenuItems();
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
                    Console.WriteLine();
                    Console.WriteLine("Please enter a number or type exit to end the game!");
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
        }
    }
}
