using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WSCATProject.Base;
using WSCATProject.Base.Buys;
using WSCATProject.Buys;

namespace WSCATProject
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new Sell.InsSellGathering());
=======
            Application.Run(new Sell.InSellForm());
>>>>>>> 41084c8a0f3734d2c90ef32fa6eeec4e378c4367
        }
    }
}