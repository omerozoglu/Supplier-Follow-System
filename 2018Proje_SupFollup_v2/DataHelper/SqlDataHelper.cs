using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018Proje_SupFollup_v2.DataHelper
{
    public class SqlDataHelper
    {
        private SqlDataHelper()
        {

        }

        private static object _datasource;
        private static object _databasename;
        private static object _tablename;
        private static bool _ıntegratedsecurity;
        private static  object _user;
        private static object _password;

        public static object DataSource { get => _datasource; set => _datasource = value; }
        public static object DatabaseName { get => _databasename; set => _databasename = value; }
        public static object TableName { get => " " + _tablename + " "; set => _tablename = value; }
        public static bool IntegratedSecurity { get => _ıntegratedsecurity; set => _ıntegratedsecurity = value; }
        public static object UserName { get => _user; set => _user = value; }
        public static object UserPassword { get => _password; set => _password = value; }

        public static SqlConnection GetSqlConnection()
        {
            
            return  new SqlConnection("Data Source ="+DataSource+"; " +
                "Initial Catalog="+DatabaseName+";" +
                "Integrated Security ="+IntegratedSecurity);
        }

    }
}
