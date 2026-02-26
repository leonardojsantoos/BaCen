using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCentral
{
    internal class ContaBancaria
    {
        public string Agente { get; set; }
        public string Numero { get; set; }
        public decimal Saldo { get; set; }
        public Cliente Titular { get; set; }
    }
}