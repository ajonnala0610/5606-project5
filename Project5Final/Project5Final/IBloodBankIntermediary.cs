using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5Final
{
    internal interface IBloodBankIntermediary
    {
        string DBError { get; set; }

        DataSet ViewAllDonors();
        DataSet GetBloodGroupStocks();
        int GetStockQuantity(string bloodGroup);
        int UpdateQuantity(int quantity, string bloodGroup);

    }
}
