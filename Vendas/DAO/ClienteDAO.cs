using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.DAO
{
    public class ClienteDAO : Pessoa
    {

        public void AdicionarCliente(Pessoa entityPessoa)
        {
            using (var dbContext = new MercadinhoSeuFelipeEntities1())
            {
                dbContext.Pessoa.Add(entityPessoa);
                dbContext.SaveChanges();
            }
        }
        public List<ClienteDAO> GetClientes()
        {
            using (var dbContext = new MercadinhoSeuFelipeEntities1())
            {
                var clientes = dbContext.Pessoa.ToList();
                var listClientes = new List<ClienteDAO>();
                foreach (var item in clientes)
                {
                    listClientes.Add(new ClienteDAO { Id_Pessoa = item.Id_Pessoa, Nome_Pessoa = item.Nome_Pessoa});
                }
                return listClientes;

            }
           
        }
    }
}
