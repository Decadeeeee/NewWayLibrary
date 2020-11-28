using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Library.Models;

namespace Library.DAL
{
    public class BookCategoryDAL
    {
        public static List<BookCategory> Select()
        {
            string sql = @"SELECT [bCategoryid]
      ,[bCategoryname]
  FROM BookCategory";
            List<BookCategory> bookCategories = new List<BookCategory>();
            DataTable dataTable = DBHelper.GetTable(sql);

            foreach(DataRow dataRow in dataTable.Rows)
            {
                BookCategory bookCategory = new BookCategory()
                {
                    BCategoryid = (int)dataRow["bCategoryid"],
                    BCategoryname = dataRow["bCategoryname"].ToString()

                };
                bookCategories.Add(bookCategory);
            }

            return bookCategories;
        }
    }
}
