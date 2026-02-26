namespace BancoCentral
{
    internal abstract class Transacao
    {
        private decimal _valor;

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
        public DateTime Data { get; set; }
        public string Tipo { get; protected set; }
        public ContaBancaria ContaOrigem { get; set; }
        public ContaBancaria ContaDestino { get; set; }

        public virtual bool Validar()
        {
            return _valor > 0;
        }
    }
}