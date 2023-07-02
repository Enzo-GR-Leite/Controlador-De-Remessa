using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladoraDeRemessa.Classes
{
    public class Perfil: IEquatable<Perfil>
    {
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public string Codigo { get; set; }
        public string CodigoDeBarrras { get; set; }
        public int Barras { get; set; }
        public int Pacotes { get; set; }

        public bool Equals(Perfil? other)
        {
            if (other == null)
                return false;

            return this.Nome == other.Nome && this.Modelo == other.Modelo && this.Codigo == other.Codigo && this.CodigoDeBarrras == other.CodigoDeBarrras && this.Pacotes == other.Pacotes;
        }

        public override string ToString()
        {
            return $"Nome do Perfil: {Nome} " +
                   $"Modelo do Perfil: {Modelo} " +
                   $"Código do Perfil: {Codigo} " +
                   $"Código de Barras do Perfil: {CodigoDeBarrras} " +
                   $"Quantidade de Barras por pacote: {Barras} ";
        }
    }
}
