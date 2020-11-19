namespace projetoDenteForte.Formulários
{
    partial class frmProduto
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
            this.spltProduto = new System.Windows.Forms.SplitContainer();
            this.descricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataMovimentacao = new System.Windows.Forms.DateTimePicker();
            this.cbTipoMovimentacao = new System.Windows.Forms.ComboBox();
            this.cbProdutoFornecedor = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dtpValidade = new System.Windows.Forms.DateTimePicker();
            this.btRemover = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lbClassificacao = new System.Windows.Forms.Label();
            this.lblValidade = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtQntd = new System.Windows.Forms.TextBox();
            this.txtClassificacao = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtTipoProduto = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dtgProdutos = new System.Windows.Forms.DataGridView();
            this.gpProdutos = new System.Windows.Forms.GroupBox();
            this.txtbPesquisaProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spltProduto)).BeginInit();
            this.spltProduto.Panel1.SuspendLayout();
            this.spltProduto.Panel2.SuspendLayout();
            this.spltProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).BeginInit();
            this.gpProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // spltProduto
            // 
            this.spltProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltProduto.Location = new System.Drawing.Point(0, 0);
            this.spltProduto.Name = "spltProduto";
            this.spltProduto.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltProduto.Panel1
            // 
            this.spltProduto.Panel1.Controls.Add(this.gpProdutos);
            this.spltProduto.Panel1.Controls.Add(this.descricao);
            this.spltProduto.Panel1.Controls.Add(this.txtDescricao);
            this.spltProduto.Panel1.Controls.Add(this.label1);
            this.spltProduto.Panel1.Controls.Add(this.dtpDataMovimentacao);
            this.spltProduto.Panel1.Controls.Add(this.cbTipoMovimentacao);
            this.spltProduto.Panel1.Controls.Add(this.cbProdutoFornecedor);
            this.spltProduto.Panel1.Controls.Add(this.btnLimpar);
            this.spltProduto.Panel1.Controls.Add(this.dtpValidade);
            this.spltProduto.Panel1.Controls.Add(this.btRemover);
            this.spltProduto.Panel1.Controls.Add(this.lblEstado);
            this.spltProduto.Panel1.Controls.Add(this.lblQuantidade);
            this.spltProduto.Panel1.Controls.Add(this.lbClassificacao);
            this.spltProduto.Panel1.Controls.Add(this.lblValidade);
            this.spltProduto.Panel1.Controls.Add(this.lblFornecedor);
            this.spltProduto.Panel1.Controls.Add(this.txtQntd);
            this.spltProduto.Panel1.Controls.Add(this.txtClassificacao);
            this.spltProduto.Panel1.Controls.Add(this.lblTipo);
            this.spltProduto.Panel1.Controls.Add(this.lblNome);
            this.spltProduto.Panel1.Controls.Add(this.txtTipoProduto);
            this.spltProduto.Panel1.Controls.Add(this.txtNomeProduto);
            this.spltProduto.Panel1.Controls.Add(this.btnAtualizar);
            this.spltProduto.Panel1.Controls.Add(this.btnCadastrar);
            // 
            // spltProduto.Panel2
            // 
            this.spltProduto.Panel2.Controls.Add(this.dtgProdutos);
            this.spltProduto.Size = new System.Drawing.Size(967, 674);
            this.spltProduto.SplitterDistance = 238;
            this.spltProduto.TabIndex = 53;
            // 
            // descricao
            // 
            this.descricao.AutoSize = true;
            this.descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricao.Location = new System.Drawing.Point(309, 15);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(55, 13);
            this.descricao.TabIndex = 37;
            this.descricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(312, 28);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(148, 20);
            this.txtDescricao.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Data Movimentação";
            // 
            // dtpDataMovimentacao
            // 
            this.dtpDataMovimentacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataMovimentacao.Location = new System.Drawing.Point(551, 68);
            this.dtpDataMovimentacao.Name = "dtpDataMovimentacao";
            this.dtpDataMovimentacao.Size = new System.Drawing.Size(100, 20);
            this.dtpDataMovimentacao.TabIndex = 9;
            // 
            // cbTipoMovimentacao
            // 
            this.cbTipoMovimentacao.FormattingEnabled = true;
            this.cbTipoMovimentacao.Location = new System.Drawing.Point(551, 28);
            this.cbTipoMovimentacao.Name = "cbTipoMovimentacao";
            this.cbTipoMovimentacao.Size = new System.Drawing.Size(159, 21);
            this.cbTipoMovimentacao.TabIndex = 8;
            // 
            // cbProdutoFornecedor
            // 
            this.cbProdutoFornecedor.FormattingEnabled = true;
            this.cbProdutoFornecedor.Location = new System.Drawing.Point(28, 108);
            this.cbProdutoFornecedor.Name = "cbProdutoFornecedor";
            this.cbProdutoFornecedor.Size = new System.Drawing.Size(165, 21);
            this.cbProdutoFornecedor.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(813, 130);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(145, 30);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dtpValidade
            // 
            this.dtpValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValidade.Location = new System.Drawing.Point(312, 65);
            this.dtpValidade.Name = "dtpValidade";
            this.dtpValidade.Size = new System.Drawing.Size(98, 20);
            this.dtpValidade.TabIndex = 6;
            // 
            // btRemover
            // 
            this.btRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemover.Location = new System.Drawing.Point(813, 94);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(145, 30);
            this.btRemover.TabIndex = 12;
            this.btRemover.Text = "&Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(548, 15);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(101, 13);
            this.lblEstado.TabIndex = 17;
            this.lblEstado.Text = "Tipo Movimentação";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(309, 88);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(192, 13);
            this.lblQuantidade.TabIndex = 16;
            this.lblQuantidade.Text = "Quantidade (Somente números inteiros)";
            // 
            // lbClassificacao
            // 
            this.lbClassificacao.AutoSize = true;
            this.lbClassificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassificacao.Location = new System.Drawing.Point(25, 132);
            this.lbClassificacao.Name = "lbClassificacao";
            this.lbClassificacao.Size = new System.Drawing.Size(69, 13);
            this.lbClassificacao.TabIndex = 15;
            this.lbClassificacao.Text = "Classificação";
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidade.Location = new System.Drawing.Point(309, 52);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(48, 13);
            this.lblValidade.TabIndex = 14;
            this.lblValidade.Text = "Validade";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(25, 91);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 13;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // txtQntd
            // 
            this.txtQntd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQntd.Location = new System.Drawing.Point(312, 102);
            this.txtQntd.MaxLength = 50;
            this.txtQntd.Name = "txtQntd";
            this.txtQntd.Size = new System.Drawing.Size(80, 20);
            this.txtQntd.TabIndex = 7;
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassificacao.Location = new System.Drawing.Point(28, 148);
            this.txtClassificacao.MaxLength = 500;
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.Size = new System.Drawing.Size(221, 20);
            this.txtClassificacao.TabIndex = 4;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(25, 51);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(25, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome";
            // 
            // txtTipoProduto
            // 
            this.txtTipoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoProduto.Location = new System.Drawing.Point(28, 65);
            this.txtTipoProduto.MaxLength = 50;
            this.txtTipoProduto.Name = "txtTipoProduto";
            this.txtTipoProduto.Size = new System.Drawing.Size(165, 20);
            this.txtTipoProduto.TabIndex = 2;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(28, 28);
            this.txtNomeProduto.MaxLength = 500;
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(221, 20);
            this.txtNomeProduto.TabIndex = 1;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(813, 58);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(145, 30);
            this.btnAtualizar.TabIndex = 11;
            this.btnAtualizar.Text = "&Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(813, 22);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(145, 30);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dtgProdutos
            // 
            this.dtgProdutos.AllowUserToAddRows = false;
            this.dtgProdutos.AllowUserToDeleteRows = false;
            this.dtgProdutos.AllowUserToResizeColumns = false;
            this.dtgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgProdutos.Location = new System.Drawing.Point(0, 0);
            this.dtgProdutos.Name = "dtgProdutos";
            this.dtgProdutos.ReadOnly = true;
            this.dtgProdutos.RowHeadersVisible = false;
            this.dtgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProdutos.Size = new System.Drawing.Size(967, 432);
            this.dtgProdutos.StandardTab = true;
            this.dtgProdutos.TabIndex = 2;
            this.dtgProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProdutos_CellContentClick);
            // 
            // gpProdutos
            // 
            this.gpProdutos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gpProdutos.Controls.Add(this.label2);
            this.gpProdutos.Controls.Add(this.txtbPesquisaProduto);
            this.gpProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpProdutos.Location = new System.Drawing.Point(3, 174);
            this.gpProdutos.Name = "gpProdutos";
            this.gpProdutos.Size = new System.Drawing.Size(955, 62);
            this.gpProdutos.TabIndex = 38;
            this.gpProdutos.TabStop = false;
            this.gpProdutos.Text = "Pesquisa";
            // 
            // txtbPesquisaProduto
            // 
            this.txtbPesquisaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPesquisaProduto.Location = new System.Drawing.Point(25, 37);
            this.txtbPesquisaProduto.MaxLength = 500;
            this.txtbPesquisaProduto.Name = "txtbPesquisaProduto";
            this.txtbPesquisaProduto.Size = new System.Drawing.Size(221, 20);
            this.txtbPesquisaProduto.TabIndex = 2;
            this.txtbPesquisaProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbPesquisaProduto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 674);
            this.Controls.Add(this.spltProduto);
            this.MaximizeBox = false;
            this.Name = "frmProduto";
            this.Text = "Manipulação de Produtos";
            this.spltProduto.Panel1.ResumeLayout(false);
            this.spltProduto.Panel1.PerformLayout();
            this.spltProduto.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltProduto)).EndInit();
            this.spltProduto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).EndInit();
            this.gpProdutos.ResumeLayout(false);
            this.gpProdutos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spltProduto;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DateTimePicker dtpValidade;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lbClassificacao;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtQntd;
        private System.Windows.Forms.TextBox txtClassificacao;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dtgProdutos;
        private System.Windows.Forms.ComboBox cbProdutoFornecedor;
        private System.Windows.Forms.TextBox txtTipoProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataMovimentacao;
        private System.Windows.Forms.ComboBox cbTipoMovimentacao;
        private System.Windows.Forms.Label descricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.GroupBox gpProdutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbPesquisaProduto;
    }
}

   /* partial class CopyOffrmProduto
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
            this.spltProduto = new System.Windows.Forms.SplitContainer();
            this.descricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataMovimentacao = new System.Windows.Forms.DateTimePicker();
            this.cbTipoMovimentacao = new System.Windows.Forms.ComboBox();
            this.cbProdutoFornecedor = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dtpValidade = new System.Windows.Forms.DateTimePicker();
            this.btRemover = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lbClassificacao = new System.Windows.Forms.Label();
            this.lblValidade = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtQntd = new System.Windows.Forms.TextBox();
            this.txtClassificacao = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtTipoProduto = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dtgProdutos = new System.Windows.Forms.DataGridView();
            this.gpProdutos = new System.Windows.Forms.GroupBox();
            this.txtbPesquisaProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spltProduto)).BeginInit();
            this.spltProduto.Panel1.SuspendLayout();
            this.spltProduto.Panel2.SuspendLayout();
            this.spltProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).BeginInit();
            this.gpProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // spltProduto
            // 
            this.spltProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltProduto.Location = new System.Drawing.Point(0, 0);
            this.spltProduto.Name = "spltProduto";
            this.spltProduto.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltProduto.Panel1
            // 
            this.spltProduto.Panel1.Controls.Add(this.gpProdutos);
            this.spltProduto.Panel1.Controls.Add(this.descricao);
            this.spltProduto.Panel1.Controls.Add(this.txtDescricao);
            this.spltProduto.Panel1.Controls.Add(this.label1);
            this.spltProduto.Panel1.Controls.Add(this.dtpDataMovimentacao);
            this.spltProduto.Panel1.Controls.Add(this.cbTipoMovimentacao);
            this.spltProduto.Panel1.Controls.Add(this.cbProdutoFornecedor);
            this.spltProduto.Panel1.Controls.Add(this.btnLimpar);
            this.spltProduto.Panel1.Controls.Add(this.dtpValidade);
            this.spltProduto.Panel1.Controls.Add(this.btRemover);
            this.spltProduto.Panel1.Controls.Add(this.lblEstado);
            this.spltProduto.Panel1.Controls.Add(this.lblQuantidade);
            this.spltProduto.Panel1.Controls.Add(this.lbClassificacao);
            this.spltProduto.Panel1.Controls.Add(this.lblValidade);
            this.spltProduto.Panel1.Controls.Add(this.lblFornecedor);
            this.spltProduto.Panel1.Controls.Add(this.txtQntd);
            this.spltProduto.Panel1.Controls.Add(this.txtClassificacao);
            this.spltProduto.Panel1.Controls.Add(this.lblTipo);
            this.spltProduto.Panel1.Controls.Add(this.lblNome);
            this.spltProduto.Panel1.Controls.Add(this.txtTipoProduto);
            this.spltProduto.Panel1.Controls.Add(this.txtNomeProduto);
            this.spltProduto.Panel1.Controls.Add(this.btnAtualizar);
            this.spltProduto.Panel1.Controls.Add(this.btnCadastrar);
            // 
            // spltProduto.Panel2
            // 
            this.spltProduto.Panel2.Controls.Add(this.dtgProdutos);
            this.spltProduto.Size = new System.Drawing.Size(967, 674);
            this.spltProduto.SplitterDistance = 238;
            this.spltProduto.TabIndex = 53;
            // 
            // descricao
            // 
            this.descricao.AutoSize = true;
            this.descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricao.Location = new System.Drawing.Point(309, 15);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(55, 13);
            this.descricao.TabIndex = 37;
            this.descricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(312, 28);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(148, 20);
            this.txtDescricao.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Data Movimentação";
            // 
            // dtpDataMovimentacao
            // 
            this.dtpDataMovimentacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataMovimentacao.Location = new System.Drawing.Point(551, 68);
            this.dtpDataMovimentacao.Name = "dtpDataMovimentacao";
            this.dtpDataMovimentacao.Size = new System.Drawing.Size(100, 20);
            this.dtpDataMovimentacao.TabIndex = 9;
            // 
            // cbTipoMovimentacao
            // 
            this.cbTipoMovimentacao.FormattingEnabled = true;
            this.cbTipoMovimentacao.Location = new System.Drawing.Point(551, 28);
            this.cbTipoMovimentacao.Name = "cbTipoMovimentacao";
            this.cbTipoMovimentacao.Size = new System.Drawing.Size(159, 21);
            this.cbTipoMovimentacao.TabIndex = 8;
            // 
            // cbProdutoFornecedor
            // 
            this.cbProdutoFornecedor.FormattingEnabled = true;
            this.cbProdutoFornecedor.Location = new System.Drawing.Point(28, 108);
            this.cbProdutoFornecedor.Name = "cbProdutoFornecedor";
            this.cbProdutoFornecedor.Size = new System.Drawing.Size(165, 21);
            this.cbProdutoFornecedor.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(813, 130);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(145, 30);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dtpValidade
            // 
            this.dtpValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValidade.Location = new System.Drawing.Point(312, 65);
            this.dtpValidade.Name = "dtpValidade";
            this.dtpValidade.Size = new System.Drawing.Size(98, 20);
            this.dtpValidade.TabIndex = 6;
            // 
            // btRemover
            // 
            this.btRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemover.Location = new System.Drawing.Point(813, 94);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(145, 30);
            this.btRemover.TabIndex = 12;
            this.btRemover.Text = "&Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(548, 15);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(101, 13);
            this.lblEstado.TabIndex = 17;
            this.lblEstado.Text = "Tipo Movimentação";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(309, 88);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(192, 13);
            this.lblQuantidade.TabIndex = 16;
            this.lblQuantidade.Text = "Quantidade (Somente números inteiros)";
            // 
            // lbClassificacao
            // 
            this.lbClassificacao.AutoSize = true;
            this.lbClassificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassificacao.Location = new System.Drawing.Point(25, 132);
            this.lbClassificacao.Name = "lbClassificacao";
            this.lbClassificacao.Size = new System.Drawing.Size(69, 13);
            this.lbClassificacao.TabIndex = 15;
            this.lbClassificacao.Text = "Classificação";
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidade.Location = new System.Drawing.Point(309, 52);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(48, 13);
            this.lblValidade.TabIndex = 14;
            this.lblValidade.Text = "Validade";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(25, 91);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 13;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // txtQntd
            // 
            this.txtQntd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQntd.Location = new System.Drawing.Point(312, 102);
            this.txtQntd.MaxLength = 50;
            this.txtQntd.Name = "txtQntd";
            this.txtQntd.Size = new System.Drawing.Size(80, 20);
            this.txtQntd.TabIndex = 7;
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassificacao.Location = new System.Drawing.Point(28, 148);
            this.txtClassificacao.MaxLength = 500;
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.Size = new System.Drawing.Size(221, 20);
            this.txtClassificacao.TabIndex = 4;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(25, 51);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(25, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome";
            // 
            // txtTipoProduto
            // 
            this.txtTipoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoProduto.Location = new System.Drawing.Point(28, 65);
            this.txtTipoProduto.MaxLength = 50;
            this.txtTipoProduto.Name = "txtTipoProduto";
            this.txtTipoProduto.Size = new System.Drawing.Size(165, 20);
            this.txtTipoProduto.TabIndex = 2;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(28, 28);
            this.txtNomeProduto.MaxLength = 500;
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(221, 20);
            this.txtNomeProduto.TabIndex = 1;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(813, 58);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(145, 30);
            this.btnAtualizar.TabIndex = 11;
            this.btnAtualizar.Text = "&Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(813, 22);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(145, 30);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dtgProdutos
            // 
            this.dtgProdutos.AllowUserToAddRows = false;
            this.dtgProdutos.AllowUserToDeleteRows = false;
            this.dtgProdutos.AllowUserToResizeColumns = false;
            this.dtgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgProdutos.Location = new System.Drawing.Point(0, 0);
            this.dtgProdutos.Name = "dtgProdutos";
            this.dtgProdutos.ReadOnly = true;
            this.dtgProdutos.RowHeadersVisible = false;
            this.dtgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProdutos.Size = new System.Drawing.Size(967, 432);
            this.dtgProdutos.StandardTab = true;
            this.dtgProdutos.TabIndex = 2;
            this.dtgProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProdutos_CellContentClick);
            // 
            // gpProdutos
            // 
            this.gpProdutos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gpProdutos.Controls.Add(this.label2);
            this.gpProdutos.Controls.Add(this.txtbPesquisaProduto);
            this.gpProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpProdutos.Location = new System.Drawing.Point(3, 174);
            this.gpProdutos.Name = "gpProdutos";
            this.gpProdutos.Size = new System.Drawing.Size(955, 62);
            this.gpProdutos.TabIndex = 38;
            this.gpProdutos.TabStop = false;
            this.gpProdutos.Text = "Pesquisa";
            // 
            // txtbPesquisaProduto
            // 
            this.txtbPesquisaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPesquisaProduto.Location = new System.Drawing.Point(25, 37);
            this.txtbPesquisaProduto.MaxLength = 500;
            this.txtbPesquisaProduto.Name = "txtbPesquisaProduto";
            this.txtbPesquisaProduto.Size = new System.Drawing.Size(221, 20);
            this.txtbPesquisaProduto.TabIndex = 2;
            this.txtbPesquisaProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbPesquisaProduto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // CopyOffrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 674);
            this.Controls.Add(this.spltProduto);
            this.MaximizeBox = false;
            this.Name = "CopyOffrmProduto";
            this.Text = "Manipulação de Produtos";
            this.spltProduto.Panel1.ResumeLayout(false);
            this.spltProduto.Panel1.PerformLayout();
            this.spltProduto.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltProduto)).EndInit();
            this.spltProduto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProdutos)).EndInit();
            this.gpProdutos.ResumeLayout(false);
            this.gpProdutos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spltProduto;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DateTimePicker dtpValidade;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lbClassificacao;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtQntd;
        private System.Windows.Forms.TextBox txtClassificacao;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dtgProdutos;
        private System.Windows.Forms.ComboBox cbProdutoFornecedor;
        private System.Windows.Forms.TextBox txtTipoProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataMovimentacao;
        private System.Windows.Forms.ComboBox cbTipoMovimentacao;
        private System.Windows.Forms.Label descricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.GroupBox gpProdutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbPesquisaProduto;
    }
}*/