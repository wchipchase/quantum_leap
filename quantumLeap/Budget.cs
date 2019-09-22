using System;
using System.Collections.Generic;
using System.Text;
using QuantumLeap;


namespace quantumLeap
{
    class Budget
    {
        public string BudgetName { get; set; }
        public int BudgetId { get; set; }

        // field
        static int _currentBudgetBalance { get; set; }


        public void FundProject(int fundsToAdd)
        {
            _currentBudgetBalance += fundsToAdd;
        }

        public int currentBudgetBalance()
        {
            return _currentBudgetBalance;
        }

        public void saveCurrentBudgetBalanceToRepo(int newBalance)
        {
            var leapRepoInstance = new LeapRepository();
            leapRepoInstance.saveBudget(newBalance);
        }

    }
}
