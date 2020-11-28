using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace Library.DAL
{
    class DBHelper
    {
        private static string _sqlStr = ConfigurationManager.ConnectionStrings["Library"].ToString();

        /// <summary>
        /// 数据库连接对象
        /// </summary>
        private static SqlConnection _con;
        /// <summary>
        /// 数据库连接对象的封装
        /// </summary>
        public static SqlConnection Con
        { get {
                if (_con == null)
                    _con = new SqlConnection(_sqlStr);
                if (_con.State != System.Data.ConnectionState.Open)
                    _con.Open();
                return _con;
            }
        }

        /// <summary>
        /// 封装SqlCommand
        /// 传入sql语句
        /// 返回SqlCommand对象
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlCommand PreparCMD(string sql)
        {
            SqlCommand sqlCommand = new SqlCommand(sql, Con);
            return sqlCommand;
        }

        /// <summary>
        /// 执行Sql，返回执行结果
        /// 如果ExecuteNonQuery结果大于0，则代表查询成功返回true
        /// 否则返回false
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static bool ExecuteNonQuery(string sql)
        {
            SqlCommand sqlCommand = PreparCMD(sql);
            try
            {
                return sqlCommand.ExecuteNonQuery() > 0;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                sqlCommand.Connection.Close();
            }
        }
        /// <summary>
        /// 执行查询，返回DataReader对象的首行首列的值
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql)
        {
            SqlCommand sqlCommand = PreparCMD(sql);
            try
            {
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                sqlCommand.Connection.Close();
            }
        }

        /// <summary>
        /// 执行sql,返会DataReader对象
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object ExecuteReader(string sql)
        {
            SqlCommand sqlCommand = PreparCMD(sql);
            try
            {
                return sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// 填充DateSet，返回填充DateSet
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet GetSet(string sql)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, _sqlStr);
            sqlDataAdapter.Fill(dataSet);
            return dataSet;
        }

        /// <summary>
        /// 填充DataTable，返回填充DataTable
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable GetTable(string sql)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, _sqlStr);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
