using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5Final
{
    internal interface IStock
    {
        int InputQuantity { get; set; }
        int DBQuantity { get; set; }
        string BloodGroup { get; set; }
        char StockAction { get; set; }
    }
}
