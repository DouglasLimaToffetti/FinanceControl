namespace FinanceControl;

public class Program
{
    public static void Main()
    {
        bool sair = false;
        string descrReceita;
        double valorReceita;
        List<string> descricoesReceita = new List<string>();
        List<double> valoresReceita = new List<double>();

        while (!sair) { 
            Console.WriteLine("\n============================================");
            Console.WriteLine("FINANCE CONTROL");
            Console.WriteLine("============================================");

            Console.WriteLine("\n1 - Adicionar Receita");
            Console.WriteLine("2 - Adicionar Despesa");
            Console.WriteLine("3 - Ver Saldo");
            Console.WriteLine("4 - Sair");

            Console.WriteLine("\nEscolha uma opção: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("\nDescrição da Receita: ");
                    descrReceita = Console.ReadLine();
                    descricoesReceita.Add(descrReceita);

                    Console.WriteLine("\nValor da Receita: ");
                    valorReceita = Convert.ToDouble(Console.ReadLine());
                    valoresReceita.Add(valorReceita);

                    Console.WriteLine("Receita Cadastrada!\n");
                    Console.WriteLine("Descrição: " + descrReceita);
                    Console.WriteLine("Valor: " + valorReceita);
                    break;

                case 2:
                    Console.WriteLine("\nVocê escolheu Adicionar Despesa");
                    break;

                case 3:
                    foreach (double valor in valoresReceita)
                    {
                        Console.WriteLine(valor);
                    }

                    Console.WriteLine("\nSaldo Total Atual: " + valoresReceita.Sum());
                    break;

                case 4:
                    Console.WriteLine("Fechando o programa...");
                    sair = true;
                    break;

                default: Console.WriteLine("Opção Inválida!");
                    break;
            }
      }   
    }
}