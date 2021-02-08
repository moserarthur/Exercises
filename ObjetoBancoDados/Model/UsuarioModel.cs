using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ObjetoBancoDados.Model
{
    public class UsuarioModel
    {
        public UsuarioModel(int id, string login, string senha)
        {
            this.Id = id;
            this.Login = login;
            this.Senha = senha;
        }
        public int Id { get;private set; }
        public string Login { get;private set; }
        public string Senha { get; private set; }
        private const string conexao = "Data Source=DESKTOP-T0GRJLM;Initial Catalog=APEX;Integrated Security=True";
        public List<UsuarioModel> RetornaUsuarios()
        {
            List<UsuarioModel> lista = new List<UsuarioModel>();
            string sql = @"SELECT * FROM USUARIO";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql,conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new UsuarioModel(
                            Convert.ToInt32(reader["Id"]),
                            reader["Login"].ToString(),
                            reader["Senha"].ToString()
                        )) ;
                }
            }
            return lista;
        }
    }
}
