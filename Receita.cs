namespace FinanceControl
{
    public class Receita
    {
        //Atributos da Receita
        public string descrReceita;
        public decimal valorReceita;

        //Metodos
        public decimal CalculaTotalReceitas(List<Receita> ListaDeReceitas)
        {
            decimal totalReceitasExibir = 0;

            foreach (Receita receita in ListaDeReceitas)
            {
                totalReceitasExibir += receita.valorReceita;
            }
            return totalReceitasExibir;

        }

        public void ExibirReceitas(List<Receita> ListaDeReceitas)
        {
            foreach (Receita receita in ListaDeReceitas)
            {
                Console.WriteLine("Descrição: " + receita.descrReceita);
                Console.WriteLine("Valor: " + receita.valorReceita + "\n");
            }
        }
    }
}
