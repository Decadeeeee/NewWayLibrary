using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models //修改名字空间
{
	public class BookLendList
	{
		/// <summary>
		/// 无参构造方法
		/// </summary>
		public BookLendList(){ }
	
		/// <summary>
		/// 数据库非空字段的构造方法
		/// </summary>
		public BookLendList(string rid,string iSBN,DateTime lendTime,DateTime backTime,double money,bool isback,bool renew)
		{
			this.rid = rid;
			this.iSBN = iSBN;
			this.lendTime = lendTime;
			this.backTime = backTime;
			this.money = money;
			this.isback = isback;
			this.renew = renew;
		}
	
		private string rid;
		public string Rid
		{
			get { return rid; }
			set { rid = value; }
		}
	
		private string iSBN;
		public string ISBN
		{
			get { return iSBN; }
			set { iSBN = value; }
		}
	
		private DateTime lendTime;
		public DateTime LendTime
		{
			get { return lendTime; }
			set { lendTime = value; }
		}
	
		private DateTime backTime;
		public DateTime BackTime
		{
			get { return backTime; }
			set { backTime = value; }
		}
	
		private double money;
		public double Money
		{
			get { return money; }
			set { money = value; }
		}
	
		private bool isback;
		public bool Isback
		{
			get { return isback; }
			set { isback = value; }
		}
	
		private bool renew;
		public bool Renew
		{
			get { return renew; }
			set { renew = value; }
		}
	}
}