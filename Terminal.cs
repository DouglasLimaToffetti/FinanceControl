namespace FinanceControl;
public class Terminal
{
    //Listas
    List<Receita> ListaDeReceitas = new List<Receita>();
    List<Despesa> ListaDeDespesas = new List<Despesa>();

    public void Start()
    {
        bool sair = false;

        while (!sair)
        {
            MenuInicial();
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    AdicionarReceitaMenu();
                    break;

                case 2:
                    AdicionarDespesaMenu();
                    break;

                case 3:
                    VisualizarSaldo();
                    break;

                case 4:
                    Console.WriteLine("Fechando o programa...");
                    sair = true;
                    break;

                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }

        }
    }

    public void MenuInicial()
    {
        Console.WriteLine("============================================");
        Console.WriteLine("FINANCE CONTROL");
        Console.WriteLine("============================================");

        Console.WriteLine("\n1 - Adicionar Receita");
        Console.WriteLine("2 - Adicionar Despesa");
        Console.WriteLine("3 - Ver Saldo");
        Console.WriteLine("4 - Sair");

        Console.WriteLine("\nEscolha uma opção: ");
    }

    public void AdicionarReceitaMenu()
    {
        Console.Clear();

        // Objeto de Receita
        Receita receitaNova = new Receita();
        Console.WriteLine("\nDescrição da Receita: ");
        receitaNova.descrReceita = Console.ReadLine();

        Console.WriteLine("\nValor da Receita: ");
        receitaNova.valorReceita = Convert.ToDecimal(Console.ReadLine());

        ListaDeReceitas.Add(receitaNova);

        Console.WriteLine("\nReceita Cadastrada!");
        Console.WriteLine($"Descrição: {receitaNova.descrReceita}");
        Console.WriteLine($"Valor: {receitaNova.valorReceita}\n");
    }

    public void AdicionarDespesaMenu()
    {
        Console.Clear();

        //Objeto de Despesa
        Despesa despesaNova = new Despesa();
        Console.WriteLine("Descrição da Despesa: ");
        despesaNova.descrDespesa = Console.ReadLine();

        Console.WriteLine("\nValor da Despesa: ");
        despesaNova.valorDespesa = Convert.ToDecimal(Console.ReadLine());

        ListaDeDespesas.Add(despesaNova);

        Console.WriteLine("\nDespesa Cadastrada!");
        Console.WriteLine($"Descrição: {despesaNova.descrDespesa}");
        Console.WriteLine($"Valor: {despesaNova.valorDespesa}\n");
    }

    public void VisualizarSaldo()
    {
        Receita totalReceita = new Receita();
        Despesa totalDespesa = new Despesa();
        decimal totalReceitaExibir = 0;
        decimal totalDespesaExibir = 0;

        decimal saldoAtual = 0;

        Console.Clear();
        if (ListaDeReceitas.Count != 0)
        {
            Console.WriteLine("================================");
            Console.WriteLine("RESUMO FINANCEIRO");
            Console.WriteLine("================================");

            Console.WriteLine("RECEITAS:");

            totalReceita.ExibirReceitas(ListaDeReceitas);

            totalReceitaExibir = totalReceita.CalculaTotalReceitas(ListaDeReceitas);

            Console.WriteLine("Saldo total de Receitas Atual: " + totalReceitaExibir);
        }
        else
        {
            Console.WriteLine("Você ainda não possui receitas para exibir!");
        }

        if (ListaDeDespesas.Count != 0)
        {
            Console.WriteLine("\nDESPESAS:");

            totalDespesa.ExibirDespesas(ListaDeDespesas);

            totalDespesaExibir = totalDespesa.CalculaTotalDespesa(ListaDeDespesas);

            Console.WriteLine("Saldo total de Despesas Atual: " + totalDespesaExibir);
        }
        else

        {
            Console.WriteLine("\nVocê ainda não possui despesas para exibir!");
        }

        saldoAtual = totalReceitaExibir - totalDespesaExibir;

        Console.WriteLine("\n---------------------");
        Console.WriteLine("Saldo Atual: " + saldoAtual);
        Console.WriteLine("---------------------");


        Console.WriteLine("\nVoltar ao menu? (S/N)");
        string resposta = Console.ReadLine();
        while (resposta.ToUpper() != "S")
        {
            Console.WriteLine("Opção inválida! Digite S para voltar.");
            resposta = Console.ReadLine();
        }
    }
}
