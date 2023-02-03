using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.DAO
{
    public class VendaDiariaDAO : Vendas
    {
        public List<VendaDiariaDAO> vendaDiarias(Vendas entityVendas)
        {
            var itemlista = new List<VendaDiariaDAO>();

            itemlista.Add((VendaDiariaDAO)entityVendas);
            return itemlista;
        }
    }
}
