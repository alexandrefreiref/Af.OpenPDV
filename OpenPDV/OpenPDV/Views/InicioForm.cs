using OpenPDV.Services;
using OpenPDV.Views.Cliente;
using System;
using System.Windows.Forms;

namespace OpenPDV.Views
{
    public partial class InicioForm : Form
    {
        public InicioForm()
        {
            InitializeComponent();
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.IsMdiContainer = true;
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackupService.CriarBackup();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoClienteForm novo = new NovoClienteForm();
            novo.MdiParent = this;
            novo.Show();
        }
    }
}
