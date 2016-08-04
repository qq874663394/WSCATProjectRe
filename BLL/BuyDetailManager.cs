using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BuyDetailManager
    {
        BuyDetailService bds = new BuyDetailService();
        public DataTable SelBuyDetailByCodeToTable(string code)
        {
            return bds.SelBuyDetailByCodeToTable(code);
        }
    }
}
