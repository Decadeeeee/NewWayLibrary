using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.View.Models
{
    public class BookInfo:BookList
    {
        /// <summary>
        /// 图书类别
        /// </summary>
        public string Categoryname { get; set; }
    }
}
