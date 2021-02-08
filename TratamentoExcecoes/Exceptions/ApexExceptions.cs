using System;
using System.Collections.Generic;
using System.Text;

namespace TratamentoExcecoes.Exceptions
{
    public class ApexExceptions:Exception
    {
        public ApexExceptions() { }
        public ApexExceptions(string message)
            : base("Falar com juliano Apex Error: "+message)
        { }
    }
}
