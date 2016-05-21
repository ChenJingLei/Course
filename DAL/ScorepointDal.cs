using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Course.DAL
{
	/// <summary>
	/// 数据访问类:ims_isp_tool_scorepoint
	/// </summary>
	public partial class ScorepointDal
	{
		public ScorepointDal()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("id", "ims_isp_tool_scorepoint"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ims_isp_tool_scorepoint");
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
		public bool Add(Course.Model.Scorepoint model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ims_isp_tool_scorepoint(");
			strSql.Append("openid,uid,uniacid,srTerm,srTerm2,gpa)");
			strSql.Append(" values (");
			strSql.Append("@openid,@uid,@uniacid,@srTerm,@srTerm2,@gpa)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@openid", MySqlDbType.VarChar,42),
					new MySqlParameter("@uid", MySqlDbType.Int32,11),
					new MySqlParameter("@uniacid", MySqlDbType.Int32,11),
					new MySqlParameter("@srTerm", MySqlDbType.VarChar,6),
					new MySqlParameter("@srTerm2", MySqlDbType.VarChar,6),
					new MySqlParameter("@gpa", MySqlDbType.Decimal,10)};
			parameters[0].Value = model.openid;
			parameters[1].Value = model.uid;
			parameters[2].Value = model.uniacid;
			parameters[3].Value = model.srTerm;
			parameters[4].Value = model.srTerm2;
			parameters[5].Value = model.gpa;

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
		public bool Update(Course.Model.Scorepoint model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ims_isp_tool_scorepoint set ");
			strSql.Append("openid=@openid,");
			strSql.Append("uid=@uid,");
			strSql.Append("uniacid=@uniacid,");
			strSql.Append("srTerm=@srTerm,");
			strSql.Append("srTerm2=@srTerm2,");
			strSql.Append("gpa=@gpa");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@openid", MySqlDbType.VarChar,42),
					new MySqlParameter("@uid", MySqlDbType.Int32,11),
					new MySqlParameter("@uniacid", MySqlDbType.Int32,11),
					new MySqlParameter("@srTerm", MySqlDbType.VarChar,6),
					new MySqlParameter("@srTerm2", MySqlDbType.VarChar,6),
					new MySqlParameter("@gpa", MySqlDbType.Decimal,10),
					new MySqlParameter("@id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.openid;
			parameters[1].Value = model.uid;
			parameters[2].Value = model.uniacid;
			parameters[3].Value = model.srTerm;
			parameters[4].Value = model.srTerm2;
			parameters[5].Value = model.gpa;
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
			strSql.Append("delete from ims_isp_tool_scorepoint ");
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
			strSql.Append("delete from ims_isp_tool_scorepoint ");
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
		public Course.Model.Scorepoint GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,openid,uid,uniacid,srTerm,srTerm2,gpa from ims_isp_tool_scorepoint ");
			strSql.Append(" where id=@id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@id", MySqlDbType.Int32)
			};
			parameters[0].Value = id;

			Course.Model.Scorepoint model=new Course.Model.Scorepoint();
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
		public Course.Model.Scorepoint DataRowToModel(DataRow row)
		{
			Course.Model.Scorepoint model=new Course.Model.Scorepoint();
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
				if(row["uid"]!=null && row["uid"].ToString()!="")
				{
					model.uid=int.Parse(row["uid"].ToString());
				}
				if(row["uniacid"]!=null && row["uniacid"].ToString()!="")
				{
					model.uniacid=int.Parse(row["uniacid"].ToString());
				}
				if(row["srTerm"]!=null)
				{
					model.srTerm=row["srTerm"].ToString();
				}
				if(row["srTerm2"]!=null)
				{
					model.srTerm2=row["srTerm2"].ToString();
				}
				if(row["gpa"]!=null && row["gpa"].ToString()!="")
				{
					model.gpa=decimal.Parse(row["gpa"].ToString());
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
			strSql.Append("select id,openid,uid,uniacid,srTerm,srTerm2,gpa ");
			strSql.Append(" FROM ims_isp_tool_scorepoint ");
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
			strSql.Append("select count(1) FROM ims_isp_tool_scorepoint ");
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
			strSql.Append(")AS Row, T.*  from ims_isp_tool_scorepoint T ");
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
			parameters[0].Value = "ims_isp_tool_scorepoint";
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

