namespace FinanceControl;

public class Program
{
    public static void Main()
    {
        bool sair = false;
        //Lista de Receitas
        List<Receita> ListaDeReceitas = new List<Receita>();

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
                    Console.Clear();

                    // Objeto
                    Receita receitaNova = new Receita();
                    Console.WriteLine("\nDescrição da Receita: ");
                    receitaNova.descrReceita = Console.ReadLine();
                    
                    Console.WriteLine("\nValor da Receita: ");
                    receitaNova.valorReceita = Convert.ToDouble(Console.ReadLine());

                    ListaDeReceitas.Add(receitaNova);

                    Console.WriteLine("\nReceita Cadastrada!");
                    Console.WriteLine("Descrição: " + receitaNova.descrReceita);
                    Console.WriteLine("Valor: " + receitaNova.valorReceita);
                    break;

                case 2:
                    Console.WriteLine("\nVocê escolheu Adicionar Despesa");
                    break;

                case 3:

                    if (ListaDeReceitas.Count != 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Receitas:");

                        foreach (Receita receita in ListaDeReceitas)
                        {
                            Console.WriteLine("Descrição: " + receita.descrReceita);
                            Console.WriteLine("Valor: " + receita.valorReceita + "\n");
                        }

                        double totalReceitas = 0;

                        foreach (Receita receita in ListaDeReceitas)
                        {
                            totalReceitas = totalReceitas + receita.valorReceita;
                        }

                        Console.WriteLine("Saldo total de Receitas Atual: " + totalReceitas);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Você ainda não possui receitas para exibir!");
                    }

                    Console.WriteLine("\nVoltar ao menu? (S/N)");
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