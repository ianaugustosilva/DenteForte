namespace projetoDenteForte.Formulários
{
    partial class mdiMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.agendaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.convenioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sairMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaMenu,
            this.convenioMenu,
            this.funcionarioMenu,
            this.fornecedorMenu,
            this.pacienteMenu,
            this.produtoMenu,
            this.usuarioMenu,
            this.sobreMenu,
            this.sairMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // agendaMenu
            // 
            this.agendaMenu.Name = "agendaMenu";
            this.agendaMenu.Size = new System.Drawing.Size(60, 20);
            this.agendaMenu.Text = "Agenda";
            this.agendaMenu.Click += new System.EventHandler(this.agendaToolStripMenuItem_Click);
            // 
            // convenioMenu
            // 
            this.convenioMenu.Name = "convenioMenu";
            this.convenioMenu.Size = new System.Drawing.Size(70, 20);
            this.convenioMenu.Text = "&Convênio";
            this.convenioMenu.Click += new System.EventHandler(this.convenioMenu_Click);
            // 
            // funcionarioMenu
            // 
            this.funcionarioMenu.Name = "funcionarioMenu";
            this.funcionarioMenu.Size = new System.Drawing.Size(82, 20);
            this.funcionarioMenu.Text = "&Funcionário";
            this.funcionarioMenu.Click += new System.EventHandler(this.funcionarioMenu_Click);
            // 
            // fornecedorMenu
            // 
            this.fornecedorMenu.Name = "fornecedorMenu";
            this.fornecedorMenu.Size = new System.Drawing.Size(79, 20);
            this.fornecedorMenu.Text = "For&necedor";
            this.fornecedorMenu.Click += new System.EventHandler(this.fornecedorMenu_Click);
            // 
            // pacienteMenu
            // 
            this.pacienteMenu.Name = "pacienteMenu";
            this.pacienteMenu.Size = new System.Drawing.Size(64, 20);
            this.pacienteMenu.Text = "&Paciente";
            this.pacienteMenu.Click += new System.EventHandler(this.pacienteMenu_Click);
            // 
            // produtoMenu
            // 
            this.produtoMenu.Name = "produtoMenu";
            this.produtoMenu.Size = new System.Drawing.Size(62, 20);
            this.produtoMenu.Text = "Pro&duto";
            this.produtoMenu.Click += new System.EventHandler(this.produtoMenu_Click);
            // 
            // usuarioMenu
            // 
            this.usuarioMenu.Name = "usuarioMenu";
            this.usuarioMenu.Size = new System.Drawing.Size(59, 20);
            this.usuarioMenu.Text = "&Usuário";
            this.usuarioMenu.Click += new System.EventHandler(this.usuarioMenu_Click);
            // 
            // sobreMenu
            // 
            this.sobreMenu.Name = "sobreMenu";
            this.sobreMenu.Size = new System.Drawing.Size(49, 20);
            this.sobreMenu.Text = "So&bre";
            this.sobreMenu.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairMenu
            // 
            this.sairMenu.Name = "sairMenu";
            this.sairMenu.Size = new System.Drawing.Size(38, 20);
            this.sairMenu.Text = "&Sair";
            this.sairMenu.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(784, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "Ajuda";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::projetoDenteForte.Properties.Resources.ProjetoDenteForte;
            this.pbLogo.Location = new System.Drawing.Point(62, 151);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(674, 304);
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // mdiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "mdiMain";
            this.Text = "Projeto DenteForte";
            this.Load += new System.EventHandler(this.mdiMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ToolStripMenuItem agendaMenu;
        private System.Windows.Forms.ToolStripMenuItem sobreMenu;
        private System.Windows.Forms.ToolStripMenuItem sairMenu;
        private System.Windows.Forms.ToolStripMenuItem convenioMenu;
        private System.Windows.Forms.ToolStripMenuItem fornecedorMenu;
        private System.Windows.Forms.ToolStripMenuItem pacienteMenu;
        private System.Windows.Forms.ToolStripMenuItem produtoMenu;
        private System.Windows.Forms.ToolStripMenuItem usuarioMenu;
        private System.Windows.Forms.ToolStripMenuItem funcionarioMenu;
    }
}



