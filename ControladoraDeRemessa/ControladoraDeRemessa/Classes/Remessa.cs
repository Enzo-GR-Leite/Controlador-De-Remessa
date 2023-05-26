using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladoraDeRemessa.Classes
{
    public class Remessa
    {
        public int NumeroDaRemessa { get; set; }

        public List<Perfil> RemessaEntrada = new List<Perfil>();

        public List<Perfil> RemessaSaida = new List<Perfil>();

        public Remessa(int NumeroRemessa) 
        {
            NumeroDaRemessa = NumeroRemessa;
        }

        public void AdicionarPerfilEntrada(Perfil perfil)
        {
            RemessaEntrada.Add(perfil);
        }

        public void AdicionarPerfilSaida(Perfil perfil)
        {
            RemessaSaida.Add(perfil);
        }
    }
}
