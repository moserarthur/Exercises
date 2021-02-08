using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ExercicioBancoDados.DAO
{
    public class Connections
    {
        const string conn = @"Data Source=DESKTOP-T0GRJLM;Initial Catalog=EXERCICIO;Integrated Security=True";
        public static SqlConnection RetornaConexao()
        {
            return new SqlConnection(conn);
        }
    }
}
