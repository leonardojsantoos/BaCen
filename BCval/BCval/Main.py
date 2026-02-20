using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCval
{
    class Main
    {
        from datetime import datetime

# Classe Banco
class Banco:
    def __init__(self):
        self._nome = None
        self._codigo_bacen = None

    @property
    def Nome(self):
        return self._nome

    @Nome.setter
    def Nome(self, value):
        if value:
            self._nome = value.upper()
        else:
            raise ValueError("O nome do banco não pode ser vazio.")

    @property
    def CodigoBacen(self):
        return self._codigo_bacen

    @CodigoBacen.setter
    def CodigoBacen(self, value):
        if value and len(value) == 3:
            self._codigo_bacen = value
        else:
            raise ValueError("Código Bacen deve ter exatamente 3 dígitos.")

# Classe ContaBancaria
class ContaBancaria:
    def __init__(self):
        self.Agente = ''
        self.Numero = ''
        self.Saldo = 0.0  # sempre zero, sem operação de saque/deposito

# Classe Transacao
class Transacao:
    def __init__(self):
        self._valor = 0.0
        self.Data = None
        self.Tipo = ''
        self.ContaOrigem = ContaBancaria()
        self.ContaDestino = ContaBancaria()

    @property
    def Valor(self):
        return self._valor

    @Valor.setter
    def Valor(self, value):
        if value > 0:
            self._valor = value
        else:
            raise ValueError("O valor da transação deve ser maior que zero.")

# -------------------------
# Main equivalente
# -------------------------
def main():
    try:
        meu_banco = Banco()
        meu_banco.Nome = "Banco do Brasil"
        meu_banco.CodigoBacen = "01"  # igual ao C# original, mas vai dar erro de validação se for !=3

        minha_transacao = Transacao()
        minha_transacao.Valor = -1  # vai lançar ValueError, igual ao C# original
        minha_transacao.Data = datetime.now()
        minha_transacao.Tipo = "PIX"
        minha_transacao.ContaOrigem.Agente = "001"
        minha_transacao.ContaOrigem.Numero = "888"
        minha_transacao.ContaDestino.Agente = "002"
        minha_transacao.ContaDestino.Numero = "999"

        print("--- REGISTRO BACEN ---\n")
        print(f"Banco: {meu_banco.Nome}")
        print(f"Codigo: {meu_banco.CodigoBacen}")
        print("---")
        print(f"Tipo: {minha_transacao.Tipo}")
        print(f"Valor: R${minha_transacao.Valor}")
        print(f"Data: {minha_transacao.Data}")
        print("---")
        print(f"Conta Origem: {minha_transacao.ContaOrigem.Agente}")
        print(f"Conta Destino: {minha_transacao.ContaDestino.Agente}")

    except ValueError as ex:
        print(f"\033[91mErro de validação: {ex}\033[0m")
    except Exception as ex:
        print(f"\033[91mErro inesperado: {ex}\033[0m")

if __name__ == "__main__":
    main()
    }
}
