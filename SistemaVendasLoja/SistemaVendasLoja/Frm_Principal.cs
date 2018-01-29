using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendasLoja
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Produto produto = new Frm_Produto();
            produto.ShowDialog();  
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Produto produto = new Frm_Produto();
            produto.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
           Frm_Clientepf cliente = new Frm_Clientepf(null);
           cliente.ShowDialog();
        }

        private void pessoaFísicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Clientepf cliente = new Frm_Clientepf(null);
            cliente.ShowDialog();
        }

        private void btn_estoque_Click(object sender, EventArgs e)
        {

        }

        private void pessoaJurídicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Clientepj cliente = new Frm_Clientepj(null);
            cliente.ShowDialog();
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            Frm_Usuario usuario = new Frm_Usuario();
            usuario.ShowDialog();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Usuario usuario = new Frm_Usuario();
            usuario.ShowDialog();
        }
    }
}
