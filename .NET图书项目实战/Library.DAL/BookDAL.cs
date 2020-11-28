using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

using System.Data;

namespace Library.DAL
{
    public class BookDAL
    {
        public static List<BookList> Select()
        {
            string sql = @"SELECT [ISBN]
      ,[BookName]
      ,[bCategoryid]
      ,[author]
      ,[publisher]
      ,[publishTime]
      ,[bookstate]
      ,[num]
      ,[lendnum]
      ,[price]
  FROM BookList";

            DataTable dataTable = DBHelper.GetTable(sql);
            List<BookList> bookLists = new List<BookList>();
            foreach(DataRow dataRow in dataTable.Rows)
            {
                BookList bookList = new BookList()
                {
                    ISBN = dataRow["ISBN"].ToString(),
                    BookName = dataRow["BookName"].ToString(),
                    BCategoryid = (int)dataRow["bCategoryid"],
                    Author = dataRow["author"].ToString(),
                    Publisher = dataRow["publisher"].ToString(),
                    PublishTime = (int)dataRow["publishTime"],
                    Bookstate = (bool)dataRow["bookstate"],
                    Num = (int)dataRow["num"],
                    Lendnum = (int)dataRow["lendnum"],
                    Price = (double)dataRow["price"]
                };
                bookLists.Add(bookList);
            }
            return bookLists;
        }

    }
}
