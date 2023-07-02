using ControladoraDeRemessa.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladoraDeRemessa.Controlador_de_Dados
{
    public class Carregar
    {
        public static List<string> CarregarListaClientes()
        {
            ControleDePastas.PastaRemessaExiste();
            if (File.Exists(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa\ListaDeCliente.json"))
            {
                string nomesString = File.ReadAllText(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa\ListaDeCliente.json");
                List<string> nomes = JsonConvert.DeserializeObject<List<string>>(nomesString);
                return nomes;
            }
            else
            {
                return new List<string>();
            }
        }

        public static List<Perfil> CarregarPerfilsCadastrados()
        {
            ControleDePastas.PastaRemessaExiste();
            if(File.Exists(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa\ListaDePerfilsCadastrados.json"))
            {
                string perfilsString = File.ReadAllText(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa\ListaDePerfilsCadastrados.json");
                List<Perfil> perfils = JsonConvert.DeserializeObject<List<Perfil>>(perfilsString);
                return perfils;
            }
            else 
            {
                return new List<Perfil>();
            }
        }

        public static List<int> CarregarListaRemessa(string nomeCliente)
        {
            ControleDePastas.PastaRemessaExiste();
            ControleDePastas.PastaClienteEspecificoExiste(nomeCliente);

            if (File.Exists(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa\Clientes\" + nomeCliente + @"\ListaDeRemessas.json"))
            {
                string numeroDasRemessasString = File.ReadAllText(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa\Clientes\" + nomeCliente + @"\ListaDeRemessas.json");
                List<int> numerosDaRemessa = JsonConvert.DeserializeObject<List<int>>(numeroDasRemessasString);
                return numerosDaRemessa;
            }
            else
            {
                return new List<int>();
            }
        }

        public static List<Perfil> CarregarRemessaEntrada(string nomeCliente, int numeroRemessa)
        {
            ControleDePastas.PastaRemessaExiste();
            ControleDePastas.PastaClienteEspecificoExiste(nomeCliente);

            if (File.Exists(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa\Clientes\" + nomeCliente + @"\" + numeroRemessa + @".json"))
            {
                string perfilsString = File.ReadAllText(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa\Clientes\" + nomeCliente + @"\" + numeroRemessa + @".json");
                List<Perfil> perfils = JsonConvert.DeserializeObject<List<Perfil>>(perfilsString);
                return perfils;
            }
            else
            {
                return new List<Perfil>();
            }
        }
    }
}