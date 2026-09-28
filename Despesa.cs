namespace FinanceControl
{
    public class Despesa
    {
        public string Descricao;
        public decimal Valor;

        public Despesa(string descricao, decimal valor)
        {
            Descricao = descricao;
            Valor = valor;
        }
    }
}
