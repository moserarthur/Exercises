using System;
using OrientacaoObjetos.Model;
namespace OrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno p = new Aluno();
            p.Nome = "Gustavo Rosauro";//set
            p.Idade = 28;
            p.Endereco = "Rua Lauro Muller";
            p.Email = "gustavo@terra.com.br";
            p.NumeroMatricula = "234890234283904";
            p.Escola = "Apex";
            Console.WriteLine($"Nome: {p.Nome} Idade: {p.Idade} Endereço: {p.Endereco} E-Mail: {p.Email} " +
                $"Escola: {p.Escola} Numero Matricula: {p.NumeroMatricula}");
            //Quando eu acesso os valores estou utilizando o get
            //string mome = p.Nome; get
            Console.ReadLine()
        }
    }
}
