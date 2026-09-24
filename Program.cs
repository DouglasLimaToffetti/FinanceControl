namespace FinanceControl;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("============================================");
        Console.WriteLine("FINANCE CONTROL");
        Console.WriteLine("============================================");

        Console.WriteLine("\n1 - Adicionar Receita");
        Console.WriteLine("2 - Adicionar Despesa");
        Console.WriteLine("3 - Ver Saldo");
        Console.WriteLine("4 - Sair");

        Console.WriteLine("\nEscolha uma opção: ");
        int opcao = Convert.ToInt32(Console.ReadLine());

        string descrReceita;
        double valorReceita;

        switch (opcao)
        {
            case 1:
                Console.WriteLine("Descrição da Receita: ");
                descrReceita = Console.ReadLine();

                Console.WriteLine("\nValor da Receita: ");
                valorReceita = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Receita Cadastrada!\n");
                Console.WriteLine("Descrição: " + descrReceita);
                Console.WriteLine("Valor: " + valorReceita);
                break;

            case 2:
                Console.WriteLine("Você escolheu Adicionar Despesa");
                break;

            case 3:
                Console.WriteLine("Você escolheu ver o Saldo");
                break;

            case 4:
                Console.WriteLine("Você escolheu sair");
                break;

            default: Console.WriteLine("Opção Inválida");
                break;
        }
    }
}