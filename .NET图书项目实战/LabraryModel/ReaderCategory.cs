using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models //�޸����ֿռ�
{
	public class ReaderCategory
	{
		/// <summary>
		/// �޲ι��췽��
		/// </summary>
		public ReaderCategory(){ }
	
		/// <summary>
		/// ���ݿ�ǿ��ֶεĹ��췽��
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