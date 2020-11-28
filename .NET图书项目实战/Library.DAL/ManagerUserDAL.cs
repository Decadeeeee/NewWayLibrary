using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Library.Models;

namespace Library.DAL
{
    public class ManagerUserDAL
    {

        /// <summary>
        /// 用户和管理员信息访问类
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public List<Manager> Select(string id,string pwd)
        {
            string sql = @"SELECT * FROM [dbo].[Manager]";

            DataTable dataTable = DBHelper.GetTable(sql);
            List<Manager> managers = new List<Manager>();
            foreach(DataRow dataRow in dataTable.Rows)
            {
                Manager manager = new Manager()
                {
                    Managerid = dataRow["managerid"].ToString().Trim(),
                    ManagerPassword = dataRow["managerpassword"].ToString().Trim(),
                    MIdentity = (bool)dataRow["MIdentity"]
                };
                managers.Add(manager);
            }
           
            return managers;

        }

        /// <summary>
        /// 用户管理员登录访问类
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static Manager Check(string id,string pwd)
        {
            string sql = @"SELECT * FROM Manager
                            where managerid ='"+id+
                            "'and managerPassword='"+pwd+"'";

            DataTable dataTable = DBHelper.GetTable(sql);
            Manager manager = new Manager() {
                Managerid = dataTable.Rows[0]["managerid"].ToString().Trim(),
                ManagerPassword= dataTable.Rows[0]["managerpassword"].ToString().Trim(),
                MIdentity = (bool)dataTable.Rows[0]["MIdentity"]
            };
            return manager;

        }
    }
}
