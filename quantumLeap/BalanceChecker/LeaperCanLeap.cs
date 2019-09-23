using quantumLeap.UserMenu;
using QuantumLeap;
using System;
using System.Collections.Generic;
using System.Text;

namespace quantumLeap.BalanceChecker
{
    class LeaperCanLeap
    {
        public bool HasEnoughFunds { get; set; } = false;
        public bool LeapCharge()
        {
            var leapRepo = new LeapRepository();
            var currentBal = leapRepo.currentAvailableBudget();

            if(currentBal >= 1000)
            {
                var updatedBudget = currentBal - 1000;
                HasEnoughFunds = true;
                leapRepo.saveBudget(updatedBudget);
                Console.WriteLine();
                Console.WriteLine($"$1,00 has been deducted from your budget. Your new balance is ${updatedBudget}. You are good to leap!");
                Console.WriteLine();
                Console.WriteLine("Leap info:");
                Console.WriteLine();
            }
            else
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Your current balance of ${currentBal} is insufficient for the leap. Please add more funds!");
                Console.ResetColor();
                Console.WriteLine();
                var userMenu = new Menu();
                userMenu.MenuItems();
            }
            return HasEnoughFunds;

        }
    }
}
