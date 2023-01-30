using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.DAO
{
    public class ProdutoDAO : Produtos
    {
        public void AdicionarProduto(Produtos entityProd, int Quantidade) 
        {
            using(var dbContext = new MercadinhoSeuFelipeEntities()) 
            {
                for (int i = 0; i < Quantidade; i++)
                {
                    dbContext.Produtos.Add(entityProd);
                    dbContext.SaveChanges();

                }
            }
            
        }

        
    }
}
