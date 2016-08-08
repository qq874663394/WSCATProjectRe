using BLL;
using HelperUtility;
using HelperUtility.Encrypt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSCATProject.Sell
{
    public partial class InsSellGathering : Form
    {
        ClientManager cm = new ClientManager();
        BankAccountManager bam = new BankAccountManager();
        EmpolyeeManager em = new EmpolyeeManager();
        CodingHelper ch = new CodingHelper();

        public string pbName;//根据图片Name对应相应的datagridview
        public InsSellGathering()
        {
            InitializeComponent();
        }

        private void InsSellGathering_Load(object sender, EventArgs e)
        {
            LoginInfomation l = LoginInfomation.getInstance();
            l.UserName = "sss";
            ltxt_operation.Text = l.UserName;

            dataGridViewFujia.ReadOnly = true;
            dataGridViewFujia.AllowUserToResizeColumns = false;//是否可以调整列的大小
            dataGridViewFujia.AllowUserToResizeRows = false;//是否可以调整行的大小  
        }

        #region 点击图片把客户、账户、业务员分别绑定到dataGridView
        private void ClickPicBox(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pbName = pb.Name;
            switch (pb.Name)
            {
                case "pictureBox1":
                    resizablePanel1.Location = new Point(190, 115);                   
                    break;
                case "pictureBox2":
                    resizablePanel1.Location = new Point(190, 150);
                    DataTable dt1 = bam.SelBankAccount2();
                    dataGridViewFujia.DataSource = dt1;
                    break;
                case "pictureBox3":
                    resizablePanel1.Location = new Point(190, 320);
                    DataTable dt2 = ch.DataTableReCoding(em.SelEmp2("").Tables[0]);
                    dataGridViewFujia.DataSource = dt2;
                    break;
            }
            if (!_btnAdd)
            {
                resizablePanel1.Visible = true;
                _btnAdd = true;
            }
            else
            {
                resizablePanel1.Visible = true;
                resizablePanel1.Focus();
            }
        }
        #endregion

        /// <summary>
        /// 点击panel隐藏扩展panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void panel6_Click(object sender, EventArgs e)
        {
            if (resizablePanel1.Visible)
                resizablePanel1.Visible = false;
        }
        //控制面板是否显示
        private bool _btnAdd = false;
        protected bool BtnAdd
        {
            get { return _btnAdd; }
            set { _btnAdd = value; }
        }

        #region  把选中行的值绑定到文本框
        private void dataGridViewFujia_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (pbName)
            {
                case "pictureBox1":
                    ltxt_kehu.Text = dataGridViewFujia.Rows[e.RowIndex].Cells[1].Value.ToString();
                    ltxt_yingshou.Text = dataGridViewFujia.Rows[e.RowIndex].Cells[2].Value.ToString();
                    break;
                case "pictureBox2":
                    ltxt_AccountName.Text = dataGridViewFujia.Rows[e.RowIndex].Cells[1].Value.ToString();
                    break;
                case "pictureBox3":
                    ltxt_saleman.Text = dataGridViewFujia.Rows[e.RowIndex].Cells[1].Value.ToString();
                    break;
            }
            resizablePanel1.Visible = false;
        }
        #endregion

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        #region 退出
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
        #endregion

    }
}
