using ExercicioBancoDados.DAO;
using System;

namespace ExercicioBancoDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 1 - para cadasrtrar novo produto digite 2 para ver produtos cadastrados");
            switch (Console.ReadLine())
            {
                case "1":
                    Inserir();
                    break;
                case "2":
                    RetornaProdutos();
                    break;
                default:
                    Console.WriteLine("Você não sabe ler !!!");
                    break;
            }
        }
        static void RetornaProdutos()
        {
            var conn = Connections.RetornaConexao();
            conn.Open();
            var trans = conn.BeginTransaction();
            try
            {
                var listaProdutos = new ProdutoDAO(conn, trans).RetornaProdutos();
                foreach (var produto in listaProdutos)
                {
                    Console.WriteLine($"Descricao: {produto.Descricao} Preco:{produto.Preco}");
                }
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
            }
        }
        static void Inserir()
        {
            var conn = Connections.RetornaConexao();
            conn.Open();
            var trans = conn.BeginTransaction();
            try
            {
                Console.WriteLine("Informe a Descricao do produto");
                string descricao = Console.ReadLine();
                Console.WriteLine("Informe o preco do produto");
                double preco = Convert.ToDouble(Console.ReadLine());
                new ProdutoDAO(conn, trans).InserirProduto(descricao, preco);
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
            }
        }
    }
}
