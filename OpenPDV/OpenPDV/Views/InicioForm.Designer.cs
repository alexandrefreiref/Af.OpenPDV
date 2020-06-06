namespace OpenPDV.Views
{
    partial class InicioForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.StatusStrip statusStrip1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioForm));
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cadastrarNovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            statusStrip1.SuspendLayout();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblData});
            statusStrip1.Location = new System.Drawing.Point(0, 576);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            statusStrip1.Size = new System.Drawing.Size(1112, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblData
            // 
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 17);
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1112, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.sistemaToolStripMenuItem.Image = global::OpenPDV.Properties.Resources.server;
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Image = global::OpenPDV.Properties.Resources.database;
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::OpenPDV.Properties.Resources.sign_in_alt;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Image = global::OpenPDV.Properties.Resources.power_off;
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fecharToolStripMenuItem.Text = "Encerrar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoToolStripMenuItem,
            this.consultarToolStripMenuItem1});
            this.clientesToolStripMenuItem.Image = global::OpenPDV.Properties.Resources.users;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarItemToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.importarToolStripMenuItem});
            this.estoqueToolStripMenuItem.Image = global::OpenPDV.Properties.Resources.barcode;
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // cadastrarItemToolStripMenuItem
            // 
            this.cadastrarItemToolStripMenuItem.Image = global::OpenPDV.Properties.Resources.plus_square;
            this.cadastrarItemToolStripMenuItem.Name = "cadastrarItemToolStripMenuItem";
            this.cadastrarItemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarItemToolStripMenuItem.Text = "Cadastrar Item";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Image = global::OpenPDV.Properties.Resources.search;
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Image = global::OpenPDV.Properties.Resources.file_import;
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importarToolStripMenuItem.Text = "Importar";
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contasAReceberToolStripMenuItem,
            this.contasAPagarToolStripMenuItem});
            this.financeiroToolStripMenuItem.Image = global::OpenPDV.Properties.Resources.wallet;
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // contasAReceberToolStripMenuItem
            // 
            this.contasAReceberToolStripMenuItem.Image = global::OpenPDV.Properties.Resources.receipt;
            this.contasAReceberToolStripMenuItem.Name = "contasAReceberToolStripMenuItem";
            this.contasAReceberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contasAReceberToolStripMenuItem.Text = "Contas a Receber";
            // 
            // contasAPagarToolStripMenuItem
            // 
            this.contasAPagarToolStripMenuItem.Image = global::OpenPDV.Properties.Resources.cash_register;
            this.contasAPagarToolStripMenuItem.Name = "contasAPagarToolStripMenuItem";
            this.contasAPagarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contasAPagarToolStripMenuItem.Text = "Contas a Pagar";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentaçãoToolStripMenuItem,
            this.suporteToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Image = global::OpenPDV.Properties.Resources.life_ring;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // documentaçãoToolStripMenuItem
            // 
            this.documentaçãoToolStripMenuItem.Image = global::OpenPDV.Properties.Resources.book;
            this.documentaçãoToolStripMenuItem.Name = "documentaçãoToolStripMenuItem";
            this.documentaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.documentaçãoToolStripMenuItem.Text = "Manual";
            // 
            // suporteToolStripMenuItem
            // 
            this.suporteToolStripMenuItem.Image = global::OpenPDV.Properties.Resources.question_circle;
            this.suporteToolStripMenuItem.Name = "suporteToolStripMenuItem";
            this.suporteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.suporteToolStripMenuItem.Text = "Suporte";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Image = global::OpenPDV.Properties.Resources.info_circle;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cadastrarNovoToolStripMenuItem
            // 
            this.cadastrarNovoToolStripMenuItem.Image = global::OpenPDV.Properties.Resources.plus_square;
            this.cadastrarNovoToolStripMenuItem.Name = "cadastrarNovoToolStripMenuItem";
            this.cadastrarNovoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarNovoToolStripMenuItem.Text = "Cadastrar Novo";
            this.cadastrarNovoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Image = global::OpenPDV.Properties.Resources.search;
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            // 
            // InicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 598);
            this.Controls.Add(statusStrip1);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "InicioForm";
            this.Text = "Open PDV";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAReceberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblData;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
    }
}