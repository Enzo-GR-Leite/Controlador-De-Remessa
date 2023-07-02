using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladoraDeRemessa.Controlador_de_Dados
{
    public class ControleDePastas
    {

        public static void PastaRemessaExiste()
        {
            if(!Directory.Exists(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa"))
            {
                Directory.CreateDirectory(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa");
            }
        }

        public static void PastaClienteExiste()
        {
            PastaRemessaExiste();

            if (!Directory.Exists(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa\Clientes"))
            {
                Directory.CreateDirectory(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa\Clientes");
            }
        }

        public static void PastasClientes(List<string> nomes)
        {
            PastaClienteExiste();

            foreach(string nome in nomes) 
            {
                if(!Directory.Exists(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa\Clientes\" + nome))
                {
                    Directory.CreateDirectory(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa\Clientes\" + nome);
                }
            }
        }

        public static void PastaClienteEspecificoExiste(string nome)
        {
            PastaClienteExiste();

            if(!Directory.Exists(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa\Clientes\" + nome))
            {
                Directory.CreateDirectory(@"C:\Users\" + Environment.UserName + @"\Documents\Remessa\Clientes\" + nome);
            }
        }
    }
}
