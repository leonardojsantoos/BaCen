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
            get 
            {
                return _valor; 
            }
            set
            {
                if (value > 0)
                {
                    _valor = value;
                }
                else
                {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERRO: Insira um valor maior que 0");
                        Console.ResetColor();
                }
            }
        }
    }
}