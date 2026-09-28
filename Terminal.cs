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
        Console.WriteLine("\nDescrição da Receita: ");
        string descricaoReceita = Console.ReadLine();

        Console.WriteLine("\nValor da Receita: ");
        decimal valorReceita = Convert.ToDecimal(Console.ReadLine());

        Receita receitaNova = new Receita(descricaoReceita, valorReceita);
        ListaDeReceitas.Add(receitaNova);

        Console.WriteLine("\nReceita Cadastrada!");
        Console.WriteLine($"Descrição: {receitaNova.Descricao}");
        Console.WriteLine($"Valor: {receitaNova.Valor}\n");
    }

    public void AdicionarDespesaMenu()
    {
        Console.Clear();

        //Objeto de Despesa
        
        Console.WriteLine("Descrição da Despesa: ");
        string descricaoDespesa = Console.ReadLine();

        Console.WriteLine("\nValor da Despesa: ");
        decimal valorDespesa = Convert.ToDecimal(Console.ReadLine());

        Despesa despesaNova = new Despesa(descricaoDespesa, valorDespesa);
        ListaDeDespesas.Add(despesaNova);

        Console.WriteLine("\nDespesa Cadastrada!");
        Console.WriteLine($"Descrição: {despesaNova.Descricao}");
        Console.WriteLine($"Valor: {despesaNova.Valor}\n");
    }

    public void VisualizarSaldo()
    {

        decimal totalReceitaExibir = 0;
        decimal totalDespesaExibir = 0;

        Console.Clear();
        if (ListaDeReceitas.Count != 0)
        {
            Console.WriteLine("================================");
            Console.WriteLine("RESUMO FINANCEIRO");
            Console.WriteLine("================================");

            Console.WriteLine("RECEITAS:");

            ExibirReceitas(ListaDeReceitas);

            totalReceitaExibir = CalculaTotalReceitas(ListaDeReceitas);

            Console.WriteLine($"Saldo total de Receitas Atual: {totalReceitaExibir}");
        }
        else
        {
            Console.WriteLine("Você ainda não possui receitas para exibir!");
        }

        if (ListaDeDespesas.Count != 0)
        {
            Console.WriteLine("\nDESPESAS:");

            ExibirDespesas(ListaDeDespesas);

            totalDespesaExibir = CalculaTotalDespesa(ListaDeDespesas);

            Console.WriteLine($"Saldo total de Despesas Atual: {totalDespesaExibir}");
        }
        else
        {
            Console.WriteLine("\nVocê ainda não possui despesas para exibir!");
        }

        decimal saldoAtual = totalReceitaExibir - totalDespesaExibir;

        Console.WriteLine("\n---------------------");
        Console.WriteLine($"Saldo Atual: {saldoAtual}");
        Console.WriteLine("---------------------");


        Console.WriteLine("\nVoltar ao menu? (S/N)");
        string resposta = Console.ReadLine();
        while (resposta.ToUpper() != "S")
        {
            Console.WriteLine("Opção inválida! Digite S para voltar.");
            resposta = Console.ReadLine();
        }
    }

    public decimal CalculaTotalReceitas(List<Receita> ListaDeReceitas)
    {
        decimal totalReceitasExibir = 0;

        foreach (Receita receita in ListaDeReceitas)
        {
            totalReceitasExibir += receita.Valor;
        }
        return totalReceitasExibir;

    }

    public void ExibirReceitas(List<Receita> ListaDeReceitas)
    {
        foreach (Receita receita in ListaDeReceitas)
        {
            Console.WriteLine("Descrição: " + receita.Descricao);
            Console.WriteLine("Valor: " + receita.Valor + "\n");
        }
    }
    public decimal CalculaTotalDespesa(List<Despesa> ListaDeDespesas)
    {
        decimal totalDespesasExibir = 0;

        foreach (Despesa despesa in ListaDeDespesas)
        {
            totalDespesasExibir += despesa.Valor;
        }
        return totalDespesasExibir;

    }

    public void ExibirDespesas(List<Despesa> ListaDeDespesas)
    {
        foreach (Despesa despesa in ListaDeDespesas)
        {
            Console.WriteLine("Descrição: " + despesa.Descricao);
            Console.WriteLine("Valor: " + despesa.Valor + "\n");
        }
    }
}