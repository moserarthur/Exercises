using System;

namespace ManipulandoTextos
{

    class Program
    {
        static void Main(string[] args)
        {
            //utilizando replace
            string textoAntigo = "esse texto é um texto antigo";
            string textoNovo = textoAntigo.Replace("antigo","novo");
            Console.WriteLine(textoNovo);
            Console.Read();
            /////////////////////Utilizando substring///////////////////////////
            string texto = "abcdefghij";//o nosso array de characteres sempre começa por 0
            string textoSub = texto.Substring(0,2);
            //TextoSub irá pegar a primeira posição do nosso array que é 'a'
            //E irá pegar dois characteres contando a posição então fica 'ab'
            Console.WriteLine($"Utilizando substring: {textoSub}".ToUpper());
            Console.Read();
        }
    }
}
