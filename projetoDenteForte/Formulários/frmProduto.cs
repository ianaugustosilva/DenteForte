using projetoDenteForte.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoDenteForte.Formulários
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
            carregarGrid();
            carregarCbFornecedor();
            carregarCbTipoMovimentacao();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.nomeProduto = txtNomeProduto.Text;
            p.tipoProduto = txtTipoProduto.Text;
            p.idFornecedor = cbProdutoFornecedor.SelectedValue.ToString();
            p.classificacaoProduto = txtClassificacao.Text;
            p.descricaoProduto = txtDescricao.Text;
            p.validadeProduto = dtpValidade.Value;
            p.quantidadeProduto = Convert.ToInt32(txtQntd.Text);
            p.dataMovimentacaoProduto = dtpValidade.Value;
            p.tipoMovimentacaoProduto = cbTipoMovimentacao.SelectedValue.ToString();
            p.cadastrar();
            carregarGrid();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtNomeProduto.Tag != null)
            {
                string id = dtgProdutos.CurrentRow.Cells[9].Value.ToString();

                Produto p = new Produto();
                p.nomeProduto = txtNomeProduto.Text;
                p.tipoProduto = txtTipoProduto.Text;
                p.classificacaoProduto = txtClassificacao.Text;
                p.descricaoProduto = txtDescricao.Text;
                p.validadeProduto = dtpValidade.Value;
                p.quantidadeProduto = Convert.ToInt32(txtQntd.Text);
                p.dataMovimentacaoProduto = dtpValidade.Value;
                p.tipoMovimentacaoProduto = cbTipoMovimentacao.SelectedValue.ToString();
                p.idFornecedor = cbProdutoFornecedor.SelectedValue.ToString();
                p.idProduto = txtNomeProduto.Tag.ToString();

                DialogResult result = MessageBox.Show("Deseja atualizar o registro " + id, "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    p.atualizar();
                    carregarGrid();
                }
            }
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            string id = dtgProdutos.CurrentRow.Cells[9].Value.ToString();
            DialogResult result = MessageBox.Show("Deseja excluir o registro " + id, "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Produto oProduto = new Produto();
                oProduto.remover(Convert.ToInt32(id));
                carregarGrid();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparControles();
        }

        private void dtgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dtgProdutos.CurrentRow.Cells[9].Value.ToString();
            Produto oProduto = new Produto();
            oProduto.consultar(Convert.ToInt32(id));

            txtNomeProduto.Text = oProduto.nomeProduto;
            txtNomeProduto.Tag = id;

            txtTipoProduto.Text = oProduto.tipoProduto;
            txtClassificacao.Text = oProduto.classificacaoProduto;
            txtDescricao.Text = oProduto.descricaoProduto;
            dtpValidade.Value = oProduto.validadeProduto;
            txtQntd.Text = Convert.ToInt32(oProduto.quantidadeProduto).ToString();
            cbTipoMovimentacao.SelectedValue = oProduto.tipoMovimentacaoProduto;
            dtpDataMovimentacao.Value = oProduto.dataMovimentacaoProduto;
        }

        private void carregarGrid()
        {
            Produto oProduto = new Produto();
            List<Produto> Lista = oProduto.Consultar();

            var source = new BindingSource();
            source.DataSource = Lista;

            dtgProdutos.Columns.Clear();
            dtgProdutos.AutoGenerateColumns = false;

            dtgProdutos.Columns.Add("nome", "Nome do Produto");
            dtgProdutos.Columns[0].DataPropertyName = "nomeProduto";

            dtgProdutos.Columns.Add("tipo", "Tipo Produto");
            dtgProdutos.Columns[1].DataPropertyName = "tipoProduto";

            dtgProdutos.Columns.Add("fornecedor", "Fornecedor");
            dtgProdutos.Columns[2].DataPropertyName = "fornecedorProduto";

            dtgProdutos.Columns.Add("classificacao", "Classificação do Produto");
            dtgProdutos.Columns[3].DataPropertyName = "classificacaoProduto";

            dtgProdutos.Columns.Add("descricao", "Descrição do Produto");
            dtgProdutos.Columns[4].DataPropertyName = "descricaoProduto";

            dtgProdutos.Columns.Add("validade", "Data Validade");
            dtgProdutos.Columns[5].DataPropertyName = "validadeProduto";

            dtgProdutos.Columns.Add("quantidade", "Quantidade Produto");
            dtgProdutos.Columns[6].DataPropertyName = "quantidadeProduto";

            dtgProdutos.Columns.Add("tipomovimentacao", "Tipo Movimentação");
            dtgProdutos.Columns[7].DataPropertyName = "tipoMovimentacaoProduto";

            dtgProdutos.Columns.Add("datamovimentacao", "Data Movimetacão");
            dtgProdutos.Columns[8].DataPropertyName = "dataMovimentacaoProduto";

            dtgProdutos.Columns.Add("id", "ID");
            dtgProdutos.Columns[9].DataPropertyName = "idProduto";

            dtgProdutos.DataSource = Lista;
        }

        private void carregarCbTipoMovimentacao()
        {
            Dictionary<string, string> movimentacao = new Dictionary<string, string>();
            movimentacao.Add("S", "Saída");
            movimentacao.Add("E", "Entrada");
            cbTipoMovimentacao.DataSource = new BindingSource(movimentacao, null);
            cbTipoMovimentacao.DisplayMember = "Value";
            cbTipoMovimentacao.ValueMember = "Key";
        }
        private void carregarCbFornecedor()
        {
            var bdSource = new BindingSource();
            Fornecedor p = new Fornecedor();
            bdSource.DataSource = p.Consultar();
            cbProdutoFornecedor.DataSource = bdSource;
            cbProdutoFornecedor.DisplayMember = "razaoSocialFornecedor";
            cbProdutoFornecedor.ValueMember = "idFornecedor";
        }

        private void limparControles()
        {
            txtNomeProduto.Text = "";
            txtNomeProduto.Tag = null;
            txtTipoProduto.Text = "";
            txtDescricao.Text = "";
            txtClassificacao.Text = "";
            txtQntd.Text = "";
        }

        private void txtbPesquisaProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[dtgProdutos.DataSource];

            foreach (DataGridViewRow row in dtgProdutos.Rows)
            {
                if (row.Cells["Nome"].Value.ToString().ToUpper().Contains(txtbPesquisaProduto.Text.ToString().ToUpper()))
                {
                    row.Visible = true;
                }
                else
                {
                    cm.SuspendBinding();
                    row.Visible = false;
                    cm.ResumeBinding();
                }
            }
        }
    }
}
