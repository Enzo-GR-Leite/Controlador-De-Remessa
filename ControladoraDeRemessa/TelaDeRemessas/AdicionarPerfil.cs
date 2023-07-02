using ControladoraDeRemessa.Classes;
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
    public partial class AdicionarPerfil : Form
    {
        public AdicionarPerfil()
        {
            InitializeComponent();
        }

        //evento que impede de digitar letras dentro do text box do número de barras
        public void txtb_Barras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(txtb_Codigo.Text == "" || txtb_CodigoDeBarras.Text == "")
            {
                MessageBox.Show("Faltam informações para salvar o perfil, por favor revise as informações e tente novamente","Campos vazios",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;  
            }

            Perfil perfil = new Perfil();
            perfil.Nome = txtb_Nome.Text;
            perfil.Codigo = txtb_Codigo.Text;
            perfil.Modelo = txtb_Modelo.Text;
            perfil.CodigoDeBarrras = txtb_CodigoDeBarras.Text;
            perfil.Barras = int.Parse(txtb_Barras.Text);

            Salvar.SalvarPerfil(perfil);

            AdicionarPerfilModal adicionarPerfilModal = new AdicionarPerfilModal();
            DialogResult resultado = adicionarPerfilModal.ShowDialog();

            if(resultado == DialogResult.Yes)
            {
                txtb_Nome.Text = "";
                txtb_Codigo.Text = "";
                txtb_Modelo.Text = "";
                txtb_CodigoDeBarras.Text = "";
                txtb_Barras.Text = "";
            }
            else if (resultado == DialogResult.No) 
            {
                this.Close();
            }
        }
    }
}
