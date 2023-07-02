using ControladoraDeRemessa.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaDeRemessas
{
    public partial class RemessaSelecionada : Form
    {
        Cliente cliente;
        public RemessaSelecionada(Cliente cliente)
        {
            this.cliente = cliente;
            InitializeComponent();
            lb_NomeCliente.Text = this.cliente.Nome;
            lb_NumeroRemessa.Text = $"{this.cliente.Remessa.NumeroDaRemessa}";
        }

        public void btn_CriarRemessaEntrada_Click(object sender, EventArgs e)
        {
            AdicionarRemessaEntrada adicionarRemessaEntrada = new AdicionarRemessaEntrada(this.cliente);
            adicionarRemessaEntrada.Show();
            this.Close();
        }

        public void btn_CriarRemessaSaida_Click(object sender, EventArgs e)
        {
            AdicionarRemessaSaida adicionarRemessaSaida = new AdicionarRemessaSaida(this.cliente);
            adicionarRemessaSaida.Show();
            this.Close();
        }
    }
}
