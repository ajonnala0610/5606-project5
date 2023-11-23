using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5Final
{
    internal class StockDecrease : StockIncrease
    {
        public StockDecrease(string bloodGroup, int inputQuantity, int dbUnits, int stockAction) : base(bloodGroup, inputQuantity, dbUnits, stockAction)
        {
        }
    }
}
