using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioExceptions.Excpetions
{
    public class ValorMuitoAltoException:Exception
    {
        public ValorMuitoAltoException()
            : base("Ops, Muito Alto")
        { }
    }
}
