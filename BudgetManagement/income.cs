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
            return Amount.Sum();
        }

    }
}
