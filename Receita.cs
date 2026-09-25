namespace FinanceControl
{
    public class Receita
    {
        public string descrReceita;
        public decimal valorReceita;

        public decimal CalculaTotalReceitas(List<Receita> ListaDeReceitas)
        {
            decimal totalReceitasExibir = 0;

            foreach (Receita receita in ListaDeReceitas)
            {
                totalReceitasExibir = totalReceitasExibir + receita.valorReceita;
            }
            return totalReceitasExibir;

        }
    }
}
