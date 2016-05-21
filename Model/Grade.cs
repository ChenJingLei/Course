using System;
namespace Course.Model
{
	/// <summary>
	/// ims_isp_tool_grade:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Grade
	{
		public Grade()
		{}
		#region Model
		private int _id;
		private string _cid;
		private string _name;
		private decimal? _studyscore;
		private decimal? _normal;
		private decimal? _halfsterm;
		private decimal? _final;
		private decimal? _total;
		private decimal? _secondfinal;
		private decimal? _secondtotal;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
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
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? studyscore
		{
			set{ _studyscore=value;}
			get{return _studyscore;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? normal
		{
			set{ _normal=value;}
			get{return _normal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? halfsterm
		{
			set{ _halfsterm=value;}
			get{return _halfsterm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? final
		{
			set{ _final=value;}
			get{return _final;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? total
		{
			set{ _total=value;}
			get{return _total;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? secondfinal
		{
			set{ _secondfinal=value;}
			get{return _secondfinal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? secondtotal
		{
			set{ _secondtotal=value;}
			get{return _secondtotal;}
		}
		#endregion Model

	}
}

