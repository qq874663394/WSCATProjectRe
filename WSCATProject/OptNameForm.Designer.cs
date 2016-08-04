namespace WSCATProject
{
    partial class OptNameForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_operatorName = new System.Windows.Forms.TextBox();
            this.comboBox_operatorDate = new System.Windows.Forms.TextBox();
            this.lab_DateTime = new System.Windows.Forms.Label();
            this.lab_name = new System.Windows.Forms.Label();
            this.button_optNameDownload = new System.Windows.Forms.Button();
            this.button_optNameDelete = new System.Windows.Forms.Button();
            this.button_optpNameAdd = new System.Windows.Forms.Button();
            this.button_optNameQuery = new System.Windows.Forms.Button();
            this.groupBox_staff = new System.Windows.Forms.GroupBox();
            this.dgv_staff = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox_staff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.comboBox_operatorName);
            this.panel1.Controls.Add(this.comboBox_operatorDate);
            this.panel1.Controls.Add(this.lab_DateTime);
            this.panel1.Controls.Add(this.lab_name);
            this.panel1.Controls.Add(this.button_optNameDownload);
            this.panel1.Controls.Add(this.button_optNameDelete);
            this.panel1.Controls.Add(this.button_optpNameAdd);
            this.panel1.Controls.Add(this.button_optNameQuery);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 268);
            this.panel1.TabIndex = 0;
            // 
            // comboBox_operatorName
            // 
            this.comboBox_operatorName.Location = new System.Drawing.Point(91, 41);
            this.comboBox_operatorName.Name = "comboBox_operatorName";
            this.comboBox_operatorName.Size = new System.Drawing.Size(100, 21);
            this.comboBox_operatorName.TabIndex = 71;
            // 
            // comboBox_operatorDate
            // 
            this.comboBox_operatorDate.Location = new System.Drawing.Point(91, 83);
            this.comboBox_operatorDate.Name = "comboBox_operatorDate";
            this.comboBox_operatorDate.ReadOnly = true;
            this.comboBox_operatorDate.Size = new System.Drawing.Size(100, 21);
            this.comboBox_operatorDate.TabIndex = 70;
            // 
            // lab_DateTime
            // 
            this.lab_DateTime.AutoSize = true;
            this.lab_DateTime.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_DateTime.Location = new System.Drawing.Point(13, 86);
            this.lab_DateTime.Name = "lab_DateTime";
            this.lab_DateTime.Size = new System.Drawing.Size(63, 14);
            this.lab_DateTime.TabIndex = 69;
            this.lab_DateTime.Text = "增加日期";
            // 
            // lab_name
            // 
            this.lab_name.AutoSize = true;
            this.lab_name.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_name.Location = new System.Drawing.Point(13, 45);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(35, 14);
            this.lab_name.TabIndex = 66;
            this.lab_name.Text = "名称";
            // 
            // button_optNameDownload
            // 
            this.button_optNameDownload.Location = new System.Drawing.Point(108, 201);
            this.button_optNameDownload.Name = "button_optNameDownload";
            this.button_optNameDownload.Size = new System.Drawing.Size(97, 29);
            this.button_optNameDownload.TabIndex = 65;
            this.button_optNameDownload.Text = "下载到手持机";
            this.button_optNameDownload.UseVisualStyleBackColor = true;
            // 
            // button_optNameDelete
            // 
            this.button_optNameDelete.Location = new System.Drawing.Point(5, 200);
            this.button_optNameDelete.Name = "button_optNameDelete";
            this.button_optNameDelete.Size = new System.Drawing.Size(97, 29);
            this.button_optNameDelete.TabIndex = 64;
            this.button_optNameDelete.Text = "删除";
            this.button_optNameDelete.UseVisualStyleBackColor = true;
            // 
            // button_optpNameAdd
            // 
            this.button_optpNameAdd.Location = new System.Drawing.Point(108, 166);
            this.button_optpNameAdd.Name = "button_optpNameAdd";
            this.button_optpNameAdd.Size = new System.Drawing.Size(97, 29);
            this.button_optpNameAdd.TabIndex = 63;
            this.button_optpNameAdd.Text = "增加";
            this.button_optpNameAdd.UseVisualStyleBackColor = true;
            // 
            // button_optNameQuery
            // 
            this.button_optNameQuery.Location = new System.Drawing.Point(5, 166);
            this.button_optNameQuery.Name = "button_optNameQuery";
            this.button_optNameQuery.Size = new System.Drawing.Size(97, 28);
            this.button_optNameQuery.TabIndex = 62;
            this.button_optNameQuery.Text = "查询";
            this.button_optNameQuery.UseVisualStyleBackColor = true;
            // 
            // groupBox_staff
            // 
            this.groupBox_staff.Controls.Add(this.dgv_staff);
            this.groupBox_staff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_staff.Font = new System.Drawing.Font("宋体", 11F);
            this.groupBox_staff.Location = new System.Drawing.Point(211, 0);
            this.groupBox_staff.Name = "groupBox_staff";
            this.groupBox_staff.Size = new System.Drawing.Size(526, 268);
            this.groupBox_staff.TabIndex = 1;
            this.groupBox_staff.TabStop = false;
            this.groupBox_staff.Text = "数据列表";
            // 
            // dgv_staff
            // 
            this.dgv_staff.AllowUserToAddRows = false;
            this.dgv_staff.AllowUserToDeleteRows = false;
            this.dgv_staff.BackgroundColor = System.Drawing.Color.White;
            this.dgv_staff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_staff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_staff.Location = new System.Drawing.Point(3, 20);
            this.dgv_staff.Name = "dgv_staff";
            this.dgv_staff.RowTemplate.Height = 23;
            this.dgv_staff.Size = new System.Drawing.Size(520, 245);
            this.dgv_staff.TabIndex = 0;
            // 
            // OptNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(737, 268);
            this.Controls.Add(this.groupBox_staff);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OptNameForm";
            this.Text = "OptNameForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox_staff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox_staff;
        private System.Windows.Forms.Label lab_DateTime;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Button button_optNameDownload;
        private System.Windows.Forms.Button button_optNameDelete;
        private System.Windows.Forms.Button button_optpNameAdd;
        private System.Windows.Forms.Button button_optNameQuery;
        private System.Windows.Forms.DataGridView dgv_staff;
        private System.Windows.Forms.TextBox comboBox_operatorName;
        private System.Windows.Forms.TextBox comboBox_operatorDate;
    }
}