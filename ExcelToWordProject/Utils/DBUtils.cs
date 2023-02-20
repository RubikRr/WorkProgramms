using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ExcelToWordProject.Utils
{
    internal class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "a41035.mysql.mchost.ru";
            int port = 3306;
            string database = "a41035_1";
            string username = "a41035_1";
            string password = "Math535130";

            return DBMySQLUtils.GetDbConnection(host, port, database, username, password);
        }
    }
}
