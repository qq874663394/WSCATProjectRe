using BLL;
using HelperUtility;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSCATProject.Base.Buys
{
    public partial class BuyFollowInformation : Form
    {
        WSCATProject.Buys.FollowLoisticalForm follow = new WSCATProject.Buys.FollowLoisticalForm();
        public BuyFollowInformation(WSCATProject.Buys.FollowLoisticalForm f)
        {
            f = follow;
            InitializeComponent();
        }

        BuyProcessManager bpm = new BuyProcessManager();
        private string _buycode;
        public string BuyCode
        {
            get { return _buycode; }
            set { _buycode = value; }
        }
        private void BuyFollowInformation_Load(object sender, EventArgs e)
        {
            LoginInfomation l = LoginInfomation.getInstance();
            l.UserName = "张三";
            txt_caozuoman.Text = l.UserName;
            txt_buycode.Text = _buycode;
        }

        private void btn_baocun_Click(object sender, EventArgs e)
        {
            //BuyFollowInformation bfi = new BuyFollowInformation();
            if (InsTextIsNull() == false)
            {
                return;
            }
            try
            {
                int result = InsBuyProcessFun();
                if (result > 0)
                {
                    MessageBox.Show("保存成功");
                    //follow.Band(_buycode);//不是写这里0.0
                    follow.DanHaoCode = _buycode;
                    Close();
                    Dispose();
                }
                else
                {
                    MessageBox.Show("保存失败");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误代码:3205-审核采购单加载时异常，异常信息：" + ex.Message);
            }
        }

        private int InsBuyProcessFun()
        {
            BuyProcess bp = new BuyProcess();
            bp.BP_Code = txt_buycode.Text.Trim();
            bp.BP_Datetime = Convert.ToDateTime(dateTimeInput1.Text);
            bp.BP_Opt = cbo_caozuo.Text.Trim();
            bp.BP_Ope = txt_caozuoman.Text.Trim();
            bp.BP_Remark = txt_beizhu.Text.Trim();
            return bpm.InsBuyFollow(bp);
        }

        #region 非空验证
        /// <summary>
        /// 非空验证
        /// </summary>
        /// <returns></returns>
        private bool InsTextIsNull()
        {
            if (string.IsNullOrWhiteSpace(txt_caozuoman.Text))
            {
                MessageBox.Show("采购单号不能为空！");
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbo_caozuo.Text))
            {
                MessageBox.Show("所做操作不能为空！");
                return false;
            }
            return true;
        }
        #endregion

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
