using ControladoraDeRemessa.Salvar;
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
    public partial class CadastrarRemessa : Form
    {
        string nomeCliente;
        public CadastrarRemessa(string nomeCliente)
        {
            InitializeComponent();
            this.nomeCliente = nomeCliente;
        }

        public void txtb_Remessa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void btn_Salvar_click(object sender, EventArgs e)
        {
            string numeroRemessaString = txtb_Remessa.Text;
            if(numeroRemessaString.Count() == 0) 
            {
                MessageBox.Show("Tentativa de salvar um remessa sem número, por favor digite um numero de remessa valido","Remessa invalida",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                int numeroRemessa = int.Parse(txtb_Remessa.Text);
                if (Salvar.SalvarRemessa(this.nomeCliente, numeroRemessa))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tentativa de adicionar uma remessa que já existe, por favor adicione uma remessa que não existe", "Adicionar uma remessa já existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
