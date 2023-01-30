using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Vendas.VIEW
{
    public partial class TelaInicio : Form
    {
        public TelaInicio()
        {
            InitializeComponent();
        }
        private void AbrirFormulario(object form)
        {
            if (this.PainelContedor.Controls.Count > 0)
                this.PainelContedor.Controls.RemoveAt(0);
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PainelContedor.Controls.Add(fh);
            this.PainelContedor.Tag = fh;
            fh.Show();
        }
        private void TelaInicio_Load(object sender, EventArgs e)
        {
            Btn_Inicio_Click(null, e); //Iniciar com uma tela definida pela função
        }

        #region "MOVIMENTAÇÃO DO MOUSE"
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion  
        #region "MENU LATERAL"
        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Btn_Maximizar.Visible = false;
            Btn_Janela.Visible = true;
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        

        private void Btn_Janela_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Btn_Maximizar.Visible = true;
            Btn_Janela.Visible = false;
        }

        private void Btn_Relatorio_Click(object sender, EventArgs e)
        {
            Btn_RelVendas.Visible = true;
            Btn_RelDevedor.Visible = true;
            Btn_Pagos.Visible = true;

        }

        private void Btn_CadProd_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new CadProdutos());
        }
        private void Btn_Inicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Inicio());
        }


        #endregion

        
    }
}
