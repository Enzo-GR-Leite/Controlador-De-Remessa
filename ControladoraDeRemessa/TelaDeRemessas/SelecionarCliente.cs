using ControladoraDeRemessa.Classes;
using ControladoraDeRemessa.Controlador_de_Dados;
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
    public partial class SelecionarCliente : Form
    {
        public SelecionarCliente()
        {
            InitializeComponent();
            List<string> lista = Carregar.CarregarListaClientes();
            cb_ListaClientes.DataSource = lista;
        }

        public void btn_Selecionar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(cb_ListaClientes.SelectedItem.ToString());
            ClienteSelecionado clienteSelecionadoForm = new ClienteSelecionado(cliente);
            clienteSelecionadoForm.Show();
            this.Close();
        }
    }
}
