using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ConllectionManager
    {
        ConllectionService cs = new ConllectionService();
        public int InsConllection(Conllection conll)
        {
            return cs.InsConllection(conll);
        }
    }
}
