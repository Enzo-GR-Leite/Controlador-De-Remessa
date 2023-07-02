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
        
        public Remessa Remessa { get; set; }

        public Cliente(String nome)
        {
            Nome= nome;
        }

        public void AdicionarRemessa(int remessa)
        {
            Remessa = new Remessa(remessa);
        }

    }
}
