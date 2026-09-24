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
            Console.Clear();
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
                    Console.Clear();
                    break;

                case 2:
                    Console.WriteLine("\nVocê escolheu Adicionar Despesa");
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Receitas:");
                    foreach (double valor in valoresReceita)
                    {
                        Console.WriteLine(valor);
                    }

                    Console.WriteLine("\nSaldo total de Receitas Atual: " + valoresReceita.Sum());

                    Console.WriteLine("Voltar ao menu? (S/N)");
                    string resposta = Console.ReadLine();
                    while (resposta.ToUpper() != "S")
                    {
                        Console.WriteLine("Opção inválida! Digite S para voltar.");
                        resposta = Console.ReadLine();
                    }
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