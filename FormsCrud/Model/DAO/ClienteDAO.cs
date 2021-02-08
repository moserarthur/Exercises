using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsCrud.Model.DAO
{
    public class ClienteDAO
    {
        private readonly SqlConnection _conn;
        private readonly SqlTransaction _trans;
        public ClienteDAO(SqlConnection conn, SqlTransaction trans)
        {
            _conn = conn;
            _trans = trans;
        }
        public void InserirCliente(ClienteModel cliente)
        {
            string sql = @"INSERT INTO CLIENTE
                            (NOME,IDADE,EMAIL,ENDERECO) VALUES
                            (@nome,@idade,@email,@endereco) ";
            SqlCommand cmd = new SqlCommand(sql,_conn,_trans);
            cmd.Parameters.AddWithValue("@nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@idade", cliente.Idade);
            cmd.Parameters.AddWithValue("@email", cliente.Email);
            cmd.Parameters.AddWithValue("@endereco", cliente.Endereco);
            cmd.ExecuteNonQuery();
        }
        public List<ClienteModel> RetornaClientes()
        {
            string sql = @"SELECT 
                                ID,
                                NOME,
                                IDADE,
                                EMAIL,
                                ENDERECO 
                           FROM CLIENTE 
                                ORDER BY NOME";
            var lista = new List<ClienteModel>();
            SqlCommand cmd = new SqlCommand(sql,_conn,_trans);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    ClienteModel c = new ClienteModel()
                    {
                        Id = Convert.ToInt32(reader["ID"]),
                        Nome = reader["NOME"].ToString(),
                        Idade = Convert.ToInt32(reader["IDADE"]),
                        Email = reader["EMAIL"].ToString(),
                        Endereco = reader["ENDERECO"].ToString()
                    };
                    lista.Add(c);
                }
                return lista;
            }
        }
        public void RemoverCliente(int id)
        {
            string sqlDelete = @"DELETE FROM CLIENTE WHERE ID = "+ id;
            SqlCommand cmd = new SqlCommand(sqlDelete,_conn,_trans);
            cmd.ExecuteNonQuery();
        }
    }
}
