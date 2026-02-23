using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoCentral02;

namespace BCval
{
    internal class TransacaoTed : Transacao
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public override bool Validar()
        {
            return base.Valor > 5000;
        }
    }
}
