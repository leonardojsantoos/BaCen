using System;
using BancoCentral;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Banco meuBanco = new Banco
                {
                    Nome = "Banco do Brasil",
                    CodigoBacen = "001"
                };

                PessoaFisica cliente1 = new PessoaFisica
                {
                    Nome = "Leonardo",
                    CPF = "12345678900",
                    Email = "leo@email.com"
                };

                ContaBancaria contaOrigem = new ContaBancaria
                {
                    Agente = "001",
                    Numero = "888",
                    Saldo = 10000,
                    Titular = cliente1
                };

                PessoaFisica cliente2 = new PessoaFisica
                {
                    Nome = "Maria",
                    CPF = "99999999999"
                };

                ContaBancaria contaDestino = new ContaBancaria
                {
                    Agente = "002",
                    Numero = "999",
                    Saldo = 5000,
                    Titular = cliente2
                };

                TransacaoPix pix = new TransacaoPix
                {
                    Valor = 500,
                    ChavePix = "leonardojsantos@gmail.com",
                    Data = DateTime.Now,
                    ContaOrigem = contaOrigem,
                    ContaDestino = contaDestino
                };

                Console.WriteLine($"Pix válido? {pix.Validar()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            decimal valor = 1000000000000m;

            IConversorGrandeza conversorBi = new ConverterGrandezas.ConversorBilhoes();
            IConversorGrandeza conversorTri = new ConverterGrandezas.ConversorTrilhoes();

            ExibirValorConvertido(valor, conversorBi);
            ExibirValorConvertido(valor, conversorTri);
        }

        static void ExibirValorConvertido(decimal valor, IConversorGrandeza conversor)
        {
            decimal convertido = conversor.Converter(valor);
            Console.WriteLine($"Valor convertido: {convertido:N2} {conversor.ObterSimbolo()}");
        }
    }
}