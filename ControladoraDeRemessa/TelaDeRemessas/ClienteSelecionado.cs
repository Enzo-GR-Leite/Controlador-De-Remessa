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
    public partial class ClienteSelecionado : Form
    {
        Cliente cliente;
        public ClienteSelecionado(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            lbl_clienteSelecionado.Text = cliente.Nome;
        }

        public void btn_CriarRemessa_Click(object sender, EventArgs e)
        {
            CadastrarRemessa criarRemessa = new CadastrarRemessa(cliente.Nome);
            criarRemessa.Show();
        }

        public void btn_SelecionarRemessa_Click(Object sender, EventArgs e)
        {
            SelecionarRemessa selecionarRemessa = new SelecionarRemessa(cliente);
            selecionarRemessa.Show();
            this.Close();
        }
    }
}
