using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.DAO;

namespace Vendas
{
    internal class BuscarProduto : ProdutosLista
    {
        public void AdicionarProdLista(ProdutosLista entityprod)
        {
            using (var dbContext = new MercadinhoSeuFelipeEntities1())
            {
                var procurar = dbContext.ProdutosLista.Where(p => p.Nome == entityprod.Nome).FirstOrDefault();
                if (procurar == null)
                {
                    dbContext.ProdutosLista.Add(entityprod);
                    dbContext.SaveChanges();

                }
                else
                {

                }
            }
        }
        public static List<BuscarProduto> GetProdutoLista()
        {
            using (var dbContext = new MercadinhoSeuFelipeEntities1())
            {
                var produtos = dbContext.ProdutosLista.ToList();
                var listProduto = new List<BuscarProduto>();

                foreach (var item in produtos)
                {
                    listProduto.Add(new ProdutoListaDAO { Id_Produto = item.Id_Produto, Nome = item.Nome, Preco = item.Preco });
                }
                return listProduto;
            }
        }
        public List<String> CbProtuto()
        {
            var listcb = new List<String>();
            using (var dbContext = new MercadinhoSeuFelipeEntities1())
            {
                var produtolist = (from r in dbContext.ProdutosLista select r.Nome).ToList();
                foreach (var item in produtolist)
                {
                    listcb.Add(item);
                }

            }
            return listcb;
        }
        public ProdutosEstoque BuscarProdutos(String nome)
        {
            using (var dbContext = new MercadinhoSeuFelipeEntities1())
            {
                var pesqproduto = dbContext.ProdutosLista.Where(p => p.Nome == nome).FirstOrDefault();
                var produto = new ProdutosEstoque();
                if (pesqproduto != null)
                {
                    produto.Preco = pesqproduto.Preco;
                }
                return produto;
            }
        }

    }
}
