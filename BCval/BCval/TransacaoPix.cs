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
        public decimal ValorPix { get; set; }
        public string ChavePix { get; set; }
        public override bool Validar()
        {
            return ValorPix > 0 && ValorPix <= 1000;
        }
    }
}
