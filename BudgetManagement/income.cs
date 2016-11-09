using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagement
{
    public class income
    {
        public List<string> Description { get; set; }
        public List<decimal> Amount { get; set; }

        public decimal GetTotal()
        {
            decimal amount = Amount.Sum();
            decimal returnAmount = 0;

            if (amount % 1 == 0)
            {
                string a = amount.ToString() + ",00";
                returnAmount = Convert.ToDecimal(a);
            }
            else
            {
                returnAmount = amount;
            }

            return returnAmount;
        }

    }
}
