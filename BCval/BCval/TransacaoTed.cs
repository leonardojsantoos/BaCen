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
        public decimal ValorTed { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public override bool Validar()
        {
            return ValorTed > 5000;
        }
    }
}
