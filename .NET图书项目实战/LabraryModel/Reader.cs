using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models //�޸����ֿռ�
{
	public class Reader
	{
		/// <summary>
		/// �޲ι��췽��
		/// </summary>
		public Reader(){ }
	
		/// <summary>
		/// ���ݿ�ǿ��ֶεĹ��췽��
		/// </summary>
		public Reader(string rid,string rname,int rcategoryid,int rbLnum)
		{
			this.rid = rid;
			this.rname = rname;
			this.rcategoryid = rcategoryid;
			this.rbLnum = rbLnum;
		}
	
		private string rid;
		public string Rid
		{
			get { return rid; }
			set { rid = value; }
		}
	
		private string rname;
		public string Rname
		{
			get { return rname; }
			set { rname = value; }
		}
	
		private int rcategoryid;
		public int Rcategoryid
		{
			get { return rcategoryid; }
			set { rcategoryid = value; }
		}
	
		private string phone;
		public string Phone
		{
			get { return phone; }
			set { phone = value; }
		}
	
		private int rbLnum;
		public int RbLnum
		{
			get { return rbLnum; }
			set { rbLnum = value; }
		}
	}
}