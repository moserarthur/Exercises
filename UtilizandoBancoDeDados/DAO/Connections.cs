using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace UtilizandoBancoDeDados.DAO
{
    public class Connections
    {
        const string SqlConn = "Data Source=DESKTOP-T0GRJLM;Initial Catalog=APEX;Integrated Security=True";
        public SqlConnection RetornaSqlConn()
        {
            return new SqlConnection(SqlConn);
        }
    }
}
