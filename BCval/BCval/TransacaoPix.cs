using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoCentral;

namespace BancoCentral
{
    internal class TransacaoPix : Transacao
    {
        public string ChavePix { get; set; }
        public TransacaoPix() { Tipo = "PIX"; }
        public override bool Validar()
        {
            return Valor > 0 && Valor <= 1000;
        }
    }
}
