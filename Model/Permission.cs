using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Permission
    {
        #region model

        private int per_ID;
        private string per_Code;
        private string per_ModuleName;
        private int per_ReadState = 0;
        private int per_WriteState = 0;
        private int per_AuditState = 0;
        private int per_Clear = 1;
        private string per_Type;
        private string per_RoleCode;

        public int Per_ID
        {
            get
            {
                return per_ID;
            }

            set
            {
                per_ID = value;
            }
        }
        /// <summary>
		/// 编号
		/// </summary>
        public string Per_Code
        {
            get
            {
                return per_Code;
            }

            set
            {
                per_Code = value;
            }
        }
        /// <summary>
		/// 模块名称
		/// </summary>
        public string Per_ModuleName
        {
            get
            {
                return per_ModuleName;
            }

            set
            {
                per_ModuleName = value;
            }
        }
        /// <summary>
		/// 读入权限
		/// </summary>
        public int Per_ReadState
        {
            get
            {
                return per_ReadState;
            }

            set
            {
                per_ReadState = value;
            }
        }
        /// <summary>
		/// 写入权限
		/// </summary>
        public int Per_WriteState
        {
            get
            {
                return per_WriteState;
            }

            set
            {
                per_WriteState = value;
            }
        }
        /// <summary>
		/// 审核权限
		/// </summary>
        public int Per_AuditState
        {
            get
            {
                return per_AuditState;
            }

            set
            {
                per_AuditState = value;
            }
        }
        /// <summary>
		/// 是否清除
		/// </summary>
        public int Per_Clear
        {
            get
            {
                return per_Clear;
            }

            set
            {
                per_Clear = value;
            }
        }

        /// <summary>
        /// 所属的分类
        /// </summary>
        public string Per_Type
        {
            get
            {
                return per_Type;
            }

            set
            {
                per_Type = value;
            }
        }

        /// <summary>
        /// 角色code
        /// </summary>
        public string Per_RoleCode
        {
            get
            {
                return per_RoleCode;
            }

            set
            {
                per_RoleCode = value;
            }
        }


        #endregion
    }
}
