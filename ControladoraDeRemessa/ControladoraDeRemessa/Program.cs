using ControladoraDeRemessa.Classes;

List<Cliente> listaClientes = new List<Cliente>();
Cliente clienteAtual = null;
List<Perfil> perfils = new List<Perfil>();
while (true)
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 . Cadastrar Cliente");
    Console.WriteLine("2 . Selecionar Cliente");
    Console.WriteLine("3 . Ver Cliente Atual");
    Console.WriteLine("4 . Ver lista de Clientes");
    Console.WriteLine("5 . Cadastrar Perfil");
    Console.WriteLine("6 . Sair");
    Console.WriteLine("7 . teste da lista");
    int opcao = Int32.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Digite o nome do cliente");
            string nome = Console.ReadLine();
            listaClientes.Add(new Cliente(nome));
            break;
        case 2:
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Escolha o cliente");
                foreach (Cliente cliente in listaClientes)
                {
                    Console.WriteLine($"{cliente.Nome}");
                }
                string escolha = Console.ReadLine();

                foreach (Cliente cliente in listaClientes)
                {
                    if (escolha == cliente.Nome)
                    {
                        clienteAtual = cliente;
                        break;
                    }
                }
                if (clienteAtual == null)
                {
                    Console.WriteLine("Cliente não encontrado");
                }
                else
                {
                    break;
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
            foreach (Cliente cliente in listaClientes)
            {
                Console.WriteLine($"{cliente.Nome}");
            }
            Console.ReadLine();
            break;

        case 7:
            teste();
            break;


        default:
            Console.WriteLine("Saindo....");
            break;
    }

    Console.Clear();
}


void teste()
{
    Remessa remessa = new Remessa(123);

    remessa.AdicionarPerfilEntrada(new Perfil { Nome = "CHAPEU 8", Codigo = "AL49", CodigoDeBarrras = "CHAPEU 8 AL49 8", Barras = "8", Modelo = "CHAPEU 8 PESADO" });
    remessa.AdicionarPerfilEntrada(new Perfil { Nome = "CHAPEU 10", Codigo = "AL51", CodigoDeBarrras = "CHAPEU 10 AL51 8", Barras = "8", Modelo = "CHAPEU 10" });

    remessa.AdicionarPerfilSaida(new Perfil { Nome = "CHAPEU 8", Codigo = "AL49", CodigoDeBarrras = "CHAPEU 8 AL49 8", Barras = "8", Modelo = "CHAPEU 8 PESADO" });

    bool teste = remessa.RemessaEntrada.SequenceEqual(remessa.RemessaSaida);

    Console.WriteLine($"{teste}");
    Console.ReadLine();
}