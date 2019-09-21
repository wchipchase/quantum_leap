using System;
using System.Collections.Generic;
using System.Text;

namespace quantumLeap
{
    class Budget
    {
        public string BudgetName { get; set; }
        public int BudgetId { get; set; }

        // field
        public int _currentBudgetBalance { get; set; }

        // constructor
        public Budget(string budgetName, int budgetInitialBalance)
        {
            this.BudgetName = budgetName;
            this._currentBudgetBalance = budgetInitialBalance;
        }

        public void FundProject(int fundsToAdd)
        {
            this._currentBudgetBalance += fundsToAdd;
        }

    }
}
