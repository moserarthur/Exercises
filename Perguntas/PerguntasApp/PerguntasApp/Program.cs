using System;
using PerguntasApp.Model;

namespace PerguntasApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao jogo de perguntas de multipla escolha, para continuar aperte enter");
            PerguntasApp.Model.KeyEnter Papp = new Model.KeyEnter();
            Papp.PressionaEnter();
        }

    }
}


