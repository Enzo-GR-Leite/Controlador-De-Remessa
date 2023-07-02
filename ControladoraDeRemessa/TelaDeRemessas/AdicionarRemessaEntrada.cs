using ControladoraDeRemessa.Classes;
using ControladoraDeRemessa.Controlador_de_Dados;
using ControladoraDeRemessa.Regras;
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
    public partial class AdicionarRemessaEntrada : Form
    {
        Cliente cliente;
        List<Perfil> perfilsCadastrados = Carregar.CarregarPerfilsCadastrados();
        private DataTable _perfil = new DataTable();



        public AdicionarRemessaEntrada(Cliente cliente)
        {
            _perfil.Columns.Add("codigo");
            _perfil.Columns.Add("pacotes", typeof(int));
            _perfil.Columns.Add("nome");
            _perfil.Columns.Add("modelo");
            _perfil.Columns.Add("codigoDeBarras");
            _perfil.Columns.Add("barras", typeof(int));
            this.cliente = cliente;
            InitializeComponent();
        }

        public void btn_adicionarEntrada_Click(object sender, EventArgs e)
        {
            string codigo = txt_codigoEntrada.Text;

            Perfil perfilNovo = Regras.PerfilEstaCadastrado(perfilsCadastrados, codigo);
            if (perfilNovo == null)
            {
                MessageBox.Show("Perfil não encontrado na base de dados, adicione o perfil na base e tente novamente ou confira o código de barras se está correto", "Perfil não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool estaNaLista = Regras.PerfilJaContidoNaLista(cliente.Remessa.RemessaEntrada, perfilNovo);
                if (estaNaLista)
                {
                    cliente.Remessa.RemessaEntrada = Regras.AdicionarPacote(cliente.Remessa.RemessaEntrada, perfilNovo);
                    dtg_Entrada.DataSource = cliente.Remessa.RemessaEntrada;
                }
                else
                {
                    if(perfilNovo.Pacotes == 1)
                    {
                        cliente.Remessa.RemessaEntrada.Add(perfilNovo);
                        _perfil.Rows.Add(perfilNovo.Codigo, perfilNovo.Pacotes, perfilNovo.Nome, perfilNovo.Modelo, perfilNovo.CodigoDeBarrras, perfilNovo.Barras);
                        dtg_Entrada.DataSource = _perfil;
                        //Cara, isso aqui conserta o bug do codigoDeBarras ficar em branco, porque isso acontece, eu não sei, enzo do futuro, boa sorte conserta isso
                        dtg_Entrada.DataSource = cliente.Remessa.RemessaEntrada;
                    }
                    else
                    {
                        cliente.Remessa.RemessaEntrada.Add(perfilNovo);
                        Regras.AdicionarPacote(cliente.Remessa.RemessaEntrada, perfilNovo);
                        _perfil.Rows.Add(perfilNovo.Codigo, perfilNovo.Pacotes, perfilNovo.Nome, perfilNovo.Modelo, perfilNovo.CodigoDeBarrras, perfilNovo.Barras);
                        dtg_Entrada.DataSource = _perfil;
                        //Cara, isso aqui conserta o bug do codigoDeBarras ficar em branco, porque isso acontece, eu não sei, enzo do futuro, boa sorte conserta isso
                        dtg_Entrada.DataSource = cliente.Remessa.RemessaEntrada;
                    }
                }
            }
            dtg_Entrada.Refresh();
            txt_codigoEntrada.Text = "";
            txt_codigoEntrada.Focus();
        }

        public void btn_salvarEntrada_Click(object sender, EventArgs e)
        {
            Salvar.SalvarRemessaEntrada(cliente);
            MessageBox.Show("Remessa de Entrada adicionado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        public void btn_removerPerfil_Click(object sender, EventArgs e)
        {
            string codigo = txt_codigoEntrada.Text;

            Perfil perfilNovo = Regras.PerfilEstaCadastrado(perfilsCadastrados, codigo);
            if (perfilNovo == null)
            {
                MessageBox.Show("Perfil não encontrado na base de dados, adicione o perfil na base e tente novamente ou confira o código de barras se está correto", "Perfil não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool estaNaLista = Regras.TemMaisDeUmPacote(cliente.Remessa.RemessaEntrada, perfilNovo);
                if (estaNaLista)
                {
                    cliente.Remessa.RemessaEntrada = Regras.RemoverPacote(cliente.Remessa.RemessaEntrada, perfilNovo);
                    dtg_Entrada.DataSource = cliente.Remessa.RemessaEntrada;
                }
                else
                {
                    cliente.Remessa.RemessaEntrada.Remove(perfilNovo);

                    //olha, eu sei que isso é super anti-performatico e quebra umas 50 leis da computação e boas praticas da programção,mas eu não consegui selecionar a linha que eu queria remover, se alguém tiver uma sugestão ou melhoria pode avisar
                    DataTable _perfilRemovido = new DataTable();

                    _perfilRemovido.Columns.Add("codigo");
                    _perfilRemovido.Columns.Add("pacotes", typeof(int));
                    _perfilRemovido.Columns.Add("nome");
                    _perfilRemovido.Columns.Add("modelo");
                    _perfilRemovido.Columns.Add("codigoDeBarras");
                    _perfilRemovido.Columns.Add("barras", typeof(int));

                    foreach (Perfil perfil in cliente.Remessa.RemessaEntrada)
                    {
                        _perfilRemovido.Rows.Add(perfil.Codigo, perfil.Pacotes, perfil.Nome, perfil.Modelo, perfil.CodigoDeBarrras, perfil.Barras);
                    }

                    dtg_Entrada.DataSource = _perfilRemovido;
                    //Cara, isso aqui conserta o bug do codigoDeBarras ficar em branco, porque isso acontece, eu não sei, enzo do futuro, boa sorte para conserta isso
                    dtg_Entrada.DataSource = cliente.Remessa.RemessaEntrada;
                }
            }
            dtg_Entrada.Refresh();
            txt_codigoEntrada.Text = "";
            txt_codigoEntrada.Focus();
        }

    }
}