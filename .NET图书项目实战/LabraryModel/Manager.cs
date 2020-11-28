using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models //修改名字空间
{
	public class Manager
	{
		/// <summary>
		/// 无参构造方法
		/// </summary>
		public Manager(){ }

		/// <summary>
		/// 数据库非空字段的构造方法
		/// </summary>
		public Manager(string managerid,string managerPassword,bool mIdentity)
		{
			this.managerid = managerid;
			this.managerPassword = managerPassword;
			this.mIdentity = mIdentity;
		}
	
		private string managerid;
		public string Managerid
		{
			get { return managerid; }
			set { managerid = value; }
		}
	
		private string managerPassword;
		public string ManagerPassword
		{
			get { return managerPassword; }
			set { managerPassword = value; }
		}
	
		private bool mIdentity;
		public bool MIdentity
		{
			get { return mIdentity; }
			set { mIdentity = value; }
		}
	}
}