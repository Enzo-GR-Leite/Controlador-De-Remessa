namespace TelaDeRemessas
{
    public partial class TelaInicio : Form
    {
        public TelaInicio()
        {
            InitializeComponent();
        }

        private void btnCadastrarCliente(object sender, EventArgs e)
        {
            CadastrarCliente cadastrarCliente = new CadastrarCliente();
            cadastrarCliente.Show();
        }

        private void btnCadastrarPerfil(object sender, EventArgs e)
        {
            AdicionarPerfil adicionarPerfil = new AdicionarPerfil();
            adicionarPerfil.Show();
        }

        private void btnSelecionarCliente(Object sender, EventArgs e)
        {
            SelecionarCliente selecionarCliente = new SelecionarCliente();
            selecionarCliente.Show();
        }
    }
}