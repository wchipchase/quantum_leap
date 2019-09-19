using System;
using System.Collections.Generic;
using System.Text;

namespace quantumLeap.UserMenu
{
    class Menu
    {
        public void MenuItems()
        {
            var welcomeMessage = "  Welcome to Quantum Leap. Please make your selection.";
            var option1 = "     1. Take your next leap";
            var option2 = "     2. Fund more projects";
            var option3 = "     3. List leap history";

            Console.WriteLine(welcomeMessage);
            Console.WriteLine(option1);
            Console.WriteLine(option2);
            Console.WriteLine(option3);

            var userInput = Console.ReadLine();
        }
    }
}
