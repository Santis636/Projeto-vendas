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
    public partial class CadProdutos : Form
    {
        public CadProdutos()
        {
            InitializeComponent();
        }
        #region "OBJETOS"
        ProdutoDAO ProdDAO = new ProdutoDAO();
        #endregion

        private void Btn_AdicionarProd_Click(object sender, EventArgs e)
        {
            var entityProd = new Produtos();
            entityProd.Nome = Tb_Nome.Text;
            entityProd.Preco = Convert.ToInt32(Tb_Preco.Text);
            entityProd.Cod_Barra = Convert.ToInt32(Tb_CodBarra.Text);
            int Quantidade = Convert.ToInt32(Tb_Quantidade.Text);
            try
            {
                ProdDAO.AdicionarProduto(entityProd, Quantidade);
                MessageBox.Show("Salvo");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Falha: {ex.Message}");
            }
            

        }
    }
}
