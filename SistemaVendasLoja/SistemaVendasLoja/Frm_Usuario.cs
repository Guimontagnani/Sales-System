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
    public partial class Frm_Usuario : Form
    {
        public string foto = "";

        public Frm_Usuario()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (od.FileName != "")
            {
                this.foto = od.FileName;
                pb_foto.Load(this.foto);
                
            }
        }

        private void pb_foto_Click(object sender, EventArgs e)
        {

        }
    }
}
