namespace projetoDenteForte.Formulários
{
    partial class frmFornecedor
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
            this.dtgFornecedor = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dtpDataContratoFornecedor = new System.Windows.Forms.DateTimePicker();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmailFornecedor = new System.Windows.Forms.TextBox();
            this.btRemover = new System.Windows.Forms.Button();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblContrato = new System.Windows.Forms.Label();
            this.txtEstadoFornecedor = new System.Windows.Forms.TextBox();
            this.txtTelefoneFornecedor = new System.Windows.Forms.TextBox();
            this.txtCidadeFornecedor = new System.Windows.Forms.TextBox();
            this.txtEnderecoFornecedor = new System.Windows.Forms.TextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.spltFornecedor = new System.Windows.Forms.SplitContainer();
            this.gpBoxPesquisa = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbNomePesquisa = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtTipoFornecedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spltFornecedor)).BeginInit();
            this.spltFornecedor.Panel1.SuspendLayout();
            this.spltFornecedor.Panel2.SuspendLayout();
            this.spltFornecedor.SuspendLayout();
            this.gpBoxPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgFornecedor
            // 
            this.dtgFornecedor.AllowUserToAddRows = false;
            this.dtgFornecedor.AllowUserToDeleteRows = false;
            this.dtgFornecedor.AllowUserToResizeColumns = false;
            this.dtgFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFornecedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgFornecedor.Location = new System.Drawing.Point(0, 0);
            this.dtgFornecedor.Name = "dtgFornecedor";
            this.dtgFornecedor.ReadOnly = true;
            this.dtgFornecedor.RowHeadersVisible = false;
            this.dtgFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgFornecedor.Size = new System.Drawing.Size(1033, 407);
            this.dtgFornecedor.StandardTab = true;
            this.dtgFornecedor.TabIndex = 2;
            this.dtgFornecedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFornecedor_CellContentClick);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(876, 130);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(145, 30);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dtpDataContratoFornecedor
            // 
            this.dtpDataContratoFornecedor.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataContratoFornecedor.Location = new System.Drawing.Point(28, 107);
            this.dtpDataContratoFornecedor.Name = "dtpDataContratoFornecedor";
            this.dtpDataContratoFornecedor.Size = new System.Drawing.Size(221, 20);
            this.dtpDataContratoFornecedor.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(271, 93);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "Email";
            // 
            // txtEmailFornecedor
            // 
            this.txtEmailFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailFornecedor.Location = new System.Drawing.Point(274, 108);
            this.txtEmailFornecedor.MaxLength = 150;
            this.txtEmailFornecedor.Name = "txtEmailFornecedor";
            this.txtEmailFornecedor.Size = new System.Drawing.Size(221, 20);
            this.txtEmailFornecedor.TabIndex = 7;
            // 
            // btRemover
            // 
            this.btRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemover.Location = new System.Drawing.Point(876, 94);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(145, 30);
            this.btRemover.TabIndex = 13;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(271, 130);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 18;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(271, 54);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 17;
            this.lblEstado.Text = "Estado";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(271, 14);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 16;
            this.lblCidade.Text = "Cidade";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(25, 130);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 15;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrato.Location = new System.Drawing.Point(25, 88);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(73, 13);
            this.lblContrato.TabIndex = 14;
            this.lblContrato.Text = "Data Contrato";
            // 
            // txtEstadoFornecedor
            // 
            this.txtEstadoFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoFornecedor.Location = new System.Drawing.Point(274, 70);
            this.txtEstadoFornecedor.MaxLength = 150;
            this.txtEstadoFornecedor.Name = "txtEstadoFornecedor";
            this.txtEstadoFornecedor.Size = new System.Drawing.Size(221, 20);
            this.txtEstadoFornecedor.TabIndex = 6;
            // 
            // txtTelefoneFornecedor
            // 
            this.txtTelefoneFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneFornecedor.Location = new System.Drawing.Point(274, 146);
            this.txtTelefoneFornecedor.MaxLength = 50;
            this.txtTelefoneFornecedor.Name = "txtTelefoneFornecedor";
            this.txtTelefoneFornecedor.Size = new System.Drawing.Size(221, 20);
            this.txtTelefoneFornecedor.TabIndex = 8;
            // 
            // txtCidadeFornecedor
            // 
            this.txtCidadeFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeFornecedor.Location = new System.Drawing.Point(274, 28);
            this.txtCidadeFornecedor.MaxLength = 50;
            this.txtCidadeFornecedor.Name = "txtCidadeFornecedor";
            this.txtCidadeFornecedor.Size = new System.Drawing.Size(221, 20);
            this.txtCidadeFornecedor.TabIndex = 5;
            // 
            // txtEnderecoFornecedor
            // 
            this.txtEnderecoFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoFornecedor.Location = new System.Drawing.Point(28, 146);
            this.txtEnderecoFornecedor.MaxLength = 500;
            this.txtEnderecoFornecedor.Name = "txtEnderecoFornecedor";
            this.txtEnderecoFornecedor.Size = new System.Drawing.Size(221, 20);
            this.txtEnderecoFornecedor.TabIndex = 4;
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
            this.btnAtualizar.Location = new System.Drawing.Point(876, 58);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(145, 30);
            this.btnAtualizar.TabIndex = 11;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(876, 22);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(145, 30);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // spltFornecedor
            // 
            this.spltFornecedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltFornecedor.Location = new System.Drawing.Point(0, 0);
            this.spltFornecedor.Name = "spltFornecedor";
            this.spltFornecedor.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltFornecedor.Panel1
            // 
            this.spltFornecedor.Panel1.Controls.Add(this.gpBoxPesquisa);
            this.spltFornecedor.Panel1.Controls.Add(this.lbl);
            this.spltFornecedor.Panel1.Controls.Add(this.txtTipoFornecedor);
            this.spltFornecedor.Panel1.Controls.Add(this.btnLimpar);
            this.spltFornecedor.Panel1.Controls.Add(this.dtpDataContratoFornecedor);
            this.spltFornecedor.Panel1.Controls.Add(this.lblEmail);
            this.spltFornecedor.Panel1.Controls.Add(this.txtEmailFornecedor);
            this.spltFornecedor.Panel1.Controls.Add(this.btRemover);
            this.spltFornecedor.Panel1.Controls.Add(this.lblTelefone);
            this.spltFornecedor.Panel1.Controls.Add(this.lblEstado);
            this.spltFornecedor.Panel1.Controls.Add(this.lblCidade);
            this.spltFornecedor.Panel1.Controls.Add(this.lblEndereco);
            this.spltFornecedor.Panel1.Controls.Add(this.lblContrato);
            this.spltFornecedor.Panel1.Controls.Add(this.txtEstadoFornecedor);
            this.spltFornecedor.Panel1.Controls.Add(this.txtTelefoneFornecedor);
            this.spltFornecedor.Panel1.Controls.Add(this.txtCidadeFornecedor);
            this.spltFornecedor.Panel1.Controls.Add(this.txtEnderecoFornecedor);
            this.spltFornecedor.Panel1.Controls.Add(this.lblCnpj);
            this.spltFornecedor.Panel1.Controls.Add(this.lblRazaoSocial);
            this.spltFornecedor.Panel1.Controls.Add(this.txtCnpj);
            this.spltFornecedor.Panel1.Controls.Add(this.txtRazaoSocial);
            this.spltFornecedor.Panel1.Controls.Add(this.btnAtualizar);
            this.spltFornecedor.Panel1.Controls.Add(this.btnCadastrar);
            // 
            // spltFornecedor.Panel2
            // 
            this.spltFornecedor.Panel2.Controls.Add(this.dtgFornecedor);
            this.spltFornecedor.Size = new System.Drawing.Size(1033, 660);
            this.spltFornecedor.SplitterDistance = 249;
            this.spltFornecedor.TabIndex = 54;
            // 
            // gpBoxPesquisa
            // 
            this.gpBoxPesquisa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gpBoxPesquisa.Controls.Add(this.label2);
            this.gpBoxPesquisa.Controls.Add(this.txtbNomePesquisa);
            this.gpBoxPesquisa.Location = new System.Drawing.Point(0, 184);
            this.gpBoxPesquisa.Name = "gpBoxPesquisa";
            this.gpBoxPesquisa.Size = new System.Drawing.Size(1037, 63);
            this.gpBoxPesquisa.TabIndex = 36;
            this.gpBoxPesquisa.TabStop = false;
            this.gpBoxPesquisa.Text = "Pesquisa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nome";
            // 
            // txtbNomePesquisa
            // 
            this.txtbNomePesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNomePesquisa.Location = new System.Drawing.Point(25, 37);
            this.txtbNomePesquisa.MaxLength = 500;
            this.txtbNomePesquisa.Name = "txtbNomePesquisa";
            this.txtbNomePesquisa.Size = new System.Drawing.Size(221, 20);
            this.txtbNomePesquisa.TabIndex = 33;
            this.txtbNomePesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNomePesquisa_KeyPress);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(525, 12);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(110, 13);
            this.lbl.TabIndex = 33;
            this.lbl.Text = "Tipo de Fornecimento";
            // 
            // txtTipoFornecedor
            // 
            this.txtTipoFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoFornecedor.Location = new System.Drawing.Point(528, 28);
            this.txtTipoFornecedor.MaxLength = 50;
            this.txtTipoFornecedor.Name = "txtTipoFornecedor";
            this.txtTipoFornecedor.Size = new System.Drawing.Size(221, 20);
            this.txtTipoFornecedor.TabIndex = 9;
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 660);
            this.Controls.Add(this.spltFornecedor);
            this.MaximizeBox = false;
            this.Name = "frmFornecedor";
            this.Text = "frmFornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.dtgFornecedor)).EndInit();
            this.spltFornecedor.Panel1.ResumeLayout(false);
            this.spltFornecedor.Panel1.PerformLayout();
            this.spltFornecedor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltFornecedor)).EndInit();
            this.spltFornecedor.ResumeLayout(false);
            this.gpBoxPesquisa.ResumeLayout(false);
            this.gpBoxPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgFornecedor;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DateTimePicker dtpDataContratoFornecedor;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmailFornecedor;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.TextBox txtEstadoFornecedor;
        private System.Windows.Forms.TextBox txtTelefoneFornecedor;
        private System.Windows.Forms.TextBox txtCidadeFornecedor;
        private System.Windows.Forms.TextBox txtEnderecoFornecedor;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.SplitContainer spltFornecedor;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtTipoFornecedor;
        private System.Windows.Forms.GroupBox gpBoxPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbNomePesquisa;
    }
}