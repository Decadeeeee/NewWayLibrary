using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DAL;
using Library.Models;

namespace Library.BLL
{
    public class LoginService
    {
        public static Manager CheckLogin(string id ,string pwd)
        {

            return ManagerUserDAL.Check(id, pwd);
        }
    }
}
