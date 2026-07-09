using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabela_BrasileiroCsharp
{
    public partial class frmTelaPricipal : Form
    {
        public frmTelaPricipal()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmTelaConsultar consultar = new frmTelaConsultar();
            consultar.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            frmTelaAtualizar atualizar = new frmTelaAtualizar();
            atualizar.ShowDialog();
        }
    }
}
