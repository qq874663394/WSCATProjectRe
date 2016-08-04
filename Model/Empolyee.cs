using System;
using System.Collections.Generic;

namespace Model
{
	/// <summary>
	/// 人员资料表
	/// </summary>
	[Serializable]
	public partial class Empolyee
	{
		public Empolyee()
		{}
        #region Model
        private int _emp_id;
        private string _emp_code;
        private string _emp_name;
        private string _emp_zhiwen;
        private string _emp_cardcode;
        private string _emp_depid;
        private string _emp_sex = "男";
        private string _emp_card;
        private int? _emp_state;
        private string _emp_phone;
        private string _emp_bank;
        private string _emp_openbank;
        private DateTime? _emp_birthday;
        private string _emp_email;
        private string _emp_education;
        private string _emp_school;
        private DateTime? _emp_entry = DateTime.Now;
        private string _emp_safetone;
        private string _emp_safettwo;
        private int? _emp_enable = 1;
        private int? _emp_clear = 1;
        private string _emp_password;
        private string _emp_userrole;
        private string _emp_area;
        private Role roles;
        private Department departments;
        /// <summary>
        /// 
        /// </summary>
        public int Emp_ID
        {
            set { _emp_id = value; }
            get { return _emp_id; }
        }
        /// <summary>
        /// 工号
        /// </summary>
        public string Emp_Code
        {
            set { _emp_code = value; }
            get { return _emp_code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Emp_Name
        {
            set { _emp_name = value; }
            get { return _emp_name; }
        }
        /// <summary>
        /// 指纹
        /// </summary>
        public string Emp_zhiwen
        {
            set { _emp_zhiwen = value; }
            get { return _emp_zhiwen; }
        }
        /// <summary>
        /// 卡号
        /// </summary>
        public string Emp_CardCode
        {
            set { _emp_cardcode = value; }
            get { return _emp_cardcode; }
        }
        /// <summary>
        /// 部门编号
        /// </summary>
        public string Emp_Depid
        {
            set { _emp_depid = value; }
            get { return _emp_depid; }
        }
        /// <summary>
        /// 默认男
        /// </summary>
        public string Emp_Sex
        {
            set { _emp_sex = value; }
            get { return _emp_sex; }
        }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string Emp_Card
        {
            set { _emp_card = value; }
            get { return _emp_card; }
        }
        /// <summary>
        /// 就职状态
        /// </summary>
        public int? Emp_State
        {
            set { _emp_state = value; }
            get { return _emp_state; }
        }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Emp_Phone
        {
            set { _emp_phone = value; }
            get { return _emp_phone; }
        }
        /// <summary>
        /// 银行卡号
        /// </summary>
        public string Emp_Bank
        {
            set { _emp_bank = value; }
            get { return _emp_bank; }
        }
        /// <summary>
        /// 开户行
        /// </summary>
        public string Emp_OpenBank
        {
            set { _emp_openbank = value; }
            get { return _emp_openbank; }
        }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime? Emp_Birthday
        {
            set { _emp_birthday = value; }
            get { return _emp_birthday; }
        }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Emp_Email
        {
            set { _emp_email = value; }
            get { return _emp_email; }
        }
        /// <summary>
        /// 最高学历
        /// </summary>
        public string Emp_Education
        {
            set { _emp_education = value; }
            get { return _emp_education; }
        }
        /// <summary>
        /// 毕业学校
        /// </summary>
        public string Emp_School
        {
            set { _emp_school = value; }
            get { return _emp_school; }
        }
        /// <summary>
        /// 入职时间,默认为创建时间
        /// </summary>
        public DateTime? Emp_Entry
        {
            set { _emp_entry = value; }
            get { return _emp_entry; }
        }
        /// <summary>
        /// 保留字段1
        /// </summary>
        public string Emp_safetone
        {
            set { _emp_safetone = value; }
            get { return _emp_safetone; }
        }
        /// <summary>
        /// 保留字段2
        /// </summary>
        public string Emp_safettwo
        {
            set { _emp_safettwo = value; }
            get { return _emp_safettwo; }
        }
        /// <summary>
        /// 0为启用，1为禁用
        /// </summary>
        public int? Emp_Enable
        {
            set { _emp_enable = value; }
            get { return _emp_enable; }
        }
        /// <summary>
        /// 0为删除，1为保留
        /// </summary>
        public int? Emp_Clear
        {
            set { _emp_clear = value; }
            get { return _emp_clear; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Emp_Password
        {
            set { _emp_password = value; }
            get { return _emp_password; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Emp_UserRole
        {
            set { _emp_userrole = value; }
            get { return _emp_userrole; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Emp_Area
        {
            set { _emp_area = value; }
            get { return _emp_area; }
        }

        public Role Roles
        {
            get
            {
                return roles;
            }

            set
            {
                roles = value;
            }
        }

        public Department Departments
        {
            get
            {
                return departments;
            }

            set
            {
                departments = value;
            }
        }
        #endregion Model

    }
}

