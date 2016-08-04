using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using Model;

namespace BLL
{
    public partial class ProfessionManager
    {
        ProfessionService ps = new ProfessionService();
        #region 增加信息
        /// <summary>
        /// 增加信息
        /// </summary>
        /// <param name="profession">模型载体</param>
        /// <returns>受影响行数</returns>
        public int InsProfession(Profession profession)
        {
            return ps.InsProfession(profession);
        }
        #endregion

        #region 假删除
        /// <summary>
        /// 假删除
        /// </summary>
        /// <param name="ST_Code">编码</param>
        /// <returns></returns>
        public int FalseDelClear(string ST_Code)
        {
            return ps.FalseDelClear(ST_Code);
        }
        #endregion

        #region 禁用
        /// <summary>
        /// 禁用
        /// </summary>
        /// <param name="ST_Code">编码</param>
        /// <returns></returns>
        public int FalseDelEnable(string ST_Code)
        {
            return ps.FalseDelClear(ST_Code);
        }
        #endregion

        #region 根据编号更新信息
        /// <summary>
        /// 根据编号更新信息
        /// </summary>
        /// <param name="profession">模型载体</param>
        /// <returns>受影响行数</returns>
        public int UpdateProfession(Profession profession)
        {
            return ps.UpdateProfession(profession);
        }
        #endregion

        #region 根据编号查询信息
        /// <summary>
        /// 根据编号查询信息
        /// </summary>
        /// <returns>List集合</returns>
        public List<Profession> SelProfessionByCode(string ST_Code)
        {
            return ps.SelProfessionByCode(ST_Code);
        }
        #endregion

        #region 根据类别名称查询编码
        /// <summary>
        /// 根据类别名称查询编码
        /// </summary>
        /// <param name="ST_Name"></param>
        /// <returns></returns>
        public string SelProfessionByName(string ST_Name)
        {
            return ps.SelProfessionByName(ST_Name);
        }
        #endregion

        #region 查询所有信息
        /// <summary>
        /// 查询所有信息
        /// </summary>
        /// <returns>所有数据以DataTable的形式返回</returns>
        public DataTable SelProfession()
        {
            return ps.SelProfession();
        }
        #endregion

        public DataSet GetList(string strWhere)
        {
            return ps.GetList(strWhere);
        }
    }
}
