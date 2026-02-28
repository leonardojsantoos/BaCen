using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCentral
{
    public interface IConversorGrandeza
    {
        decimal Converter(decimal valor);
        string ObterSimbolo();
    }
}
