using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models //�޸����ֿռ�
{
	public class BookCategory
	{
		/// <summary>
		/// �޲ι��췽��
		/// </summary>
		public BookCategory(){ }
	
		/// <summary>
		/// ���ݿ�ǿ��ֶεĹ��췽��
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