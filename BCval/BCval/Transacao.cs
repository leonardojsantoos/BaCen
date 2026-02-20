using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoCentral02;
using static System.Net.Mime.MediaTypeNames;

namespace BancoCentral02
{
    internal class Transacao
    {
        private decimal _valor;

        public DateTime Data { get; set; }
        public string Tipo { get; set; }
        public ContaBancaria ContaOrigem { get; set; }
        public ContaBancaria ContaDestino { get; set; }

        public Transacao()
        {
            ContaOrigem = new ContaBancaria();
            ContaDestino = new ContaBancaria();
        }

        public decimal Valor
        {
            get { return _valor; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("O valor da transação deve ser maior que zero.");
                else
                    _valor = value;
            }
        }
    }
}