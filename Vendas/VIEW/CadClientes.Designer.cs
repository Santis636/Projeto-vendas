namespace Vendas.VIEW
{
    partial class CadCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_NomeCliente = new System.Windows.Forms.TextBox();
            this.Btn_AdicionarCliente = new System.Windows.Forms.Button();
            this.Btn_ExcluirCliente = new System.Windows.Forms.Button();
            this.Btn_AtualizarrCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dg_ClientesCad = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_ClientesCad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(60)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.Btn_ExcluirCliente);
            this.panel1.Controls.Add(this.Btn_AtualizarrCliente);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1214, 770);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Tb_NomeCliente);
            this.groupBox2.Controls.Add(this.Btn_AdicionarCliente);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(83, 81);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(457, 213);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastro de Cliente";
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // Tb_NomeCliente
            // 
            this.Tb_NomeCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tb_NomeCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tb_NomeCliente.Location = new System.Drawing.Point(62, 68);
            this.Tb_NomeCliente.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_NomeCliente.Name = "Tb_NomeCliente";
            this.Tb_NomeCliente.Size = new System.Drawing.Size(365, 30);
            this.Tb_NomeCliente.TabIndex = 2;
            // 
            // Btn_AdicionarCliente
            // 
            this.Btn_AdicionarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_AdicionarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AdicionarCliente.FlatAppearance.BorderSize = 6;
            this.Btn_AdicionarCliente.Location = new System.Drawing.Point(153, 130);
            this.Btn_AdicionarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_AdicionarCliente.Name = "Btn_AdicionarCliente";
            this.Btn_AdicionarCliente.Size = new System.Drawing.Size(137, 32);
            this.Btn_AdicionarCliente.TabIndex = 0;
            this.Btn_AdicionarCliente.Text = "Adicionar";
            this.Btn_AdicionarCliente.UseVisualStyleBackColor = true;
            this.Btn_AdicionarCliente.Click += new System.EventHandler(this.Btn_AdicionarCliente_Click);
            // 
            // Btn_ExcluirCliente
            // 
            this.Btn_ExcluirCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_ExcluirCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ExcluirCliente.FlatAppearance.BorderSize = 6;
            this.Btn_ExcluirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExcluirCliente.Location = new System.Drawing.Point(948, 657);
            this.Btn_ExcluirCliente.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ExcluirCliente.Name = "Btn_ExcluirCliente";
            this.Btn_ExcluirCliente.Size = new System.Drawing.Size(107, 32);
            this.Btn_ExcluirCliente.TabIndex = 29;
            this.Btn_ExcluirCliente.Text = "Excluir";
            this.Btn_ExcluirCliente.UseVisualStyleBackColor = true;
            // 
            // Btn_AtualizarrCliente
            // 
            this.Btn_AtualizarrCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_AtualizarrCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AtualizarrCliente.FlatAppearance.BorderSize = 6;
            this.Btn_AtualizarrCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AtualizarrCliente.Location = new System.Drawing.Point(714, 657);
            this.Btn_AtualizarrCliente.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_AtualizarrCliente.Name = "Btn_AtualizarrCliente";
            this.Btn_AtualizarrCliente.Size = new System.Drawing.Size(125, 32);
            this.Btn_AtualizarrCliente.TabIndex = 28;
            this.Btn_AtualizarrCliente.Text = "Atualizar";
            this.Btn_AtualizarrCliente.UseVisualStyleBackColor = true;
            this.Btn_AtualizarrCliente.Click += new System.EventHandler(this.Btn_AtualizarrCliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.Dg_ClientesCad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(590, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(611, 555);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes Cadastrados";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // Dg_ClientesCad
            // 
            this.Dg_ClientesCad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_ClientesCad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dg_ClientesCad.Location = new System.Drawing.Point(4, 23);
            this.Dg_ClientesCad.Name = "Dg_ClientesCad";
            this.Dg_ClientesCad.RowHeadersWidth = 51;
            this.Dg_ClientesCad.Size = new System.Drawing.Size(603, 528);
            this.Dg_ClientesCad.TabIndex = 0;
            // 
            // CadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 770);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadCliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CadCliente_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_ClientesCad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_NomeCliente;
        private System.Windows.Forms.Button Btn_AdicionarCliente;
        private System.Windows.Forms.Button Btn_ExcluirCliente;
        private System.Windows.Forms.Button Btn_AtualizarrCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Dg_ClientesCad;
    }
}