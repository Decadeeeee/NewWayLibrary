using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models //�޸����ֿռ�
{
	public class Manager
	{
		/// <summary>
		/// �޲ι��췽��
		/// </summary>
		public Manager(){ }

		/// <summary>
		/// ���ݿ�ǿ��ֶεĹ��췽��
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