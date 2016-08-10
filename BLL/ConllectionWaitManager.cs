using DAL;
using Model;
using System;
using System.Collections.Generic;
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
    }
}
