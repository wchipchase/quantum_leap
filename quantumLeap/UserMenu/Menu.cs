using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using QuantumLeap;

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
                    // Leap class/method will be call here.

                    Console.WriteLine("you are leaping");
                    break;
                }
                else if (userInput == "2")
                {
                    // Fund more project calls/method will be call here.
                    var currentAvailableFunds = new Budget();



                    Console.WriteLine("Your current available funds are ${0}. Add more funds y/n?", currentAvailableFunds.currentBudgetBalance());
                    var userResponse = Console.ReadLine().ToLower();

                    if (userResponse == "y")
                    {
                        Console.WriteLine("Please enter the amount of funds");
                        var enteredAmount = Console.ReadLine().ToCharArray();
                        foreach(var ea in enteredAmount)
                        {
                            if (!char.IsNumber(ea))
                            {
                                Console.WriteLine("Please enter numbers only");
                            }
                            else
                            {
                                string rebuilt = new string(enteredAmount);
                                var currentBudgetBalance = Convert.ToInt32(rebuilt) + currentAvailableFunds.currentBudgetBalance();
                                Console.WriteLine("Your current available funds are ${0}", currentBudgetBalance);
                                var leapRepo = new LeapRepository();
                                leapRepo.saveBudget(currentBudgetBalance);
                                var menu = new Menu();

                                menu.MenuItems();
                            }
                        }
                        
                    }
                    else if (userResponse == "n")
                    {
                        Console.WriteLine("You have chosen not to add funds");
                        var menu = new Menu();

                        menu.MenuItems();

                    }
                    else
                    {
                        Console.WriteLine("You have made an invalid selection.");
                        var menu = new Menu();

                        menu.MenuItems();
                    }

                    // Console.Clear();
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
