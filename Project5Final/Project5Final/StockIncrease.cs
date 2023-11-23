using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5Final
{
    enum StockManagement
    {
        Increase = 1,
        Decrease
    }
    internal class StockIncrease : IStock
    {
        public int InputQuantity { get; set; }
        public int DBQuantity { get; set; }
        public string BloodGroup { get; set; }
        public char StockAction { get; set; }

        public StockIncrease(string bloodGroup, int inputQuantity, int dbQuantity, int stockAction) 
        {
            BloodGroup = bloodGroup;
            InputQuantity = inputQuantity;
            DBQuantity = dbQuantity;
            if (stockAction == (int)StockManagement.Increase) StockAction = '+';
            else StockAction = '-';
        }

        public int CalculateQuantity<T>(T stock) where T : IStock
        {
            if (stock.StockAction == '+') return stock.DBQuantity + stock.InputQuantity ;
            else return stock.DBQuantity - stock.InputQuantity;
        }

       
    }
}
