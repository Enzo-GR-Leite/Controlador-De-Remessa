using ControladoraDeRemessa.Classes;
using Newtonsoft.Json;

List<string> listaClientes = new List<string>();
Cliente clienteAtual = null;
List<Perfil> perfils = new List<Perfil>();
carregar();
while (true)
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 . Cadastrar Cliente");
    Console.WriteLine("2 . Selecionar Cliente");
    Console.WriteLine("3 . Ver Cliente Atual");
    Console.WriteLine("4 . Ver lista de Clientes");
    Console.WriteLine("5 . Cadastrar Perfil");
    Console.WriteLine("6 . Ver lista de Perfils Cadastrados");
    Console.WriteLine("7 . teste da lista");
    Console.WriteLine("8 . Criar pasta");
    Console.WriteLine("9 . salvar lista de clientes");
    int opcao = Int32.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Digite o nome do cliente");
            string nome = Console.ReadLine();
            listaClientes.Add(nome);
            break;
        case 2:
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Escolha o cliente");
                foreach (string cliente in listaClientes)
                {
                    Console.WriteLine($"{cliente}");
                }
                string escolha = Console.ReadLine();

                if (listaClientes.Contains(escolha))
                {
                    clienteAtual = new Cliente(escolha);
                    Cliente();
                    break;
                }
                else
                {
                    Console.WriteLine("Cliente não encontrado");
                    Console.ReadLine();
                }
            }
            break;

        case 3:
            Console.Clear();
            Console.WriteLine($"{clienteAtual.Nome}");
            Console.ReadLine();
            break;

        case 4:
            Console.Clear();
            foreach (string cliente in listaClientes)
            {
                Console.WriteLine($"{cliente}");
            }
            Console.ReadLine();
            break;

        case 5:
            AdiciionarPerfil();
            break;

        case 6:
            Console.Clear();
            foreach (Perfil perfil in perfils)
            {
                Console.WriteLine(perfil);
                Console.WriteLine("-------------------------");
            }
            Console.ReadLine();
            break;

        case 7:
            teste();
            break;

        case 8:
            if (!Directory.Exists(@"C:\Users\Citendo\Documents\Remessa"))
            {
                Directory.CreateDirectory(@"C:\Users\Citendo\Documents\Remessa");
                Console.WriteLine("Criei a pasta");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Já existe");
                Console.ReadLine();
            }
            break;
        case 9:
            salvar();
            break;


        default:
            Console.WriteLine("Saindo....");
            break;
    }

    Console.Clear();
}

void Cliente()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine($"Cliente Selecionado: {clienteAtual.Nome}");
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 . Criar uma remessa");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Digite o Numero da Remessa");
                clienteAtual.Remessa.NumeroDaRemessa = int.Parse(Console.ReadLine());
                break;
            default:
                Console.Clear();
                Console.WriteLine("Opção Invalida");
                Console.ReadLine();
                break;
        }

        if (opcao > 3)
        {
            break;
        }
    }
}

void AlterarRemessa(Remessa remessa)
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine($"Remessa: {remessa.NumeroDaRemessa} do cliente {clienteAtual.Nome}");
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 . Adicionar remessa de entrada");
        Console.WriteLine("2 . Adicionar remessa de saída");
        Console.WriteLine("3 . finalizar remessa");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                while (true)
                {
                    Console.WriteLine("Digite o código de barras do perfil");
                    string codigo1 = Console.ReadLine();
                    Perfil perfil1 = perfils.Find(perfil => perfil.Codigo == codigo1);
                    if (perfil1 != null)
                    {
                        remessa.AdicionarPerfilEntrada(perfil1);
                    }
                    else
                    {
                        Console.WriteLine("Perfil não cadastrado, Por favor cadastrar perfil antes de adiciona-lo na remessa");
                    }

                    Console.WriteLine("Deseja adicionar mais 1 perfil?");
                    string escolha1 = Console.ReadLine();
                    if (escolha1 == "nao" || escolha1 == "n" || escolha1 == "N")
                    {
                        break;
                    }
                }
                break;
            case 2:
                while (true)
                {
                    Console.WriteLine("Digite o código de barras do perfil");
                    string codigo = Console.ReadLine();
                    Perfil perfil = perfils.Find(perfil => perfil.Codigo == codigo);
                    if (perfil != null)
                    {
                        remessa.AdicionarPerfilSaida(perfil);
                    }
                    else
                    {
                        Console.WriteLine("Perfil não cadastrado, Por favor cadastrar perfil antes de adiciona-lo na remessa");
                    }

                    Console.WriteLine("Deseja adicionar mais 1 perfil?");
                    string escolha = Console.ReadLine();
                    if (escolha == "nao" || escolha == "n" || escolha == "N")
                    {
                        break;
                    }
                }
                break;
            case 3:
                remessa.RemessaEntrada.Sort((obj1, obj2) => obj1.Codigo.CompareTo(obj2.Codigo));
                remessa.RemessaSaida.Sort((obj1, obj2) => obj1.Codigo.CompareTo(obj2.Codigo));
                bool finalizar = remessa.RemessaEntrada.SequenceEqual(remessa.RemessaSaida);
                if (finalizar == false)
                {
                    Console.WriteLine("As remessas de entrada e saida não são iguais, não é possível fechar a remessa");
                }
                else
                {
                    Console.WriteLine("As remessas de entrada e saída são iguais, fechando remessa");
                }
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }
}

void teste()
{
    Remessa remessa = new Remessa(123);

    remessa.AdicionarPerfilEntrada(new Perfil { Nome = "CHAPEU 8", Codigo = "AL49", CodigoDeBarrras = "CHAPEU 8 AL49 8", Barras = 8, Modelo = "CHAPEU 8 PESADO" });
    remessa.AdicionarPerfilEntrada(new Perfil { Nome = "CHAPEU 10", Codigo = "AL51", CodigoDeBarrras = "CHAPEU 10 AL51 8", Barras = 8, Modelo = "CHAPEU 10" });

    remessa.AdicionarPerfilSaida(new Perfil { Nome = "CHAPEU 8", Codigo = "AL49", CodigoDeBarrras = "CHAPEU 8 AL49 8", Barras = 8, Modelo = "CHAPEU 8 PESADO" });

    bool teste = remessa.RemessaEntrada.SequenceEqual(remessa.RemessaSaida);

    Console.WriteLine($"{teste}");
    Console.ReadLine();
}

void AdiciionarPerfil()
{
    while (true)
    {
        Perfil perfil = new Perfil();
        Console.Clear();
        Console.WriteLine("Digite o nome do perfil");
        perfil.Nome = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Digite o modelo do perfil");
        perfil.Modelo = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Digite o código do perfil");
        perfil.Codigo = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Digite o código de barras do perfil");
        perfil.CodigoDeBarrras = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Digite a quantidade de barras por pacote");
        perfil.Barras = int.Parse(Console.ReadLine());
        perfils.Add(perfil);
        Console.Clear();
        Console.WriteLine("Deseja adicionar mais 1 perfil?");
        string escolha = Console.ReadLine();
        if (escolha == "nao" || escolha == "n" || escolha == "N")
        {
            break;
        }
    }
}

void carregar()
{
    if (File.Exists(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa\ListaDeCliente.json"))
    {
        string jsonContent = File.ReadAllText(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa\ListaDeCliente.json");
        listaClientes = JsonConvert.DeserializeObject<List<string>>(jsonContent);
    }

    if (File.Exists(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa\ListaDePerfilsCadastrados.json"))
    {
        string jsonContent = File.ReadAllText(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa\ListaDePerfilsCadastrados.json");
        perfils = JsonConvert.DeserializeObject<List<Perfil>>(jsonContent);
    }

}

void salvar()
{
    string json = JsonConvert.SerializeObject(listaClientes, Newtonsoft.Json.Formatting.Indented);

    File.WriteAllText(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa\ListaDeCliente.json", json);

    Console.WriteLine("Salndo lista de clientes");

    json = JsonConvert.SerializeObject(perfils, Newtonsoft.Json.Formatting.Indented);

    File.WriteAllText(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa\ListaDePerfilsCadastrados.json", json);
}