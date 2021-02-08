using System;
using System.Collections.Generic;
using System.Text;

namespace PerguntasApp.Model
{
    class KeyEnter
    {
        public void PressionaEnter()
        {
            
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(false);
                Console.WriteLine("You typed: "+char.ToUpper(keyInfo.KeyChar)+" try, again.");
            } while (keyInfo.Key != ConsoleKey.Enter);
        }
    }
}
