using ObjetoBancoDados.Model;
using System;

namespace ObjetoBancoDados
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new UsuarioModel(0,"","").RetornaUsuarios();
            foreach (var usuario in lista)
            {
                Console.WriteLine($"Login : {usuario.Login} Senha: {usuario.Senha} Código : {usuario.Id}");
            }
            Console.ReadLine();
        }
    }
}
