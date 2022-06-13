using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5._1
{
    class ConnectionDb
    {
        public SqlConnection GetConnection()
        {
            string connectString =
            "Data source = localhost; Initial Catalog = DbTest; User = sa, password = sa";
            SqlConnection connection = new SqlConnection(connectString);
            return connection;
        }

    }
}
