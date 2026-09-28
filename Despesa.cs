namespace FinanceControl
{
    public class Despesa
    {
        //Atributos da Despesa
        public string descrDespesa;
        public decimal valorDespesa;

        //Metodos
        public decimal CalculaTotalDespesa(List<Despesa> ListaDeDespesas)
        {
            decimal totalDespesasExibir = 0;

            foreach (Despesa despesa in ListaDeDespesas)
            {
                totalDespesasExibir += despesa.valorDespesa;
            }
            return totalDespesasExibir;

        }

        public void ExibirDespesas(List<Despesa> ListaDeDespesas)
        {
            foreach (Despesa despesa in ListaDeDespesas)
            {
                Console.WriteLine("Descrição: " + despesa.descrDespesa);
                Console.WriteLine("Valor: " + despesa.valorDespesa + "\n");
            }
        }

    }
}
