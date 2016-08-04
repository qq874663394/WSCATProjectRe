namespace WSCATProject
{
    partial class ClientNameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_DownClient = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_ClientManagerPho = new System.Windows.Forms.TextBox();
            this.textBox_ClientManAddreager = new System.Windows.Forms.TextBox();
            this.textBox_ClientManagerName = new System.Windows.Forms.TextBox();
            this.label88 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.button_ClientDelete = new System.Windows.Forms.Button();
            this.button_ClientUpdate = new System.Windows.Forms.Button();
            this.button_ClientSelect = new System.Windows.Forms.Button();
            this.button_ClientInsert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Client = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Client)).BeginInit();
            this.SuspendLayout();
            // 
            // button_DownClient
            // 
            this.button_DownClient.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_DownClient.ForeColor = System.Drawing.Color.Black;
            this.button_DownClient.Location = new System.Drawing.Point(24, 162);
            this.button_DownClient.Name = "button_DownClient";
            this.button_DownClient.Size = new System.Drawing.Size(174, 24);
            this.button_DownClient.TabIndex = 23;
            this.button_DownClient.Text = "下载到手持机";
            this.button_DownClient.UseVisualStyleBackColor = true;
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_clear.ForeColor = System.Drawing.Color.Black;
            this.button_clear.Location = new System.Drawing.Point(24, 131);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(174, 24);
            this.button_clear.TabIndex = 22;
            this.button_clear.Text = "取消输入";
            this.button_clear.UseVisualStyleBackColor = true;
            // 
            // textBox_ClientManagerPho
            // 
            this.textBox_ClientManagerPho.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ClientManagerPho.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_ClientManagerPho.Location = new System.Drawing.Point(93, 83);
            this.textBox_ClientManagerPho.Name = "textBox_ClientManagerPho";
            this.textBox_ClientManagerPho.Size = new System.Drawing.Size(105, 26);
            this.textBox_ClientManagerPho.TabIndex = 21;
            // 
            // textBox_ClientManAddreager
            // 
            this.textBox_ClientManAddreager.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ClientManAddreager.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_ClientManAddreager.Location = new System.Drawing.Point(93, 53);
            this.textBox_ClientManAddreager.Name = "textBox_ClientManAddreager";
            this.textBox_ClientManAddreager.Size = new System.Drawing.Size(105, 26);
            this.textBox_ClientManAddreager.TabIndex = 20;
            // 
            // textBox_ClientManagerName
            // 
            this.textBox_ClientManagerName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ClientManagerName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_ClientManagerName.Location = new System.Drawing.Point(93, 22);
            this.textBox_ClientManagerName.Name = "textBox_ClientManagerName";
            this.textBox_ClientManagerName.Size = new System.Drawing.Size(105, 26);
            this.textBox_ClientManagerName.TabIndex = 19;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Font = new System.Drawing.Font("宋体", 10F);
            this.label88.ForeColor = System.Drawing.Color.Black;
            this.label88.Location = new System.Drawing.Point(21, 87);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(70, 14);
            this.label88.TabIndex = 18;
            this.label88.Text = "客户电话:";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Font = new System.Drawing.Font("宋体", 10F);
            this.label87.ForeColor = System.Drawing.Color.Black;
            this.label87.Location = new System.Drawing.Point(21, 57);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(70, 14);
            this.label87.TabIndex = 17;
            this.label87.Text = "客户地址:";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Font = new System.Drawing.Font("宋体", 10F);
            this.label86.ForeColor = System.Drawing.Color.Black;
            this.label86.Location = new System.Drawing.Point(21, 28);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(70, 14);
            this.label86.TabIndex = 16;
            this.label86.Text = "客户名称:";
            // 
            // button_ClientDelete
            // 
            this.button_ClientDelete.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ClientDelete.ForeColor = System.Drawing.Color.Black;
            this.button_ClientDelete.Location = new System.Drawing.Point(138, 228);
            this.button_ClientDelete.Name = "button_ClientDelete";
            this.button_ClientDelete.Size = new System.Drawing.Size(60, 24);
            this.button_ClientDelete.TabIndex = 15;
            this.button_ClientDelete.Text = "删除";
            this.button_ClientDelete.UseVisualStyleBackColor = true;
            // 
            // button_ClientUpdate
            // 
            this.button_ClientUpdate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ClientUpdate.ForeColor = System.Drawing.Color.Black;
            this.button_ClientUpdate.Location = new System.Drawing.Point(138, 194);
            this.button_ClientUpdate.Name = "button_ClientUpdate";
            this.button_ClientUpdate.Size = new System.Drawing.Size(60, 24);
            this.button_ClientUpdate.TabIndex = 14;
            this.button_ClientUpdate.Text = "修改";
            this.button_ClientUpdate.UseVisualStyleBackColor = true;
            // 
            // button_ClientSelect
            // 
            this.button_ClientSelect.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ClientSelect.ForeColor = System.Drawing.Color.Black;
            this.button_ClientSelect.Location = new System.Drawing.Point(61, 194);
            this.button_ClientSelect.Name = "button_ClientSelect";
            this.button_ClientSelect.Size = new System.Drawing.Size(71, 24);
            this.button_ClientSelect.TabIndex = 13;
            this.button_ClientSelect.Text = "查询";
            this.button_ClientSelect.UseVisualStyleBackColor = true;
            // 
            // button_ClientInsert
            // 
            this.button_ClientInsert.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ClientInsert.ForeColor = System.Drawing.Color.Black;
            this.button_ClientInsert.Location = new System.Drawing.Point(61, 227);
            this.button_ClientInsert.Name = "button_ClientInsert";
            this.button_ClientInsert.Size = new System.Drawing.Size(71, 24);
            this.button_ClientInsert.TabIndex = 12;
            this.button_ClientInsert.Text = "增加";
            this.button_ClientInsert.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.button_ClientUpdate);
            this.panel1.Controls.Add(this.button_DownClient);
            this.panel1.Controls.Add(this.button_ClientInsert);
            this.panel1.Controls.Add(this.button_clear);
            this.panel1.Controls.Add(this.button_ClientSelect);
            this.panel1.Controls.Add(this.textBox_ClientManagerPho);
            this.panel1.Controls.Add(this.button_ClientDelete);
            this.panel1.Controls.Add(this.textBox_ClientManAddreager);
            this.panel1.Controls.Add(this.label86);
            this.panel1.Controls.Add(this.textBox_ClientManagerName);
            this.panel1.Controls.Add(this.label87);
            this.panel1.Controls.Add(this.label88);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 268);
            this.panel1.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dgv_Client);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 11F);
            this.groupBox1.Location = new System.Drawing.Point(217, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 268);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据列表";
            // 
            // dgv_Client
            // 
            this.dgv_Client.AllowUserToAddRows = false;
            this.dgv_Client.AllowUserToDeleteRows = false;
            this.dgv_Client.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Client.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Client.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.address,
            this.phone,
            this.date,
            this.id});
            this.dgv_Client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Client.Location = new System.Drawing.Point(3, 20);
            this.dgv_Client.Name = "dgv_Client";
            this.dgv_Client.RowTemplate.Height = 23;
            this.dgv_Client.Size = new System.Drawing.Size(514, 245);
            this.dgv_Client.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "客户姓名";
            this.name.HeaderText = "客户姓名";
            this.name.Name = "name";
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.DataPropertyName = "客户地址";
            this.address.HeaderText = "客户地址";
            this.address.Name = "address";
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phone.DataPropertyName = "客户电话";
            this.phone.HeaderText = "客户电话";
            this.phone.Name = "phone";
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.DataPropertyName = "添加时间";
            this.date.HeaderText = "添加时间";
            this.date.Name = "date";
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // ClientNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 268);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientNameForm";
            this.Text = "ClientNameForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Client)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_DownClient;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBox_ClientManagerPho;
        private System.Windows.Forms.TextBox textBox_ClientManAddreager;
        private System.Windows.Forms.TextBox textBox_ClientManagerName;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Button button_ClientDelete;
        private System.Windows.Forms.Button button_ClientUpdate;
        private System.Windows.Forms.Button button_ClientSelect;
        private System.Windows.Forms.Button button_ClientInsert;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}