using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models //修改名字空间
{
	public class BookList
	{
		/// <summary>
		/// 无参构造方法
		/// </summary>
		public BookList(){ }
	
		/// <summary>
		/// 数据库非空字段的构造方法
		/// </summary>
		public BookList(string iSBN,string bookName,int bCategoryid,string author,string publisher,int publishTime,bool bookstate,int num,int lendnum,double price)
		{
			this.iSBN = iSBN;
			this.bookName = bookName;
			this.bCategoryid = bCategoryid;
			this.author = author;
			this.publisher = publisher;
			this.publishTime = publishTime;
			this.bookstate = bookstate;
			this.num = num;
			this.lendnum = lendnum;
			this.price = price;
		}
	
		private string iSBN;
		public string ISBN
		{
			get { return iSBN; }
			set { iSBN = value; }
		}
	
		private string bookName;
		public string BookName
		{
			get { return bookName; }
			set { bookName = value; }
		}
	
		private int bCategoryid;
		public int BCategoryid
		{
			get { return bCategoryid; }
			set { bCategoryid = value; }
		}
	
		private string author;
		public string Author
		{
			get { return author; }
			set { author = value; }
		}
	
		private string publisher;
		public string Publisher
		{
			get { return publisher; }
			set { publisher = value; }
		}
	
		private int publishTime;
		public int PublishTime
		{
			get { return publishTime; }
			set { publishTime = value; }
		}
	
		private bool bookstate;
		public bool Bookstate
		{
			get { return bookstate; }
			set { bookstate = value; }
		}
	
		private int num;
		public int Num
		{
			get { return num; }
			set { num = value; }
		}
	
		private int lendnum;
		public int Lendnum
		{
			get { return lendnum; }
			set { lendnum = value; }
		}
	
		private double price;
		public double Price
		{
			get { return price; }
			set { price = value; }
		}
	}
}