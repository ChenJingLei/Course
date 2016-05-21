using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Course.DAL
{
	/// <summary>
	/// 数据访问类:ims_isp_tool_oalogininfo
	/// </summary>
	public partial class OaLoginInfoDal
	{
		public OaLoginInfoDal()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("id", "ims_isp_tool_oalogininfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ims_isp_tool_oalogininfo");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Course.Model.OaLoginInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ims_isp_tool_oalogininfo(");
			strSql.Append("openid,oa_uname,oa_pwd,uniacid,uid,updatetime)");
			strSql.Append(" values (");
			strSql.Append("@openid,@oa_uname,@oa_pwd,@uniacid,@uid,@updatetime)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@openid", MySqlDbType.VarChar,42),
					new MySqlParameter("@oa_uname", MySqlDbType.VarChar,20),
					new MySqlParameter("@oa_pwd", MySqlDbType.VarChar,50),
					new MySqlParameter("@uniacid", MySqlDbType.Int32,10),
					new MySqlParameter("@uid", MySqlDbType.Int32,10),
					new MySqlParameter("@updatetime", MySqlDbType.DateTime)};
			parameters[0].Value = model.openid;
			parameters[1].Value = model.oa_uname;
			parameters[2].Value = model.oa_pwd;
			parameters[3].Value = model.uniacid;
			parameters[4].Value = model.uid;
			parameters[5].Value = model.updatetime;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Course.Model.OaLoginInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ims_isp_tool_oalogininfo set ");
			strSql.Append("openid=@openid,");
			strSql.Append("oa_uname=@oa_uname,");
			strSql.Append("oa_pwd=@oa_pwd,");
			strSql.Append("uniacid=@uniacid,");
			strSql.Append("uid=@uid,");
			strSql.Append("updatetime=@updatetime");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@openid", MySqlDbType.VarChar,42),
					new MySqlParameter("@oa_uname", MySqlDbType.VarChar,20),
					new MySqlParameter("@oa_pwd", MySqlDbType.VarChar,50),
					new MySqlParameter("@uniacid", MySqlDbType.Int32,10),
					new MySqlParameter("@uid", MySqlDbType.Int32,10),
					new MySqlParameter("@updatetime", MySqlDbType.DateTime),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.openid;
			parameters[1].Value = model.oa_uname;
			parameters[2].Value = model.oa_pwd;
			parameters[3].Value = model.uniacid;
			parameters[4].Value = model.uid;
			parameters[5].Value = model.updatetime;
			parameters[6].Value = model.id;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ims_isp_tool_oalogininfo ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ims_isp_tool_oalogininfo ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Course.Model.OaLoginInfo GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,openid,oa_uname,oa_pwd,uniacid,uid,updatetime from ims_isp_tool_oalogininfo ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

			Course.Model.OaLoginInfo model=new Course.Model.OaLoginInfo();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Course.Model.OaLoginInfo DataRowToModel(DataRow row)
		{
			Course.Model.OaLoginInfo model=new Course.Model.OaLoginInfo();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["openid"]!=null)
				{
					model.openid=row["openid"].ToString();
				}
				if(row["oa_uname"]!=null)
				{
					model.oa_uname=row["oa_uname"].ToString();
				}
				if(row["oa_pwd"]!=null)
				{
					model.oa_pwd=row["oa_pwd"].ToString();
				}
				if(row["uniacid"]!=null && row["uniacid"].ToString()!="")
				{
					model.uniacid=int.Parse(row["uniacid"].ToString());
				}
				if(row["uid"]!=null && row["uid"].ToString()!="")
				{
					model.uid=int.Parse(row["uid"].ToString());
				}
				if(row["updatetime"]!=null && row["updatetime"].ToString()!="")
				{
					model.updatetime=DateTime.Parse(row["updatetime"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,openid,oa_uname,oa_pwd,uniacid,uid,updatetime ");
			strSql.Append(" FROM ims_isp_tool_oalogininfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM ims_isp_tool_oalogininfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from ims_isp_tool_oalogininfo T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			MySqlParameter[] parameters = {
					new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@PageSize", MySqlDbType.Int32),
					new MySqlParameter("@PageIndex", MySqlDbType.Int32),
					new MySqlParameter("@IsReCount", MySqlDbType.Bit),
					new MySqlParameter("@OrderType", MySqlDbType.Bit),
					new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
					};
			parameters[0].Value = "ims_isp_tool_oalogininfo";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

