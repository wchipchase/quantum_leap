using quantumLeap.UserMenu;
using QuantumLeap;
using System;
using System.Collections.Generic;
using System.Text;

namespace quantumLeap.BalanceChecker
{
    class LeaperCanLeap
    {
        public void LeapCharge()
        {
            var leapRepo = new LeapRepository();
            var currentBal = leapRepo.currentAvailableBudget();

            if(currentBal >= 1000)
            {
                Console.WriteLine($"You are good to go! {currentBal}");
            } else
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Your current balance of ${currentBal} is insufficient for the leap. Please add more funds!");
                Console.ResetColor();
                Console.WriteLine();
                var userMenu = new Menu();
                userMenu.MenuItems();
            }

        }
    }
}
