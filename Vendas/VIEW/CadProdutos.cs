using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vendas.DAO;

namespace Vendas.VIEW
{
    public partial class CadProdutos : Form
    {
        public CadProdutos()
        {
            InitializeComponent();
        }
        #region "OBJETOS"
        ProdutoEstoqueDAO ProdutoEstoqueDAO = new ProdutoEstoqueDAO();
        BuscarProduto ProdutoListaDAO = new ProdutoListaDAO();
        #endregion

        private void Btn_AdicionarProd_Click(object sender, EventArgs e)
        {
            var entityProd = new ProdutosLista();
            var entityprod = new ProdutosEstoque();
            entityprod.Nome = Tb_Nome.Text;
            entityProd.Nome = Tb_Nome.Text;
            entityProd.Preco = Convert.ToInt32(Tb_Preco.Text);
            entityprod.Preco = Convert.ToInt32(Tb_Preco.Text);
            entityprod.Cod_Barra = Convert.ToInt32(Tb_CodBarra.Text);
            int Quantidade = Convert.ToInt32(Tb_Quantidade.Text);
            try
            {
                ProdutoListaDAO.AdicionarProdLista(entityProd);
                ProdutoEstoqueDAO.AdicionarProduto(entityprod, Quantidade);
                MessageBox.Show("Salvo");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Falha: {ex.Message}");
            }

            Dg_ProdutosCad.DataSource = BuscarProduto.GetProdutoLista();

            Tb_Nome.Clear();
            Tb_Preco.Clear();
            Tb_CodBarra.Clear();
            Tb_Quantidade.Clear();
        }

        private void Btn_AtualizarrProd_Click(object sender, EventArgs e)
        {
            Dg_ProdutosCad.DataSource = BuscarProduto.GetProdutoLista();
        }

        private void CadProdutos_Load(object sender, EventArgs e)
        {
            Btn_AtualizarrProd_Click(null, e);
        }
    }
}
