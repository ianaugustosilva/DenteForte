namespace projetoDenteForte.Formulários
{
    partial class frmAgenda
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
            this.dtgAgenda = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.spltProduto = new System.Windows.Forms.SplitContainer();
            this.gpProdutos = new System.Windows.Forms.GroupBox();
            this.lblPacienteFiltro = new System.Windows.Forms.Label();
            this.txtPacienteFiltro = new System.Windows.Forms.TextBox();
            this.lblFuncionarioFiltro = new System.Windows.Forms.Label();
            this.txtFuncionarioFiltro = new System.Windows.Forms.TextBox();
            this.lblHoraFiltro = new System.Windows.Forms.Label();
            this.txtHoraFiltro = new System.Windows.Forms.TextBox();
            this.lblDataFiltro = new System.Windows.Forms.Label();
            this.txtDataFiltro = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lbNomeFuncionario = new System.Windows.Forms.Label();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.cbPaciente = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spltProduto)).BeginInit();
            this.spltProduto.Panel1.SuspendLayout();
            this.spltProduto.Panel2.SuspendLayout();
            this.spltProduto.SuspendLayout();
            this.gpProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgAgenda
            // 
            this.dtgAgenda.AllowUserToAddRows = false;
            this.dtgAgenda.AllowUserToDeleteRows = false;
            this.dtgAgenda.AllowUserToResizeColumns = false;
            this.dtgAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAgenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgAgenda.Location = new System.Drawing.Point(0, 0);
            this.dtgAgenda.MultiSelect = false;
            this.dtgAgenda.Name = "dtgAgenda";
            this.dtgAgenda.ReadOnly = true;
            this.dtgAgenda.RowHeadersVisible = false;
            this.dtgAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAgenda.Size = new System.Drawing.Size(979, 432);
            this.dtgAgenda.StandardTab = true;
            this.dtgAgenda.TabIndex = 2;
            this.dtgAgenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAgenda_CellContentClick);
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
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePaciente.Location = new System.Drawing.Point(25, 15);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(49, 13);
            this.lblNomePaciente.TabIndex = 5;
            this.lblNomePaciente.Text = "Paciente";
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
            this.btnCadastrar.Text = "&Agendar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
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
            this.spltProduto.Panel1.Controls.Add(this.lblObservacao);
            this.spltProduto.Panel1.Controls.Add(this.txtObservacao);
            this.spltProduto.Panel1.Controls.Add(this.dtpHora);
            this.spltProduto.Panel1.Controls.Add(this.lblHora);
            this.spltProduto.Panel1.Controls.Add(this.lblData);
            this.spltProduto.Panel1.Controls.Add(this.dtpData);
            this.spltProduto.Panel1.Controls.Add(this.lbNomeFuncionario);
            this.spltProduto.Panel1.Controls.Add(this.cbFuncionario);
            this.spltProduto.Panel1.Controls.Add(this.cbPaciente);
            this.spltProduto.Panel1.Controls.Add(this.btnLimpar);
            this.spltProduto.Panel1.Controls.Add(this.btRemover);
            this.spltProduto.Panel1.Controls.Add(this.lblNomePaciente);
            this.spltProduto.Panel1.Controls.Add(this.btnAtualizar);
            this.spltProduto.Panel1.Controls.Add(this.btnCadastrar);
            // 
            // spltProduto.Panel2
            // 
            this.spltProduto.Panel2.Controls.Add(this.dtgAgenda);
            this.spltProduto.Size = new System.Drawing.Size(979, 693);
            this.spltProduto.SplitterDistance = 257;
            this.spltProduto.TabIndex = 54;
            // 
            // gpProdutos
            // 
            this.gpProdutos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gpProdutos.Controls.Add(this.lblPacienteFiltro);
            this.gpProdutos.Controls.Add(this.txtPacienteFiltro);
            this.gpProdutos.Controls.Add(this.lblFuncionarioFiltro);
            this.gpProdutos.Controls.Add(this.txtFuncionarioFiltro);
            this.gpProdutos.Controls.Add(this.lblHoraFiltro);
            this.gpProdutos.Controls.Add(this.txtHoraFiltro);
            this.gpProdutos.Controls.Add(this.lblDataFiltro);
            this.gpProdutos.Controls.Add(this.txtDataFiltro);
            this.gpProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpProdutos.Location = new System.Drawing.Point(3, 192);
            this.gpProdutos.Name = "gpProdutos";
            this.gpProdutos.Size = new System.Drawing.Size(975, 63);
            this.gpProdutos.TabIndex = 39;
            this.gpProdutos.TabStop = false;
            this.gpProdutos.Text = "Filtro";
            // 
            // lblPacienteFiltro
            // 
            this.lblPacienteFiltro.AutoSize = true;
            this.lblPacienteFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacienteFiltro.Location = new System.Drawing.Point(703, 21);
            this.lblPacienteFiltro.Name = "lblPacienteFiltro";
            this.lblPacienteFiltro.Size = new System.Drawing.Size(49, 13);
            this.lblPacienteFiltro.TabIndex = 12;
            this.lblPacienteFiltro.Text = "Paciente";
            // 
            // txtPacienteFiltro
            // 
            this.txtPacienteFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPacienteFiltro.Location = new System.Drawing.Point(706, 37);
            this.txtPacienteFiltro.MaxLength = 500;
            this.txtPacienteFiltro.Name = "txtPacienteFiltro";
            this.txtPacienteFiltro.Size = new System.Drawing.Size(221, 20);
            this.txtPacienteFiltro.TabIndex = 11;
            this.txtPacienteFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPacienteFiltro_KeyPress);
            // 
            // lblFuncionarioFiltro
            // 
            this.lblFuncionarioFiltro.AutoSize = true;
            this.lblFuncionarioFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionarioFiltro.Location = new System.Drawing.Point(476, 21);
            this.lblFuncionarioFiltro.Name = "lblFuncionarioFiltro";
            this.lblFuncionarioFiltro.Size = new System.Drawing.Size(62, 13);
            this.lblFuncionarioFiltro.TabIndex = 10;
            this.lblFuncionarioFiltro.Text = "Funcionário";
            // 
            // txtFuncionarioFiltro
            // 
            this.txtFuncionarioFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncionarioFiltro.Location = new System.Drawing.Point(479, 37);
            this.txtFuncionarioFiltro.MaxLength = 500;
            this.txtFuncionarioFiltro.Name = "txtFuncionarioFiltro";
            this.txtFuncionarioFiltro.Size = new System.Drawing.Size(221, 20);
            this.txtFuncionarioFiltro.TabIndex = 9;
            this.txtFuncionarioFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFuncionarioFiltro_KeyPress);
            // 
            // lblHoraFiltro
            // 
            this.lblHoraFiltro.AutoSize = true;
            this.lblHoraFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFiltro.Location = new System.Drawing.Point(249, 21);
            this.lblHoraFiltro.Name = "lblHoraFiltro";
            this.lblHoraFiltro.Size = new System.Drawing.Size(30, 13);
            this.lblHoraFiltro.TabIndex = 8;
            this.lblHoraFiltro.Text = "Hora";
            // 
            // txtHoraFiltro
            // 
            this.txtHoraFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraFiltro.Location = new System.Drawing.Point(252, 37);
            this.txtHoraFiltro.MaxLength = 500;
            this.txtHoraFiltro.Name = "txtHoraFiltro";
            this.txtHoraFiltro.Size = new System.Drawing.Size(221, 20);
            this.txtHoraFiltro.TabIndex = 7;
            this.txtHoraFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoraFiltro_KeyPress);
            // 
            // lblDataFiltro
            // 
            this.lblDataFiltro.AutoSize = true;
            this.lblDataFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFiltro.Location = new System.Drawing.Point(22, 21);
            this.lblDataFiltro.Name = "lblDataFiltro";
            this.lblDataFiltro.Size = new System.Drawing.Size(30, 13);
            this.lblDataFiltro.TabIndex = 6;
            this.lblDataFiltro.Text = "Data";
            // 
            // txtDataFiltro
            // 
            this.txtDataFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFiltro.Location = new System.Drawing.Point(25, 37);
            this.txtDataFiltro.MaxLength = 500;
            this.txtDataFiltro.Name = "txtDataFiltro";
            this.txtDataFiltro.Size = new System.Drawing.Size(221, 20);
            this.txtDataFiltro.TabIndex = 2;
            this.txtDataFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataFiltro_KeyPress);
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(25, 105);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 23;
            this.lblObservacao.Text = "Observação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(28, 121);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(570, 55);
            this.txtObservacao.TabIndex = 22;
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(339, 78);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(73, 20);
            this.dtpHora.TabIndex = 21;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(336, 59);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 20;
            this.lblHora.Text = "Hora";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(25, 59);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 19;
            this.lblData.Text = "Data";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(28, 78);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(259, 20);
            this.dtpData.TabIndex = 18;
            // 
            // lbNomeFuncionario
            // 
            this.lbNomeFuncionario.AutoSize = true;
            this.lbNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeFuncionario.Location = new System.Drawing.Point(336, 15);
            this.lbNomeFuncionario.Name = "lbNomeFuncionario";
            this.lbNomeFuncionario.Size = new System.Drawing.Size(62, 13);
            this.lbNomeFuncionario.TabIndex = 17;
            this.lbNomeFuncionario.Text = "Funcionário";
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(339, 31);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(259, 21);
            this.cbFuncionario.TabIndex = 16;
            // 
            // cbPaciente
            // 
            this.cbPaciente.FormattingEnabled = true;
            this.cbPaciente.Location = new System.Drawing.Point(28, 31);
            this.cbPaciente.Name = "cbPaciente";
            this.cbPaciente.Size = new System.Drawing.Size(259, 21);
            this.cbPaciente.TabIndex = 14;
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 693);
            this.Controls.Add(this.spltProduto);
            this.Name = "frmAgenda";
            this.Text = "Manipulação de Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgenda)).EndInit();
            this.spltProduto.Panel1.ResumeLayout(false);
            this.spltProduto.Panel1.PerformLayout();
            this.spltProduto.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltProduto)).EndInit();
            this.spltProduto.ResumeLayout(false);
            this.gpProdutos.ResumeLayout(false);
            this.gpProdutos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgAgenda;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.SplitContainer spltProduto;
        private System.Windows.Forms.Label lbNomeFuncionario;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.ComboBox cbPaciente;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.GroupBox gpProdutos;
        private System.Windows.Forms.Label lblPacienteFiltro;
        private System.Windows.Forms.TextBox txtPacienteFiltro;
        private System.Windows.Forms.Label lblFuncionarioFiltro;
        private System.Windows.Forms.TextBox txtFuncionarioFiltro;
        private System.Windows.Forms.Label lblHoraFiltro;
        private System.Windows.Forms.TextBox txtHoraFiltro;
        private System.Windows.Forms.Label lblDataFiltro;
        private System.Windows.Forms.TextBox txtDataFiltro;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}