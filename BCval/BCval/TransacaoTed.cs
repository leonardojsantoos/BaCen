using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoCentral;

namespace BancoCentral
{
    internal class TransacaoTed : Transacao
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public TransacaoTed() { Tipo = "TED"; }
        public override bool Validar()
        {
            return Valor > 5000;
        }
    }
}
