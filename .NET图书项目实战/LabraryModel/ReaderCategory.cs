using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models //修改名字空间
{
	public class ReaderCategory
	{
		/// <summary>
		/// 无参构造方法
		/// </summary>
		public ReaderCategory(){ }
	
		/// <summary>
		/// 数据库非空字段的构造方法
		/// </summary>
		public ReaderCategory(int rcategoryid,string rcategoryname,int rbnum,int rday)
		{
			this.rcategoryid = rcategoryid;
			this.rcategoryname = rcategoryname;
			this.rbnum = rbnum;
			this.rday = rday;
		}
	
		private int rcategoryid;
		public int Rcategoryid
		{
			get { return rcategoryid; }
			set { rcategoryid = value; }
		}
	
		private string rcategoryname;
		public string Rcategoryname
		{
			get { return rcategoryname; }
			set { rcategoryname = value; }
		}
	
		private int rbnum;
		public int Rbnum
		{
			get { return rbnum; }
			set { rbnum = value; }
		}
	
		private int rday;
		public int Rday
		{
			get { return rday; }
			set { rday = value; }
		}
	}
}