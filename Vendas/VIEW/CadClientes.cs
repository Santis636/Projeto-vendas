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
    public partial class CadCliente : Form
    {
        public CadCliente()
        {
            InitializeComponent();
        }
        #region "Objetos"
        ClienteDAO clienteDAO = new ClienteDAO();
        #endregion
        private void Btn_AdicionarCliente_Click(object sender, EventArgs e)
        {
            var entityPessoa = new Pessoa();
            entityPessoa.Nome_Pessoa = Tb_NomeCliente.Text;
            clienteDAO.AdicionarCliente(entityPessoa);
            Dg_ClientesCad.DataSource = clienteDAO.GetClientes();
            Tb_NomeCliente.Clear();
        }

        private void Btn_AtualizarrCliente_Click(object sender, EventArgs e)
        {
             Dg_ClientesCad.DataSource = clienteDAO.GetClientes();
        }

        private void CadCliente_Load(object sender, EventArgs e)
        {
            Btn_AtualizarrCliente_Click(null, e);
        }
    }
}
