using BLL;
using HelperUtility;
using HelperUtility.Encrypt;
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

namespace WSCATProject.Sell
{
    public partial class InsSellGathering : Form
    {
        ClientManager cm = new ClientManager();
        BankAccountManager bam = new BankAccountManager();
        EmpolyeeManager em = new EmpolyeeManager();
        CodingHelper ch = new CodingHelper();
        ConllectionWait cw = new ConllectionWait();
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
            if (string.IsNullOrWhiteSpace(textBoxOddNumbers.Text))
            {
                textBoxOddNumbers.Text = BuildCode.ModuleCode("AC");
            }
            dataGridViewFujia.ReadOnly = true;
            dataGridViewFujia.AllowUserToResizeColumns = false;//是否可以调整列的大小
            dataGridViewFujia.AllowUserToResizeRows = false;//是否可以调整行的大小  
        }

        #region 点击图片把客户、账户、业务员分别绑定到dataGridView
        private void ClickPicBox(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn gc;
            PictureBox pb = sender as PictureBox;
            pbName = pb.Name;
            switch (pb.Name)
            {
                case "pictureBox1":
                    dataGridViewFujia.Columns.Clear();
                    dataGridViewFujia.AutoGenerateColumns = false;
                    gc = new DataGridViewTextBoxColumn();
                    gc.DataPropertyName = "Cli_Code";
                    gc.Name = "ColumnsValue";
                    gc.HeaderText = "客户编码";
                    dataGridViewFujia.Columns.Add(gc);

                    gc = new DataGridViewTextBoxColumn();
                    gc.DataPropertyName = "Cli_Name";
                    gc.Name = "ColumnsName";
                    gc.HeaderText = "客户名称";
                    dataGridViewFujia.Columns.Add(gc);
                    dataGridViewFujia.DataSource = cm.GetListInSimple().Tables[0];
                    dataGridViewFujia.Columns[0].Visible = false;
                    resizablePanel1.Location = new Point(190, 115);
                    break;
                case "pictureBox2":
                    dataGridViewFujia.Columns.Clear();
                    dataGridViewFujia.AutoGenerateColumns = false;
                    gc = new DataGridViewTextBoxColumn();
                    gc.DataPropertyName = "编码";
                    gc.Name = "ColumnsValue";
                    gc.HeaderText = "Ba_Code";
                    gc.Visible = false;
                    dataGridViewFujia.Columns.Add(gc);

                    gc = new DataGridViewTextBoxColumn();
                    gc.DataPropertyName = "开户行";
                    gc.Name = "ColumnsName";
                    gc.HeaderText = "账户名称";
                    dataGridViewFujia.Columns.Add(gc);
                    dataGridViewFujia.DataSource = bam.SelBankAccount(false);
                    dataGridViewFujia.Columns[0].Visible = false;
                    resizablePanel1.Location = new Point(190, 150);
                    break;
                case "pictureBox3":
                    dataGridViewFujia.Columns.Clear();
                    dataGridViewFujia.AutoGenerateColumns = false;
                    gc = new DataGridViewTextBoxColumn();
                    gc.DataPropertyName = "员工工号";
                    gc.Name = "ColumnsValue";
                    gc.HeaderText = "编码";
                    //gc.Visible = false;
                    dataGridViewFujia.Columns.Add(gc);

                    gc = new DataGridViewTextBoxColumn();
                    gc.DataPropertyName = "姓名";
                    gc.Name = "ColumnsName";
                    gc.HeaderText = "名称";
                    dataGridViewFujia.Columns.Add(gc);
                    dataGridViewFujia.DataSource = em.SelEmpolyee(false);
                    dataGridViewFujia.Columns[0].Visible = false;
                    resizablePanel1.Location = new Point(190, 320);
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
            if (dataGridViewFujia.CurrentRow.Index == -1)
            {
                return;
            }
            switch (pbName)
            {
                case "pictureBox1":
                    ltxt_kehu.Text = dataGridViewFujia.Rows[e.RowIndex].Cells["ColumnsName"].Value.ToString();
                    cw.CW_ClientCode = dataGridViewFujia.Rows[e.RowIndex].Cells["ColumnsValue"].Value.ToString();
                    cw.CW_ClientName = dataGridViewFujia.Rows[e.RowIndex].Cells["ColumnsName"].Value.ToString();
                    break;
                case "pictureBox2":
                    ltxt_AccountName.Text = dataGridViewFujia.Rows[e.RowIndex].Cells["ColumnsName"].Value.ToString();
                    cw.CW_AccountCode = dataGridViewFujia.Rows[e.RowIndex].Cells["ColumnsValue"].Value.ToString();
                    break;
                case "pictureBox3":
                    ltxt_saleman.Text = dataGridViewFujia.Rows[e.RowIndex].Cells["ColumnsName"].Value.ToString();
                    cw.CW_SalesMan = dataGridViewFujia.Rows[e.RowIndex].Cells["ColumnsName"].Value.ToString();
                    break;
            }
            resizablePanel1.Visible = false;
        }
        #endregion

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ConllectionWaitManager cwm = new ConllectionWaitManager();
            cw.CW_Code = BuildCode.ModuleCode("CW");
            int result = cwm.InsConllectionWait(cw);
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
