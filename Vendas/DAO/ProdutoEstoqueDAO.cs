using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas.DAO
{
    public class ProdutoEstoqueDAO : ProdutosEstoque
    {


        public void AdicionarProduto(ProdutosEstoque entityProd, int Quantidade)
        {
            using (var dbContext = new MercadinhoSeuFelipeEntities1())
            {
                for (int i = 0; i < Quantidade; i++)
                {
                    dbContext.ProdutosEstoque.Add(entityProd);
                    dbContext.SaveChanges();

                }
            }

        }
        public static List<ProdutoEstoqueDAO> GetProdutosEstoque()
        {
            using (var dbContext = new MercadinhoSeuFelipeEntities1())
            {
                var produtos = dbContext.ProdutosEstoque.ToList();
                var listProduto = new List<ProdutoEstoqueDAO>();

                foreach (var item in produtos)
                {
                    listProduto.Add(new ProdutoEstoqueDAO { Id_Produto = item.Id_Produto, Nome = item.Nome, Preco = item.Preco, Cod_Barra = item.Cod_Barra });
                }
                return listProduto;
            }
        }

    }
}
