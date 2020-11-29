using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DAL;

namespace Library.BLL
{
    public class ChangePwdservice
    {
        public static bool SetPassword(string id,string pwd)
        {
            string sql = @"UPDATE Manager SET managerPassword = '"+pwd+"'WHERE managerid = '"+id+"'";

            return DBHelper.ExecuteNonQuery(sql);

        }
    }
}
