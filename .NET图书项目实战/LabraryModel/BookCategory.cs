using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models //修改名字空间
{
	public class BookCategory
	{
		/// <summary>
		/// 无参构造方法
		/// </summary>
		public BookCategory(){ }
	
		/// <summary>
		/// 数据库非空字段的构造方法
		/// </summary>
		public BookCategory(int bCategoryid,string bCategoryname)
		{
			this.bCategoryid = bCategoryid;
			this.bCategoryname = bCategoryname;
		}
	
		private int bCategoryid;
		public int BCategoryid
		{
			get { return bCategoryid; }
			set { bCategoryid = value; }
		}
	
		private string bCategoryname;
		public string BCategoryname
		{
			get { return bCategoryname; }
			set { bCategoryname = value; }
		}
	}
}