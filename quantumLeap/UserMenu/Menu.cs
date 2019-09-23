using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using quantumLeap.BalanceChecker;
using QuantumLeap;
using quantumLeap.Leaps;
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
                Console.Clear();

                if (userInput == "1")
                {
                    var leap = new Leap();
                    var leapRepo = new LeapRepository();

                    var leaperCanLeap = new LeaperCanLeap();
                    var canLeap = leaperCanLeap.LeapCharge();

                    if (canLeap == true)
                    {
                        var quantumLeap = leap.createALeap();
                        Console.WriteLine($"{quantumLeap.Leaper} you have lept to, {quantumLeap.Date} {quantumLeap.Location}, you're apparently {quantumLeap.Host}");
                        leapRepo.SaveNewLeap(quantumLeap);
                        var menu = new Menu();
                        menu.MenuItems();
                    }

                }
                else if (userInput == "2")
                {
                    // Fund more project calls/method will be call here.
                    var currentAvailableFunds = new Budget();
                    var leapRepo = new LeapRepository();
                    var currentBalance = leapRepo.currentAvailableBudget();



                    Console.WriteLine($"Your current available funds are ${currentBalance}. Add more funds y/n?");
                    var userResponse = Console.ReadLine().ToLower();

                    if (userResponse == "y")
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter the amount of funds");
                        var enteredAmount = Console.ReadLine().ToCharArray();
                        foreach (var ea in enteredAmount)
                        {
                            if (!char.IsNumber(ea))
                            {
                                Console.WriteLine("Please enter numbers only");
                            }
                            else
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                string rebuilt = new string(enteredAmount);
                                var currentBudgetBalance = Convert.ToInt32(rebuilt) + currentBalance;
                                Console.WriteLine();
                                Console.WriteLine($"Your current available funds are ${currentBudgetBalance}");
                                Console.WriteLine();
                                leapRepo.saveBudget(currentBudgetBalance);
                                Console.ResetColor();
                                var menu = new Menu();

                                menu.MenuItems();
                            }
                        }

                    }
                    else if (userResponse == "n")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You have chosen not to add funds");
                        Console.ResetColor();
                        Console.WriteLine();
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
                    var leapRepo = new LeapRepository();
                    var historicalLeaps = leapRepo.GetLeaps();
                    for (var i = 0; i < historicalLeaps.Count; i++)
                   // foreach(Events Leap in historicalLeaps)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"Leap {i+1}: \n Leaper:{ historicalLeaps[i].Leaper},\n Date: { historicalLeaps[i].Date},\n Location: { historicalLeaps[i].Location},\n Host: { historicalLeaps[i].Host},\n IsPutRight: { historicalLeaps[i].isPutRight}\n\n");
                        Console.ResetColor();
                    }
                    //Console.WriteLine("List leap history class/method will be called.");
                    break;
                } 
                else if (userInput.ToLower() == "exit")
                {
                    Environment.Exit(0);
                }
                else
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
