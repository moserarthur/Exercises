using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioExceptions.Excpetions
{
    public class ValorMuitoBaixoException:Exception
    {
        public ValorMuitoBaixoException()
            :base("Ops, Assim não é divertidade")
        { }
    }
}
