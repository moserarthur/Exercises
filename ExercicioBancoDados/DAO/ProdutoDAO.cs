using ExercicioBancoDados.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ExercicioBancoDados.DAO
{
    public class ProdutoDAO
    {
        private SqlConnection _conn;
        private SqlTransaction _trans;
        public ProdutoDAO(SqlConnection conn, SqlTransaction trans)
        {
            this._conn = conn;
            this._trans = trans;
        }
        public void InserirProduto(string descricao, double preco)
        {
            string sqlInsert = @"INSERT INTO PRODUTOS (DESCRICAO,PRECO) VALUES (@descricao,@preco)";
            SqlCommand cmd = new SqlCommand(sqlInsert,_conn,_trans);
            cmd.Parameters.AddWithValue("@descricao",descricao);
            cmd.Parameters.AddWithValue("@preco",preco);
            cmd.ExecuteNonQuery();
        }
        public List<Produto> RetornaProdutos()
        {
            string sql = @"SELECT 
                                DESCRICAO, 
                                PRECO
                            FROM PRODUTOS";
            var lista = new List<Produto>();
            SqlCommand cmd = new SqlCommand(sql,_conn,_trans);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Produto p = new Produto()
                    {
                        Descricao = reader["DESCRICAO"].ToString(),
                        Preco = Convert.ToDouble(reader["PRECO"])
                    };
                    lista.Add(p);
                }
            }
            return lista;
        }
    }
}
