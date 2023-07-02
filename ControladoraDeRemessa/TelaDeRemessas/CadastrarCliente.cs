using System;
using System.Collections.Generic;
using System.ComponentModel;
using ControladoraDeRemessa.Salvar;

namespace TelaDeRemessas
{
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            string nome = txtbNome.Text;
            if (string.IsNullOrEmpty(nome)) 
            {
                MessageBox.Show("Tentativa de adicionar um cliente em branco, por favor digite o nome do cliente", "Adicionar um cliente em branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(Salvar.SalvarCliente(nome))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tentativa de adicionar um cliente repetido, por favor adicione um cliente que não exista", "Adicionar um cliente já existente", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
