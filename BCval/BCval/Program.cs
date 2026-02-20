using System;
using BancoCentral02;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Banco meuBanco = new Banco();
                meuBanco.Nome = "Banco do Brasil";
                meuBanco.CodigoBacen = "001";

                Transacao minhaTransacao = new Transacao
                {
                    Valor = 150.75m,
                    Data = DateTime.Now,
                    Tipo = "PIX",
                    ContaOrigem = new ContaBancaria
                    {
                        Agente = "001",
                        Numero = "888"
                    },
                    ContaDestino = new ContaBancaria
                    {
                        Agente = "002",
                        Numero = "999"
                    }
                };

                Console.WriteLine("--- REGISTRO BACEN ---\n" +
                $"Banco: {meuBanco.Nome}\n" +
                $"Código Bacen: {meuBanco.CodigoBacen}\n" +
                $"---\n" +
                $"Tipo: {minhaTransacao.Tipo}\n" +
                $"Valor: R${minhaTransacao.Valor}\n" +
                $"Data: {minhaTransacao.Data}\n" +
                $"---\n" +
                $"Conta Origem: {minhaTransacao.ContaOrigem.Agente} / {minhaTransacao.ContaOrigem.Numero}\n" +
                $"Saldo Origem: R${minhaTransacao.ContaOrigem.Saldo}\n" +
                $"Conta Destino: {minhaTransacao.ContaDestino.Agente} / {minhaTransacao.ContaDestino.Numero}\n" +
                $"Saldo Destino: R${minhaTransacao.ContaDestino.Saldo}");
            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Erro de validação: {ex.Message}");
                Console.ResetColor();
            }
            catch (InvalidOperationException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Erro de operação: {ex.Message}");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Erro inesperado: {ex.Message}");
                Console.ResetColor();
            }
        }
    }
}