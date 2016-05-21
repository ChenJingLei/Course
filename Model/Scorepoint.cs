using System;
namespace Course.Model
{
	/// <summary>
	/// ims_isp_tool_scorepoint:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Scorepoint
	{
		public Scorepoint()
		{}
		#region Model
		private int _id;
		private string _openid;
		private int? _uid;
		private int? _uniacid;
		private string _srterm;
		private string _srterm2;
		private decimal? _gpa;
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
		public int? uid
		{
			set{ _uid=value;}
			get{return _uid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? uniacid
		{
			set{ _uniacid=value;}
			get{return _uniacid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string srTerm
		{
			set{ _srterm=value;}
			get{return _srterm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string srTerm2
		{
			set{ _srterm2=value;}
			get{return _srterm2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? gpa
		{
			set{ _gpa=value;}
			get{return _gpa;}
		}
		#endregion Model

	}
}

