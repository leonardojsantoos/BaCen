using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCentral
{
    internal class ConversorTrilhoes : IConversorGrandeza
    {
        public decimal Converter(decimal valor) => valor / 1000000000000m;
        public string ObterSimbolo() => "Tri";
    }
}
