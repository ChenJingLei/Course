using System;
namespace Course.Model
{
	/// <summary>
	/// ims_isp_tool_oalogininfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OaLoginInfo
	{
		public OaLoginInfo()
		{}
		#region Model
		private int _id;
		private string _openid;
		private string _oa_uname;
		private string _oa_pwd;
		private int _uniacid;
		private int _uid;
		private DateTime? _updatetime;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string openid
		{
			set{ _openid=value;}
			get{return _openid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string oa_uname
		{
			set{ _oa_uname=value;}
			get{return _oa_uname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string oa_pwd
		{
			set{ _oa_pwd=value;}
			get{return _oa_pwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int uniacid
		{
			set{ _uniacid=value;}
			get{return _uniacid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int uid
		{
			set{ _uid=value;}
			get{return _uid;}
		}
		/// <summary>
		/// on update CURRENT_TIMESTAMP
		/// </summary>
		public DateTime? updatetime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		#endregion Model

	}
}

