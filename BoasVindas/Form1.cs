namespace BoasVindas
{
    public partial class frmAula01 : Form
    {
        public frmAula01()
        {
            InitializeComponent();
        }

        private void btnBoasVindas_Click(object sender, EventArgs e)
        {
            string nomeUsuario; // Declara��o vari�vel do tipo string

            nomeUsuario = txtNome.Text;

            // Concatenar



            MessageBox.Show("Bem-vindo ao C#", "Ol�!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblMensagem.Text = "Bem-vindo ao C#" + nomeUsuario;
        }

    }
}