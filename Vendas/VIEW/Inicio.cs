using System;
using System.Windows.Forms;
using Vendas.DAO;

namespace Vendas.VIEW
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        #region "Objetos"
        VendaDiariaDAO VendaDAO = new VendaDiariaDAO();
        ProdutoListaDAO produtoDAO = new ProdutoListaDAO();
        #endregion
        private void Btn_Adicionar_Click(object sender, EventArgs e)
        {
            var entityVendas = new Vendas();
            entityVendas.Nome_Produto = Cb_Nome.Text;
            entityVendas.Preco = Convert.ToInt32(Tb_Preco.Text);

            int quantidadeDoItem;
            if (Tb_Quantidade.Text != "")
            {
                quantidadeDoItem = Convert.ToInt32(Tb_Quantidade.Text);
                if (quantidadeDoItem >= 1)
                {
                    var vendaDAO = new VendaDiariaDAO();
                    var vendas = vendaDAO.vendaDiarias(entityVendas, quantidadeDoItem);
                    foreach (var venda in vendas)
                    {
                        Lb_Vendas.Items.Add(venda.Nome_Produto + " - " + venda.Preco + " - " + quantidadeDoItem + " unidades");
                        // Adiciona o nome do produto, preço e quantidade na lista
                    }
                }
            }
            else
            {
                quantidadeDoItem = 1;
                var vendaDAO = new VendaDiariaDAO();
                var vendas = vendaDAO.vendaDiarias(entityVendas, quantidadeDoItem);
                foreach (var venda in vendas)
                {
                    Lb_Vendas.Items.Add(venda.Nome_Produto + " - " + venda.Preco + " - " + quantidadeDoItem + " unidade");
                    // Adiciona o nome do produto, preço e quantidade na lista
                }
            }

            Tb_Preco.Clear();
            Tb_Quantidade.Clear();
        }


        private void Cb_Nome_Leave(object sender, EventArgs e)
        {
            var nome = Cb_Nome.Text;
            produtoDAO.ProdutoListaDAOs(nome);
            var produto = produtoDAO.ProdutoListaDAOs(nome);


            Tb_Preco.Text = produto.Preco.ToString();
        }

        private void Cb_Nome_Enter(object sender, EventArgs e)
        {
            Cb_Nome.DataSource = produtoDAO.CbProduto();
        }
    }
}
