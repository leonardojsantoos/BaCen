using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCentral02
{
    internal class ContaBancaria
    {
        public string Agente { get; set; }
        public string Numero { get; set; }
        public decimal Saldo { get; private set; }
    }
}