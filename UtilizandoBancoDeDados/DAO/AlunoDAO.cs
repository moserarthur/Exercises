using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using UtilizandoBancoDeDados.Model;

namespace UtilizandoBancoDeDados.DAO
{
    public class AlunoDAO
    {
        private SqlConnection _conn;
        private SqlTransaction _trans;
        public AlunoDAO(SqlConnection conn,SqlTransaction trans)
        {
            this._conn = conn;
            this._trans = trans; 
        }
        public void InserirAluno(string nome, int idade)
        {
            string sqlInsert = @"INSERT INTO ALUNO (NOME,IDADE) VALUES (@nome,@idade)";
            SqlCommand cmd = new SqlCommand(sqlInsert,_conn,_trans);
            cmd.Parameters.AddWithValue("@nome",nome);
            cmd.Parameters.AddWithValue("@idade",idade);
            cmd.ExecuteNonQuery();
        }
        public bool ValidaId(int id)
        {
            string sql = $@"SELECT ID FROM ALUNO WHERE ID = {id}";
            SqlCommand cmd = new SqlCommand(sql,_conn,_trans);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    return true;
                }
            }
            return false;
        }
        public void RemoveAluno(int id)
        {
            string sqlRemover = $"DELETE FROM ALUNO WHERE ID = {id}";
            SqlCommand cmd = new SqlCommand(sqlRemover,_conn,_trans);
            cmd.ExecuteNonQuery();
        }
        public List<AlunoModel> RetornaAlunos()
        {
            string sql = @"SELECT 
                                ID,
                                NOME,
                                IDADE
                           FROM ALUNO";
            List<AlunoModel> listaAlunos = new List<AlunoModel>();
            SqlCommand cmd = new SqlCommand(sql,_conn,_trans);
            using (SqlDataReader reader = cmd.ExecuteReader())
            { 
                while(reader.Read())
                {
                    AlunoModel aluno = new AlunoModel();
                    aluno.Id = Convert.ToInt32(reader["ID"]);
                    aluno.Nome = reader["NOME"].ToString();
                    aluno.Idade = Convert.ToInt32(reader["IDADE"]);
                    listaAlunos.Add(aluno);
                }
                return listaAlunos;
            }
        }
        public void AlterarAluno(AlunoModel aluno)
        {
            string sqlUpdate = @"UPDATE ALUNO SET NOME = @nome, IDADE = @idade WHERE ID = "+aluno.Id;
            SqlCommand cmd = new SqlCommand(sqlUpdate,_conn,_trans);
            cmd.Parameters.AddWithValue("@nome",aluno.Nome);
            cmd.Parameters.AddWithValue("@idade",aluno.Idade);
            cmd.ExecuteNonQuery();
        }
    }
}
