using System;
namespace Course.Model
{
	/// <summary>
	/// ims_isp_tool_selcourse:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Selcourse
	{
		public Selcourse()
		{}
		#region Model
		private int _id;
		private string _openid;
		private int? _uid;
		private int? _uniacid;
		private string _cid;
		private string _teacher;
		private string _classroom;
		private int? _weekofterm;
		private int? _dayofweek;
		private int? _startnumber;
		private int? _endnumber;
		private string _name;
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
		public string cid
		{
			set{ _cid=value;}
			get{return _cid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string teacher
		{
			set{ _teacher=value;}
			get{return _teacher;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string classroom
		{
			set{ _classroom=value;}
			get{return _classroom;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? weekofterm
		{
			set{ _weekofterm=value;}
			get{return _weekofterm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? dayofweek
		{
			set{ _dayofweek=value;}
			get{return _dayofweek;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? startnumber
		{
			set{ _startnumber=value;}
			get{return _startnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? endnumber
		{
			set{ _endnumber=value;}
			get{return _endnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		#endregion Model

	}
}

