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
    public partial class AdicionarRemessaSaida : Form
    {
        Cliente cliente;
        List<Perfil> perfilsCadastrados = Carregar.CarregarPerfilsCadastrados();
        private DataTable _perfilEntrada = new DataTable();
        private DataTable _perfilSaida = new DataTable();

        public AdicionarRemessaSaida(Cliente cliente)
        {
            this.cliente = cliente;
            cliente.Remessa.RemessaEntrada = Carregar.CarregarRemessaEntrada(cliente.Nome, cliente.Remessa.NumeroDaRemessa);
            _perfilEntrada.Columns.Add("codigo");
            _perfilEntrada.Columns.Add("pacotes", typeof(int));
            _perfilEntrada.Columns.Add("nome");
            _perfilEntrada.Columns.Add("modelo");
            _perfilEntrada.Columns.Add("CodigoDeBarras");
            _perfilEntrada.Columns.Add("barras", typeof(int));

            _perfilSaida.Columns.Add("codigo");
            _perfilSaida.Columns.Add("pacotes", typeof(int));
            _perfilSaida.Columns.Add("nome");
            _perfilSaida.Columns.Add("modelo");
            _perfilSaida.Columns.Add("CodigoDeBarras");
            _perfilSaida.Columns.Add("barras", typeof(int));

            cliente.Remessa.RemessaEntrada.Sort((obj1, obj2) => obj1.Codigo.CompareTo(obj2.Codigo));

            foreach (Perfil perfil in cliente.Remessa.RemessaEntrada)
            {
                _perfilEntrada.Rows.Add(perfil.Codigo, perfil.Pacotes, perfil.Nome, perfil.Modelo, "teste", perfil.Barras);
            }

            InitializeComponent();
            dtg_remessaEntrada.DataSource = _perfilEntrada;
            dtg_remessaEntrada.DataSource = cliente.Remessa.RemessaEntrada;

            dtg_remessaEntrada.Refresh();
        }

        public void btn_adicionar_Click(object sender, EventArgs e)
        {
            string codigo = txtb_codigo.Text;

            Perfil perfilNovo = Regras.PerfilEstaCadastrado(perfilsCadastrados, codigo);
            if (perfilNovo == null)
            {
                MessageBox.Show("Perfil não encontrado na base de dados, adicione o perfil na base de dados e tente novamente ou confira o código de barras se está correto", "Perfil não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (Regras.EstaNaListaDeEntrada(perfilNovo, cliente.Remessa.RemessaEntrada))
                {
                    if (Regras.PerfilJaContidoNaLista(cliente.Remessa.RemessaSaida, perfilNovo))
                    {
                        cliente.Remessa.RemessaSaida = Regras.AdicionarPacote(cliente.Remessa.RemessaSaida, perfilNovo);
                        dtg_RemessaSaida.DataSource = cliente.Remessa.RemessaSaida;
                    }
                    else
                    {
                        if(perfilNovo.Pacotes == 1)
                        {
                            cliente.Remessa.RemessaSaida.Add(perfilNovo);
                            cliente.Remessa.RemessaSaida.Sort((obj1, obj2) => obj1.Codigo.CompareTo(obj2.Codigo));
                            _perfilSaida.Rows.Add(perfilNovo.Codigo, perfilNovo.Pacotes, perfilNovo.Nome, perfilNovo.Modelo, perfilNovo.CodigoDeBarrras, perfilNovo.Barras);
                            dtg_RemessaSaida.DataSource = _perfilSaida;
                            dtg_RemessaSaida.DataSource = cliente.Remessa.RemessaSaida;
                        }
                        else
                        {
                            cliente.Remessa.RemessaSaida.Add(perfilNovo);
                            Regras.AdicionarPacote(cliente.Remessa.RemessaSaida, perfilNovo);
                            cliente.Remessa.RemessaSaida.Sort((obj1, obj2) => obj1.Codigo.CompareTo(obj2.Codigo));
                            _perfilSaida.Rows.Add(perfilNovo.Codigo, perfilNovo.Pacotes, perfilNovo.Nome, perfilNovo.Modelo, perfilNovo.CodigoDeBarrras, perfilNovo.Barras);
                            dtg_RemessaSaida.DataSource = _perfilSaida;
                            dtg_RemessaSaida.DataSource = cliente.Remessa.RemessaSaida;
                        }
                    }  
                }
                else
                {
                    MessageBox.Show("Perfil não está contigo na remessa de entrada, não deixar carregar", "Perfil não pertence a remessa de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            dtg_RemessaSaida.Refresh();

            bool finalizar = cliente.Remessa.RemessaEntrada.SequenceEqual(cliente.Remessa.RemessaSaida);
            if (finalizar)
            {
                btn_fecharRemessa.Enabled = true;
            }
            else
            {
                btn_fecharRemessa.Enabled=false;
            }

            txtb_codigo.Text = "";
            txtb_codigo.Focus();

        }

        public void btn_fecharRemessa_Click(object sender, EventArgs e)
        {
            Salvar.SalvarRemessaSaida(cliente);
            Regras.RemoverRemessaFechada(cliente);
            Pdf.CriarPdf(cliente);
            MessageBox.Show("Remessa fechada com sucesso!!!!", "Remessa fechada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }

        public void btn_remover_Click(object sender, EventArgs e)
        {
            string codigo = txtb_codigo.Text;

            Perfil perfilNovo = Regras.PerfilEstaCadastrado(perfilsCadastrados, codigo);
            if (perfilNovo == null)
            {
                MessageBox.Show("Perfil não encontrado na base de dados, adicione o perfil na base e tente novamente ou confira o código de barras se está correto", "Perfil não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool estaNaLista = Regras.TemMaisDeUmPacote(cliente.Remessa.RemessaSaida, perfilNovo);
                if (estaNaLista)
                {
                    cliente.Remessa.RemessaSaida = Regras.RemoverPacote(cliente.Remessa.RemessaSaida, perfilNovo);
                    dtg_RemessaSaida.DataSource = cliente.Remessa.RemessaSaida;
                }
                else
                {
                    cliente.Remessa.RemessaSaida.Remove(perfilNovo);

                    //olha, eu sei que isso é super anti-performatico e quebra umas 50 leis da computação e boas praticas da programção,mas eu não consegui selecionar a linha que eu queria remover, se alguém tiver uma sugestão ou melhoria pode avisar
                    DataTable _perfilRemovido = new DataTable();

                    _perfilRemovido.Columns.Add("codigo");
                    _perfilRemovido.Columns.Add("pacotes", typeof(int));
                    _perfilRemovido.Columns.Add("nome");
                    _perfilRemovido.Columns.Add("modelo");
                    _perfilRemovido.Columns.Add("codigoDeBarras");
                    _perfilRemovido.Columns.Add("barras", typeof(int));

                    foreach (Perfil perfil in cliente.Remessa.RemessaSaida)
                    {
                        _perfilRemovido.Rows.Add(perfil.Codigo, perfil.Pacotes, perfil.Nome, perfil.Modelo, perfil.CodigoDeBarrras, perfil.Barras);
                    }

                    dtg_RemessaSaida.DataSource = _perfilRemovido;
                    //Cara, isso aqui conserta o bug do codigoDeBarras ficar em branco, porque isso acontece, eu não sei, enzo do futuro, boa sorte para conserta isso
                    dtg_RemessaSaida.DataSource = cliente.Remessa.RemessaSaida;
                }
            }
            dtg_RemessaSaida.Refresh();
            txtb_codigo.Text = "";
            txtb_codigo.Focus();
        }
    }
}
