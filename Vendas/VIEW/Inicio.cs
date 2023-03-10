using System;
using System.Collections.Generic;
using System.Data;
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
        ProdutoListaDAO produtoDAO = new ProdutoListaDAO();
        #endregion
        private void Btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (Tb_Preco.Text != "")
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
                        bool itemExisteNaLista = false;
                        int indexDaLinha = -1;

                        for (int i = 0; i < Dg_ListadeVendas.Rows.Count; i++)
                        {
                            if (Dg_ListadeVendas.Rows[i].Cells["Nome_Produto"].Value != null &&
                                Dg_ListadeVendas.Rows[i].Cells["Nome_Produto"].Value.ToString() == entityVendas.Nome_Produto)
                            {
                                itemExisteNaLista = true;
                                indexDaLinha = i;
                                break;
                            }
                        }

                        if (!itemExisteNaLista)
                        {

                            try
                            {
                                var vendas = vendaDAO.vendaDiarias(entityVendas, quantidadeDoItem);

                                foreach (var venda in vendas)
                                {
                                    Dg_ListadeVendas.Rows.Add(venda.Nome_Produto, venda.Preco, quantidadeDoItem);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ocorreu um erro ao adicionar o item: " + ex.Message);
                            }
                        }
                        else
                        {
                            int quantidadeAtual = Convert.ToInt32(Dg_ListadeVendas.Rows[indexDaLinha].Cells["Quantidade"].Value);
                            quantidadeAtual += quantidadeDoItem;
                            Dg_ListadeVendas.Rows[indexDaLinha].Cells["Quantidade"].Value = quantidadeAtual;
                        }

                    }
                }
                else
                {
                    quantidadeDoItem = 1;
                    bool itemExisteNaLista = false;
                    foreach (DataGridViewRow row in Dg_ListadeVendas.Rows)
                    {
                        if (row.Cells["Nome_Produto"].Value != null && row.Cells["Nome_Produto"].Value.ToString() == entityVendas.Nome_Produto)
                        {
                            itemExisteNaLista = true;
                            MessageBox.Show("Por favor utilize uma quantidade valida");
                            break;
                        }
                    }

                    if (!itemExisteNaLista)
                    {
                        try
                        {
                            var vendas = vendaDAO.vendaDiarias(entityVendas, quantidadeDoItem);

                            foreach (var venda in vendas)
                            {
                                Dg_ListadeVendas.Rows.Add(venda.Nome_Produto, venda.Preco, quantidadeDoItem);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocorreu um erro ao adicionar o item: " + ex.Message);
                        }
                    }
                }


            }
            else
            {
                MessageBox.Show("Por favor selecione o produto e seu preço antes de adiona-lo novamente a lista.");
                Cb_Nome.Focus();
            }

            Tb_Preco.Clear();
            Tb_Quantidade.Clear();
            atualizarpreco();
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

        private void Inicio_Load(object sender, EventArgs e)
        {
            Dg_ListadeVendas.Columns.Add("Nome_Produto", "Nome do Produto");
            Dg_ListadeVendas.Columns.Add("Preco", "Preço");
            Dg_ListadeVendas.Columns.Add("Quantidade", "Quantidade");
        }

        private void Btn_Finalizar_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in Dg_ListadeVendas.Rows)
            {
                if (row.Cells["Nome_Produto"].Value != null)
                {
                    Vendas vendas = new Vendas();
                    vendas.Nome_Produto = row.Cells["Nome_Produto"].Value.ToString();
                    vendas.Preco = Convert.ToInt32(row.Cells["Preco"].Value);
                    int quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value);
                    vendaDAO.FinalizarVenda(vendas, quantidade);
                }
            }
        }
        private void atualizarpreco()
        {
            int sum = 0;
            foreach (DataGridViewRow row in Dg_ListadeVendas.Rows)
            {
                int value = Convert.ToInt32(row.Cells["Preco"].Value);
                int quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value);
                sum += value * quantidade;
            }
            Lb_Total.Text = (sum / 100.0).ToString("C");
        }
    }
}
