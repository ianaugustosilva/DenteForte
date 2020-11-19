namespace projetoDenteForte.Formulários
{
    partial class frmConvenio
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmailConvenio = new System.Windows.Forms.TextBox();
            this.btRemover = new System.Windows.Forms.Button();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstadoConvenio = new System.Windows.Forms.TextBox();
            this.txtTelefoneConvenio = new System.Windows.Forms.TextBox();
            this.txtCidadeConvenio = new System.Windows.Forms.TextBox();
            this.txtEnderecoConvenio = new System.Windows.Forms.TextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.spltPaciente = new System.Windows.Forms.SplitContainer();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dtpContrato = new System.Windows.Forms.DateTimePicker();
            this.lblDataContrato = new System.Windows.Forms.Label();
            this.dtgConvenio = new System.Windows.Forms.DataGridView();
            this.gpBoxPesquisa = new System.Windows.Forms.GroupBox();
            this.txtbRazaoSocialPesquisar = new System.Windows.Forms.TextBox();
            this.lblRazaoSocialPesquisa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spltPaciente)).BeginInit();
            this.spltPaciente.Panel1.SuspendLayout();
            this.spltPaciente.Panel2.SuspendLayout();
            this.spltPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConvenio)).BeginInit();
            this.gpBoxPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(287, 94);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "Email";
            // 
            // txtEmailConvenio
            // 
            this.txtEmailConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailConvenio.Location = new System.Drawing.Point(290, 107);
            this.txtEmailConvenio.MaxLength = 150;
            this.txtEmailConvenio.Name = "txtEmailConvenio";
            this.txtEmailConvenio.Size = new System.Drawing.Size(221, 20);
            this.txtEmailConvenio.TabIndex = 30;
            // 
            // btRemover
            // 
            this.btRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemover.Location = new System.Drawing.Point(662, 87);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(145, 30);
            this.btRemover.TabIndex = 29;
            this.btRemover.Text = "&Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(287, 129);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 18;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(287, 55);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 17;
            this.lblEstado.Text = "Estado";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(287, 15);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 16;
            this.lblCidade.Text = "Cidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Endereço";
            // 
            // txtEstadoConvenio
            // 
            this.txtEstadoConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoConvenio.Location = new System.Drawing.Point(290, 71);
            this.txtEstadoConvenio.MaxLength = 150;
            this.txtEstadoConvenio.Name = "txtEstadoConvenio";
            this.txtEstadoConvenio.Size = new System.Drawing.Size(221, 20);
            this.txtEstadoConvenio.TabIndex = 8;
            // 
            // txtTelefoneConvenio
            // 
            this.txtTelefoneConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneConvenio.Location = new System.Drawing.Point(290, 145);
            this.txtTelefoneConvenio.MaxLength = 50;
            this.txtTelefoneConvenio.Name = "txtTelefoneConvenio";
            this.txtTelefoneConvenio.Size = new System.Drawing.Size(221, 20);
            this.txtTelefoneConvenio.TabIndex = 9;
            // 
            // txtCidadeConvenio
            // 
            this.txtCidadeConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeConvenio.Location = new System.Drawing.Point(290, 29);
            this.txtCidadeConvenio.MaxLength = 50;
            this.txtCidadeConvenio.Name = "txtCidadeConvenio";
            this.txtCidadeConvenio.Size = new System.Drawing.Size(221, 20);
            this.txtCidadeConvenio.TabIndex = 6;
            // 
            // txtEnderecoConvenio
            // 
            this.txtEnderecoConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoConvenio.Location = new System.Drawing.Point(28, 145);
            this.txtEnderecoConvenio.MaxLength = 500;
            this.txtEnderecoConvenio.Name = "txtEnderecoConvenio";
            this.txtEnderecoConvenio.Size = new System.Drawing.Size(221, 20);
            this.txtEnderecoConvenio.TabIndex = 5;
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(25, 51);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(34, 13);
            this.lblCnpj.TabIndex = 6;
            this.lblCnpj.Text = "CNPJ";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocial.Location = new System.Drawing.Point(25, 15);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(70, 13);
            this.lblRazaoSocial.TabIndex = 5;
            this.lblRazaoSocial.Text = "Razão Social";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(28, 65);
            this.txtCnpj.MaxLength = 50;
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(165, 20);
            this.txtCnpj.TabIndex = 2;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocial.Location = new System.Drawing.Point(28, 28);
            this.txtRazaoSocial.MaxLength = 500;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(221, 20);
            this.txtRazaoSocial.TabIndex = 1;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(662, 51);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(145, 30);
            this.btnAtualizar.TabIndex = 13;
            this.btnAtualizar.Text = "&Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(662, 15);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(145, 30);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // spltPaciente
            // 
            this.spltPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltPaciente.Location = new System.Drawing.Point(0, 0);
            this.spltPaciente.Name = "spltPaciente";
            this.spltPaciente.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltPaciente.Panel1
            // 
            this.spltPaciente.Panel1.Controls.Add(this.gpBoxPesquisa);
            this.spltPaciente.Panel1.Controls.Add(this.btnLimpar);
            this.spltPaciente.Panel1.Controls.Add(this.dtpContrato);
            this.spltPaciente.Panel1.Controls.Add(this.lblEmail);
            this.spltPaciente.Panel1.Controls.Add(this.txtEmailConvenio);
            this.spltPaciente.Panel1.Controls.Add(this.btRemover);
            this.spltPaciente.Panel1.Controls.Add(this.lblTelefone);
            this.spltPaciente.Panel1.Controls.Add(this.lblEstado);
            this.spltPaciente.Panel1.Controls.Add(this.lblCidade);
            this.spltPaciente.Panel1.Controls.Add(this.label1);
            this.spltPaciente.Panel1.Controls.Add(this.lblDataContrato);
            this.spltPaciente.Panel1.Controls.Add(this.txtEstadoConvenio);
            this.spltPaciente.Panel1.Controls.Add(this.txtTelefoneConvenio);
            this.spltPaciente.Panel1.Controls.Add(this.txtCidadeConvenio);
            this.spltPaciente.Panel1.Controls.Add(this.txtEnderecoConvenio);
            this.spltPaciente.Panel1.Controls.Add(this.lblCnpj);
            this.spltPaciente.Panel1.Controls.Add(this.lblRazaoSocial);
            this.spltPaciente.Panel1.Controls.Add(this.txtCnpj);
            this.spltPaciente.Panel1.Controls.Add(this.txtRazaoSocial);
            this.spltPaciente.Panel1.Controls.Add(this.btnAtualizar);
            this.spltPaciente.Panel1.Controls.Add(this.btnCadastrar);
            // 
            // spltPaciente.Panel2
            // 
            this.spltPaciente.Panel2.Controls.Add(this.dtgConvenio);
            this.spltPaciente.Size = new System.Drawing.Size(820, 646);
            this.spltPaciente.SplitterDistance = 248;
            this.spltPaciente.TabIndex = 53;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(662, 123);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(145, 30);
            this.btnLimpar.TabIndex = 32;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dtpContrato
            // 
            this.dtpContrato.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpContrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpContrato.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpContrato.Location = new System.Drawing.Point(28, 106);
            this.dtpContrato.Name = "dtpContrato";
            this.dtpContrato.Size = new System.Drawing.Size(103, 20);
            this.dtpContrato.TabIndex = 3;
            // 
            // lblDataContrato
            // 
            this.lblDataContrato.AutoSize = true;
            this.lblDataContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataContrato.Location = new System.Drawing.Point(25, 91);
            this.lblDataContrato.Name = "lblDataContrato";
            this.lblDataContrato.Size = new System.Drawing.Size(73, 13);
            this.lblDataContrato.TabIndex = 13;
            this.lblDataContrato.Text = "Data Contrato";
            // 
            // dtgConvenio
            // 
            this.dtgConvenio.AllowUserToAddRows = false;
            this.dtgConvenio.AllowUserToDeleteRows = false;
            this.dtgConvenio.AllowUserToResizeColumns = false;
            this.dtgConvenio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConvenio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgConvenio.Location = new System.Drawing.Point(0, 0);
            this.dtgConvenio.Name = "dtgConvenio";
            this.dtgConvenio.ReadOnly = true;
            this.dtgConvenio.RowHeadersVisible = false;
            this.dtgConvenio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgConvenio.Size = new System.Drawing.Size(820, 394);
            this.dtgConvenio.TabIndex = 2;
            this.dtgConvenio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgConvenio_CellContentClick);
            // 
            // gpBoxPesquisa
            // 
            this.gpBoxPesquisa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gpBoxPesquisa.Controls.Add(this.lblRazaoSocialPesquisa);
            this.gpBoxPesquisa.Controls.Add(this.txtbRazaoSocialPesquisar);
            this.gpBoxPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBoxPesquisa.Location = new System.Drawing.Point(3, 185);
            this.gpBoxPesquisa.Name = "gpBoxPesquisa";
            this.gpBoxPesquisa.Size = new System.Drawing.Size(814, 60);
            this.gpBoxPesquisa.TabIndex = 33;
            this.gpBoxPesquisa.TabStop = false;
            this.gpBoxPesquisa.Text = "Pesquisa";
            // 
            // txtbRazaoSocialPesquisar
            // 
            this.txtbRazaoSocialPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbRazaoSocialPesquisar.Location = new System.Drawing.Point(25, 34);
            this.txtbRazaoSocialPesquisar.MaxLength = 500;
            this.txtbRazaoSocialPesquisar.Name = "txtbRazaoSocialPesquisar";
            this.txtbRazaoSocialPesquisar.Size = new System.Drawing.Size(261, 20);
            this.txtbRazaoSocialPesquisar.TabIndex = 34;
            this.txtbRazaoSocialPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbRazaoSocialPesquisar_KeyPress);
            // 
            // lblRazaoSocialPesquisa
            // 
            this.lblRazaoSocialPesquisa.AutoSize = true;
            this.lblRazaoSocialPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocialPesquisa.Location = new System.Drawing.Point(25, 16);
            this.lblRazaoSocialPesquisa.Name = "lblRazaoSocialPesquisa";
            this.lblRazaoSocialPesquisa.Size = new System.Drawing.Size(70, 13);
            this.lblRazaoSocialPesquisa.TabIndex = 35;
            this.lblRazaoSocialPesquisa.Text = "Razão Social";
            // 
            // frmConvenio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 646);
            this.Controls.Add(this.spltPaciente);
            this.MaximizeBox = false;
            this.Name = "frmConvenio";
            this.Text = "Manipulação de Convênio";
            this.spltPaciente.Panel1.ResumeLayout(false);
            this.spltPaciente.Panel1.PerformLayout();
            this.spltPaciente.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltPaciente)).EndInit();
            this.spltPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgConvenio)).EndInit();
            this.gpBoxPesquisa.ResumeLayout(false);
            this.gpBoxPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmailConvenio;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstadoConvenio;
        private System.Windows.Forms.TextBox txtTelefoneConvenio;
        private System.Windows.Forms.TextBox txtCidadeConvenio;
        private System.Windows.Forms.TextBox txtEnderecoConvenio;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.SplitContainer spltPaciente;
        private System.Windows.Forms.DataGridView dtgConvenio;
        private System.Windows.Forms.Label lblDataContrato;
        private System.Windows.Forms.DateTimePicker dtpContrato;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gpBoxPesquisa;
        private System.Windows.Forms.TextBox txtbRazaoSocialPesquisar;
        private System.Windows.Forms.Label lblRazaoSocialPesquisa;
    }
}