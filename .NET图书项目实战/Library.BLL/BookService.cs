using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DAL;
using Library.Models;
using Library.View.Models;

namespace Library.BLL
{
    class BookService
    {
        public static List<BookInfo> GetBookInfo()
        {
            List<BookList> bookLists = BookDAL.Select();
            List<BookCategory> bookCategories = BookCategoryDAL.Select();

            List<BookInfo> bookInfos = new List<BookInfo>();
            foreach (BookList book in bookLists)
            {
                BookInfo bookInfo = new BookInfo()
                {
                    ISBN = book.ISBN,
                    BookName = book.BookName,
                    BCategoryid = book.BCategoryid,
                    Author = book.Author,
                    Publisher = book.Publisher,
                    PublishTime = book.PublishTime,
                    Bookstate = book.Bookstate,
                    Num = book.Num,
                    Lendnum = book.Lendnum,
                    Price = book.Price,
                    Categoryname = bookCategories.FirstOrDefault(g=>g.BCategoryid==book.BCategoryid).BCategoryname
                };
                bookInfos.Add(bookInfo);
            }
            return bookInfos;
        }


    }
}
