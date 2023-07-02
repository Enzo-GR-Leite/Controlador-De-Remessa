using ControladoraDeRemessa.Classes;
using ControladoraDeRemessa.Controlador_de_Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ControladoraDeRemessa.Regras
{
    public class Regras
    {

        public static Perfil PerfilEstaCadastrado (List<Perfil> perfils, string codigo)
        {
            Perfil perfil = perfils.Find(obj => obj.CodigoDeBarrras == codigo);
            if(perfil != null)
            {
                return perfil;
            }
            else
            {
                return null;
            }
        }

        public static bool PerfilJaContidoNaLista(List<Perfil> perfils, Perfil perfil) 
        {
            int index = perfils.FindIndex(obj => obj.CodigoDeBarrras.Equals(perfil.CodigoDeBarrras));
            if(index != -1 )
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static List<Perfil> AdicionarPacote(List<Perfil> perfils, Perfil perfil)
        {
            int index = perfils.FindIndex(obj => obj.CodigoDeBarrras.Equals(perfil.CodigoDeBarrras));
            if(index != -1 ) 
            {
                perfils[index].Pacotes++;
                return perfils;
            }
            else
            {
                return perfils;
            }
        }

        public static bool ClienteERepetido(List<string> nomesClientes, string nomeCliente)
        {
            if(nomesClientes.Contains(nomeCliente))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static bool RemessaERepetida(List<int> numerosRemessa, int numeroRemessa)
        {
            if (numerosRemessa.Contains(numeroRemessa))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool EstaNaListaDeEntrada(Perfil perfil,List<Perfil> perfilsEntrada)
        {
            int index = perfilsEntrada.FindIndex(obj => obj.CodigoDeBarrras.Equals(perfil.CodigoDeBarrras));
            if (index != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void RemoverRemessaFechada(Cliente cliente) 
        {
            List<int> numerosRemessa = Carregar.CarregarListaRemessa(cliente.Nome);

            numerosRemessa.Remove(cliente.Remessa.NumeroDaRemessa);

            Salvar.Salvar.SalvarListaRemessa(cliente, numerosRemessa);

        }

        public static List<Perfil> RemoverPacote(List<Perfil> perfils, Perfil perfil)
        {
            int index = perfils.FindIndex(obj => obj.CodigoDeBarrras.Equals(perfil.CodigoDeBarrras));
            if (index != -1)
            {
                perfils[index].Pacotes--;
                return perfils;
            }
            else
            {
                return perfils;
            }
        }

        public static bool TemMaisDeUmPacote(List<Perfil> perfils, Perfil perfil)
        {
            int index = perfils.FindIndex(obj => obj.CodigoDeBarrras.Equals(perfil.CodigoDeBarrras));
            if (index != -1)
            {
                if(perfils[index].Pacotes > 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
