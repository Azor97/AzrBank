using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzrBank.Classes
{
    public abstract class Banco
    {
        public Banco() 
        {
            this.NomeDoBanco = "AzrBank";
            this.CodigoDoBanco = "035";
        }

        public string NomeDoBanco { get; private set; }
        public string CodigoDoBanco { get; private set; }
    }
}
