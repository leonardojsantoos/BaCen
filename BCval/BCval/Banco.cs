using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCentral02
{
    internal class Banco
    {
        public string _nome;
        private string _codigobacen;
        public string CodigoBacen
        {
            get { return _codigobacen; }
            set
            {
                if (value.Length == 3)
                {
                    _codigobacen = value;
                }
                else
                {
                    
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERRO: Codigobacen deve ter 3 Digitos");
                        Console.ResetColor();
                    
                }
            }
        }
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _nome = value.ToUpper();
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERRO: Insira um nome");
                    Console.ResetColor();
                }
            }
        }   
    }
}