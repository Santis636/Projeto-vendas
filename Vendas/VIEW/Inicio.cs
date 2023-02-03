using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        VendaDiariaDAO vendaDAO = new VendaDiariaDAO();
        BuscarProduto produtoDAO = new ProdutoListaDAO();
        #endregion
        private void Btn_Adicionar_Click(object sender, EventArgs e)
        {
            var entityVendas = new Vendas();
            int QuantidadoDoItem = Convert.ToInt32(Tb_Quantidade);
            entityVendas.Nome_Produto = Cb_Nome.Text;
            entityVendas.Preco = Convert.ToInt32(Tb_Quantidade.Text);
            vendaDAO.vendaDiarias(entityVendas);
        }

        private void Cb_Nome_Leave(object sender, EventArgs e)
        {
            var nome = Cb_Nome.Text;
            produtoDAO.BuscarProdutos(nome);
            var produto = produtoDAO.BuscarProdutos(nome);


            Tb_Preco.Text = produto.Preco.ToString();
        }

        private void Cb_Nome_Enter(object sender, EventArgs e)
        {
            Cb_Nome.DataSource = produtoDAO.CbProtuto();
        }
    }
}
