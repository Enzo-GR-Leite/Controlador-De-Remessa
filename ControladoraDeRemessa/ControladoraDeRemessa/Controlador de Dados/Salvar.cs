using ControladoraDeRemessa.Classes;
using ControladoraDeRemessa.Controlador_de_Dados;
using ControladoraDeRemessa.Regras;
using Newtonsoft.Json;

namespace ControladoraDeRemessa.Salvar
{
    public class Salvar
    {

        public static bool SalvarCliente(string nome)
        {
            List<string> nomes = Carregar.CarregarListaClientes();
            if (Regras.Regras.ClienteERepetido(nomes, nome))
            {
                return false;
            }
            else
            {
                nomes.Add(nome);

                string json = JsonConvert.SerializeObject(nomes, Formatting.Indented);

                ControleDePastas.PastaRemessaExiste();
                File.WriteAllText(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa\ListaDeCliente.json", json);
                ControleDePastas.PastasClientes(nomes);
                return true;
            }
        }

        public static void SalvarPerfil(Perfil perfil)
        {
            List<Perfil> perfils = Carregar.CarregarPerfilsCadastrados();
            perfils.Add(perfil);

            string json = JsonConvert.SerializeObject(perfils, Formatting.Indented);

            ControleDePastas.PastaRemessaExiste();
            File.WriteAllText(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa\ListaDePerfilsCadastrados.json", json);
        }

        public static bool SalvarRemessa(string nome, int numeroRemessa)
        {
            List<int> numerosRemessa = Carregar.CarregarListaRemessa(nome);
            if (Regras.Regras.RemessaERepetida(numerosRemessa, numeroRemessa))
            {
                return false;
            }
            else
            {
                numerosRemessa.Add(numeroRemessa);

                string json = JsonConvert.SerializeObject(numerosRemessa, Formatting.Indented);

                ControleDePastas.PastaClienteEspecificoExiste(nome);
                File.WriteAllText(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa\Clientes\" + nome + @"\ListaDeRemessas.json", json);
                return true;
            }
        }

        public static void SalvarRemessaEntrada(Cliente cliente)
        {
            string json = JsonConvert.SerializeObject(cliente.Remessa.RemessaEntrada, Formatting.Indented);

            ControleDePastas.PastaClienteEspecificoExiste(cliente.Nome);
            File.WriteAllText(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa\Clientes\" + cliente.Nome + @"\" + cliente.Remessa.NumeroDaRemessa + @".json", json);
        }

        public static void SalvarRemessaSaida(Cliente cliente)
        {
            string json = JsonConvert.SerializeObject(cliente, Formatting.Indented);

            ControleDePastas.PastaClienteEspecificoExiste(cliente.Nome);
            File.WriteAllText(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa\Clientes\" + cliente.Nome + @"\" + cliente.Remessa.NumeroDaRemessa + @".json", json);


        }

        public static void SalvarListaRemessa(Cliente cliente,List<int> numerosRemessa)
        {
            string json = JsonConvert.SerializeObject(numerosRemessa, Formatting.Indented);

            ControleDePastas.PastaClienteEspecificoExiste(cliente.Nome);
            File.WriteAllText(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa\Clientes\" + cliente.Nome + @"\ListaDeRemessas.json", json);
        }

    }
}
