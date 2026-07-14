namespace Tabela_BrasileiroCsharp
{
    public partial class frmLoguin : Form
    {
        public frmLoguin()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmTelaPricipal principal = new frmTelaPricipal();
            principal.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
