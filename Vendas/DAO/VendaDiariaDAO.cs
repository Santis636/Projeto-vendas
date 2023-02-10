using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.DAO
{
    public class VendaDiariaDAO : Vendas
    {
        public List<VendaDiariaDAO> vendaDiarias(Vendas entityVendas, int QuantidadedoItem)
        {
            var itemlista = new List<VendaDiariaDAO>();

            for (int i = 0; i < QuantidadedoItem; i++)
            {
                VendaDiariaDAO vendaDiaria = new VendaDiariaDAO();
                vendaDiaria.Nome_Produto = entityVendas.Nome_Produto;
                vendaDiaria.Preco = entityVendas.Preco;
                itemlista.Add(vendaDiaria);
            }
            
            return itemlista;
        }
        public void FinalizarVenda(List<Venda>, quantidade )
        {

        }
    }
}
