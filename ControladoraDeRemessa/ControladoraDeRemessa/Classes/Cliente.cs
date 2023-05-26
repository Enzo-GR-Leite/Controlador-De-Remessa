using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladoraDeRemessa.Classes
{
    public class Cliente
    {
        public string Nome { get; set; }
        
        List<Remessa> remessa = new List<Remessa>();

        public Cliente(String nome)
        {
            Nome= nome;
        }

        public void AdicionarRemessa(Remessa novaRemessa)
        {
            remessa.Add(novaRemessa);
        }
    }
}
