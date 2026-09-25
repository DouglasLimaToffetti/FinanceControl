namespace FinanceControl
{
    public class Despesa
    {
        public string descrDespesa;
        public decimal valorDespesa;

        public decimal CalculaTotalDespesa(List<Despesa> ListaDeDespesas)
        {
            decimal totalDespesasExibir = 0;

            foreach (Despesa despesa in ListaDeDespesas)
            {
                totalDespesasExibir = totalDespesasExibir + despesa.valorDespesa;
            }
            return totalDespesasExibir;

        }
    }
}
