using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoCentral02;

namespace BCval
{
    internal class TransacaoPix : Transacao
    {
        public string ChavePix { get; set; }
        public override bool Validar()
        {
            Console.WriteLine("PIX");
            return base.Valor > 0 && base.Valor <= 10000;
        }
    }
}
