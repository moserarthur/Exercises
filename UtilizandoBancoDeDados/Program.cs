using System;
using UtilizandoBancoDeDados.DAO;
using UtilizandoBancoDeDados.Model;

namespace UtilizandoBancoDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 1 - para inserir, 2 - remover 3 - ver usuários já cadastrados, 4 - Alterar Aluno");
            switch (Console.ReadLine())
            {
                case "1":
                    Inserir();
                    break;
                case "2":
                    Remover();
                    break;
                case "3":
                    MostraUsuarios();
                    break;
                case "4":
                    AlterarAluno();
                    break;
                default:
                    break;
            }
        }
        static void Inserir()
        {
            var conn = new Connections().RetornaSqlConn();
            conn.Open();
            var trans = conn.BeginTransaction();
            try
            {
                Console.WriteLine("Escreva seu nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Escreva seu idade");
                int idade = Convert.ToInt32(Console.ReadLine());
                new AlunoDAO(conn, trans).InserirAluno(nome, idade);
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
                Console.ReadLine();
            }
        }
        static void Remover()
        {
            var conn = new Connections().RetornaSqlConn();
            conn.Open();
            var trans = conn.BeginTransaction();
            try
            {
                Console.WriteLine("Informe o código do usuário que você deseja remover");
                int id = Convert.ToInt32(Console.ReadLine());
                if (new AlunoDAO(conn, trans).ValidaId(id))
                {
                    new AlunoDAO(conn, trans).RemoveAluno(id);
                    trans.Commit();
                }
                else
                {
                    Console.WriteLine("Esse código não existe tente novamente");
                    Remover();
                }
            }
            catch(Exception ex)
            {

                trans.Rollback();
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
        static void MostraUsuarios()
        {
            var conn = new Connections().RetornaSqlConn();
            conn.Open();
            var trans = conn.BeginTransaction();
            try
            {
                var listaAlunos = new AlunoDAO(conn,trans).RetornaAlunos();
                trans.Commit();
                for (int i = 0; i < listaAlunos.Count; i++)
                {
                    Console.WriteLine($"Nome: {listaAlunos[i].Nome} Idade: {listaAlunos[i].Idade}");
                }

            }
            catch(Exception ex)
            {
                trans.Rollback();
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        static void AlterarAluno()
        {
            var conn = new Connections().RetornaSqlConn();
            conn.Open();
            var trans = conn.BeginTransaction();
            try
            {
                Console.WriteLine("Informe o código do aluno");
                int id = Convert.ToInt32(Console.ReadLine());
                if (!new AlunoDAO(conn, trans).ValidaId(id))
                {
                    Console.WriteLine("Esse código não foi encontrado na base");
                }
                else
                {
                    Console.WriteLine("Informe o novo Nome");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Informe a nova idade do aluno");
                    int idade = Convert.ToInt32(Console.ReadLine());
                    AlunoModel aluno = new AlunoModel()
                    {
                        Id = id,
                        Nome = nome,
                        Idade = idade
                    };
                    new AlunoDAO(conn, trans).AlterarAluno(aluno);
                    trans.Commit();
                }
            }
            catch (Exception ex)
            {
                trans.Rollback();
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
        }
    }
}
