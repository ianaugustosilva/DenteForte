namespace projetoDenteForte.Formulários
{
    partial class frmFuncionario
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
            this.txtEmailFuncionario = new System.Windows.Forms.TextBox();
            this.btRemover = new System.Windows.Forms.Button();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtCelularFuncionario = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtEstadoFuncionario = new System.Windows.Forms.TextBox();
            this.txtTelefoneFuncionario = new System.Windows.Forms.TextBox();
            this.txtCidadeFuncionario = new System.Windows.Forms.TextBox();
            this.txtEnderecoFuncionario = new System.Windows.Forms.TextBox();
            this.txtCpfFuncionario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtRGFuncionario = new System.Windows.Forms.TextBox();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.spltFuncionario = new System.Windows.Forms.SplitContainer();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.dtpDataNascimentoFuncionario = new System.Windows.Forms.DateTimePicker();
            this.dtgFuncionario = new System.Windows.Forms.DataGridView();
            this.gpBoxPesquisa = new System.Windows.Forms.GroupBox();
            this.lblFuncionarioNomePesquisar = new System.Windows.Forms.Label();
            this.txtbFuncionarioPesquisar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.spltFuncionario)).BeginInit();
            this.spltFuncionario.Panel1.SuspendLayout();
            this.spltFuncionario.Panel2.SuspendLayout();
            this.spltFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncionario)).BeginInit();
            this.gpBoxPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(283, 130);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "Email";
            // 
            // txtEmailFuncionario
            // 
            this.txtEmailFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailFuncionario.Location = new System.Drawing.Point(286, 145);
            this.txtEmailFuncionario.MaxLength = 150;
            this.txtEmailFuncionario.Name = "txtEmailFuncionario";
            this.txtEmailFuncionario.Size = new System.Drawing.Size(221, 20);
            this.txtEmailFuncionario.TabIndex = 8;
            // 
            // btRemover
            // 
            this.btRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemover.Location = new System.Drawing.Point(878, 87);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(145, 30);
            this.btRemover.TabIndex = 14;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(534, 91);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 24;
            this.lblSexo.Text = "Sexo";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(534, 49);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 23;
            this.lblCelular.Text = "Celular";
            // 
            // txtCelularFuncionario
            // 
            this.txtCelularFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelularFuncionario.Location = new System.Drawing.Point(537, 65);
            this.txtCelularFuncionario.MaxLength = 500;
            this.txtCelularFuncionario.Name = "txtCelularFuncionario";
            this.txtCelularFuncionario.Size = new System.Drawing.Size(221, 20);
            this.txtCelularFuncionario.TabIndex = 10;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(534, 12);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 18;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(283, 91);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 17;
            this.lblEstado.Text = "Estado";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(283, 51);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 16;
            this.lblCidade.Text = "Cidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Endereço";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.Location = new System.Drawing.Point(25, 130);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(104, 13);
            this.lblNascimento.TabIndex = 14;
            this.lblNascimento.Text = "Data de Nascimento";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(25, 91);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 13;
            this.lblCpf.Text = "CPF";
            // 
            // txtEstadoFuncionario
            // 
            this.txtEstadoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoFuncionario.Location = new System.Drawing.Point(286, 107);
            this.txtEstadoFuncionario.MaxLength = 150;
            this.txtEstadoFuncionario.Name = "txtEstadoFuncionario";
            this.txtEstadoFuncionario.Size = new System.Drawing.Size(221, 20);
            this.txtEstadoFuncionario.TabIndex = 7;
            // 
            // txtTelefoneFuncionario
            // 
            this.txtTelefoneFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneFuncionario.Location = new System.Drawing.Point(537, 28);
            this.txtTelefoneFuncionario.MaxLength = 50;
            this.txtTelefoneFuncionario.Name = "txtTelefoneFuncionario";
            this.txtTelefoneFuncionario.Size = new System.Drawing.Size(221, 20);
            this.txtTelefoneFuncionario.TabIndex = 9;
            // 
            // txtCidadeFuncionario
            // 
            this.txtCidadeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeFuncionario.Location = new System.Drawing.Point(286, 65);
            this.txtCidadeFuncionario.MaxLength = 50;
            this.txtCidadeFuncionario.Name = "txtCidadeFuncionario";
            this.txtCidadeFuncionario.Size = new System.Drawing.Size(221, 20);
            this.txtCidadeFuncionario.TabIndex = 6;
            // 
            // txtEnderecoFuncionario
            // 
            this.txtEnderecoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoFuncionario.Location = new System.Drawing.Point(286, 28);
            this.txtEnderecoFuncionario.MaxLength = 500;
            this.txtEnderecoFuncionario.Name = "txtEnderecoFuncionario";
            this.txtEnderecoFuncionario.Size = new System.Drawing.Size(221, 20);
            this.txtEnderecoFuncionario.TabIndex = 5;
            // 
            // txtCpfFuncionario
            // 
            this.txtCpfFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfFuncionario.Location = new System.Drawing.Point(28, 107);
            this.txtCpfFuncionario.MaxLength = 11;
            this.txtCpfFuncionario.Name = "txtCpfFuncionario";
            this.txtCpfFuncionario.Size = new System.Drawing.Size(165, 20);
            this.txtCpfFuncionario.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(25, 51);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(23, 13);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "RG";
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
            // txtRGFuncionario
            // 
            this.txtRGFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRGFuncionario.Location = new System.Drawing.Point(28, 65);
            this.txtRGFuncionario.MaxLength = 50;
            this.txtRGFuncionario.Name = "txtRGFuncionario";
            this.txtRGFuncionario.Size = new System.Drawing.Size(165, 20);
            this.txtRGFuncionario.TabIndex = 2;
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFuncionario.Location = new System.Drawing.Point(28, 28);
            this.txtNomeFuncionario.MaxLength = 500;
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(221, 20);
            this.txtNomeFuncionario.TabIndex = 1;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(878, 51);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(145, 30);
            this.btnAtualizar.TabIndex = 13;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(878, 15);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(145, 30);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // spltFuncionario
            // 
            this.spltFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltFuncionario.Location = new System.Drawing.Point(0, 0);
            this.spltFuncionario.Name = "spltFuncionario";
            this.spltFuncionario.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltFuncionario.Panel1
            // 
            this.spltFuncionario.Panel1.Controls.Add(this.gpBoxPesquisa);
            this.spltFuncionario.Panel1.Controls.Add(this.btnLimpar);
            this.spltFuncionario.Panel1.Controls.Add(this.cbSexo);
            this.spltFuncionario.Panel1.Controls.Add(this.dtpDataNascimentoFuncionario);
            this.spltFuncionario.Panel1.Controls.Add(this.lblEmail);
            this.spltFuncionario.Panel1.Controls.Add(this.txtEmailFuncionario);
            this.spltFuncionario.Panel1.Controls.Add(this.btRemover);
            this.spltFuncionario.Panel1.Controls.Add(this.lblSexo);
            this.spltFuncionario.Panel1.Controls.Add(this.lblCelular);
            this.spltFuncionario.Panel1.Controls.Add(this.txtCelularFuncionario);
            this.spltFuncionario.Panel1.Controls.Add(this.lblTelefone);
            this.spltFuncionario.Panel1.Controls.Add(this.lblEstado);
            this.spltFuncionario.Panel1.Controls.Add(this.lblCidade);
            this.spltFuncionario.Panel1.Controls.Add(this.label1);
            this.spltFuncionario.Panel1.Controls.Add(this.lblNascimento);
            this.spltFuncionario.Panel1.Controls.Add(this.lblCpf);
            this.spltFuncionario.Panel1.Controls.Add(this.txtEstadoFuncionario);
            this.spltFuncionario.Panel1.Controls.Add(this.txtTelefoneFuncionario);
            this.spltFuncionario.Panel1.Controls.Add(this.txtCidadeFuncionario);
            this.spltFuncionario.Panel1.Controls.Add(this.txtEnderecoFuncionario);
            this.spltFuncionario.Panel1.Controls.Add(this.txtCpfFuncionario);
            this.spltFuncionario.Panel1.Controls.Add(this.lblSenha);
            this.spltFuncionario.Panel1.Controls.Add(this.lblNome);
            this.spltFuncionario.Panel1.Controls.Add(this.txtRGFuncionario);
            this.spltFuncionario.Panel1.Controls.Add(this.txtNomeFuncionario);
            this.spltFuncionario.Panel1.Controls.Add(this.btnAtualizar);
            this.spltFuncionario.Panel1.Controls.Add(this.btnCadastrar);
            // 
            // spltFuncionario.Panel2
            // 
            this.spltFuncionario.Panel2.Controls.Add(this.dtgFuncionario);
            this.spltFuncionario.Size = new System.Drawing.Size(1049, 673);
            this.spltFuncionario.SplitterDistance = 248;
            this.spltFuncionario.TabIndex = 53;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(878, 123);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(145, 30);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cbSexo
            // 
            this.cbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbSexo.Location = new System.Drawing.Point(537, 106);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(140, 21);
            this.cbSexo.TabIndex = 11;
            // 
            // dtpDataNascimentoFuncionario
            // 
            this.dtpDataNascimentoFuncionario.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascimentoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascimentoFuncionario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimentoFuncionario.Location = new System.Drawing.Point(28, 146);
            this.dtpDataNascimentoFuncionario.Name = "dtpDataNascimentoFuncionario";
            this.dtpDataNascimentoFuncionario.Size = new System.Drawing.Size(200, 20);
            this.dtpDataNascimentoFuncionario.TabIndex = 4;
            // 
            // dtgFuncionario
            // 
            this.dtgFuncionario.AllowUserToAddRows = false;
            this.dtgFuncionario.AllowUserToDeleteRows = false;
            this.dtgFuncionario.AllowUserToResizeColumns = false;
            this.dtgFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgFuncionario.Location = new System.Drawing.Point(0, 0);
            this.dtgFuncionario.Name = "dtgFuncionario";
            this.dtgFuncionario.ReadOnly = true;
            this.dtgFuncionario.RowHeadersVisible = false;
            this.dtgFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgFuncionario.Size = new System.Drawing.Size(1049, 421);
            this.dtgFuncionario.TabIndex = 2;
            this.dtgFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFuncionario_CellContentClick);
            // 
            // gpBoxPesquisa
            // 
            this.gpBoxPesquisa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gpBoxPesquisa.Controls.Add(this.lblFuncionarioNomePesquisar);
            this.gpBoxPesquisa.Controls.Add(this.txtbFuncionarioPesquisar);
            this.gpBoxPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBoxPesquisa.Location = new System.Drawing.Point(3, 185);
            this.gpBoxPesquisa.Name = "gpBoxPesquisa";
            this.gpBoxPesquisa.Size = new System.Drawing.Size(1046, 60);
            this.gpBoxPesquisa.TabIndex = 34;
            this.gpBoxPesquisa.TabStop = false;
            this.gpBoxPesquisa.Text = "Pesquisa";
            // 
            // lblFuncionarioNomePesquisar
            // 
            this.lblFuncionarioNomePesquisar.AutoSize = true;
            this.lblFuncionarioNomePesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionarioNomePesquisar.Location = new System.Drawing.Point(25, 16);
            this.lblFuncionarioNomePesquisar.Name = "lblFuncionarioNomePesquisar";
            this.lblFuncionarioNomePesquisar.Size = new System.Drawing.Size(35, 13);
            this.lblFuncionarioNomePesquisar.TabIndex = 35;
            this.lblFuncionarioNomePesquisar.Text = "Nome";
            // 
            // txtbFuncionarioPesquisar
            // 
            this.txtbFuncionarioPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFuncionarioPesquisar.Location = new System.Drawing.Point(25, 34);
            this.txtbFuncionarioPesquisar.MaxLength = 500;
            this.txtbFuncionarioPesquisar.Name = "txtbFuncionarioPesquisar";
            this.txtbFuncionarioPesquisar.Size = new System.Drawing.Size(261, 20);
            this.txtbFuncionarioPesquisar.TabIndex = 34;
            this.txtbFuncionarioPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbFuncionarioPesquisar_KeyPress);
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 673);
            this.Controls.Add(this.spltFuncionario);
            this.MaximizeBox = false;
            this.Name = "frmFuncionario";
            this.Text = "Manipulaçao de dados dos Funcionários";
            this.spltFuncionario.Panel1.ResumeLayout(false);
            this.spltFuncionario.Panel1.PerformLayout();
            this.spltFuncionario.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltFuncionario)).EndInit();
            this.spltFuncionario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFuncionario)).EndInit();
            this.gpBoxPesquisa.ResumeLayout(false);
            this.gpBoxPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmailFuncionario;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtCelularFuncionario;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtEstadoFuncionario;
        private System.Windows.Forms.TextBox txtTelefoneFuncionario;
        private System.Windows.Forms.TextBox txtCidadeFuncionario;
        private System.Windows.Forms.TextBox txtEnderecoFuncionario;
        private System.Windows.Forms.TextBox txtCpfFuncionario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtRGFuncionario;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.SplitContainer spltFuncionario;
        private System.Windows.Forms.DataGridView dtgFuncionario;
        private System.Windows.Forms.DateTimePicker dtpDataNascimentoFuncionario;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gpBoxPesquisa;
        private System.Windows.Forms.Label lblFuncionarioNomePesquisar;
        private System.Windows.Forms.TextBox txtbFuncionarioPesquisar;
    }
}