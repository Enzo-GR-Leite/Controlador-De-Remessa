using ControladoraDeRemessa.Classes;
using ControladoraDeRemessa.Controlador_de_Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaDeRemessas
{
    public partial class SelecionarRemessa : Form
    {
        Cliente cliente;
        public SelecionarRemessa(Cliente cliente)
        {
            this.cliente = cliente;
            InitializeComponent();
            List<int> numerosDaRemessa = Carregar.CarregarListaRemessa(this.cliente.Nome);
            cb_ListaDeRemessa.DataSource = numerosDaRemessa;
        }

        public void btn_Selecionar_Click(object sender, EventArgs e)
        {
            this.cliente.AdicionarRemessa(int.Parse(cb_ListaDeRemessa.SelectedItem.ToString()));
            RemessaSelecionada remessaSelecionada = new RemessaSelecionada(cliente);
            remessaSelecionada.Show();
            this.Close();
        }
    }
}
