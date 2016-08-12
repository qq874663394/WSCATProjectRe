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
    public class ConllectionWaitManager
    {
        ConllectionWaitService cws = new ConllectionWaitService();
        public int InsConllectionWait(ConllectionWait cw)
        {
            return cws.InsConllectionWait(cw);
        }
        /// <summary>
        /// 获得资金收款单数据列表 
        /// </summary>
        public DataTable GetList()
        {
            return cws.GetList();
        }
    }
}
