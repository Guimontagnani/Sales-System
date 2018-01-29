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
    public partial class Frm_Clientepj : Form
    {
        public string foto = "";
        public Frm_Clientepj(string id)
        {
            InitializeComponent();
            identificacao = id;
        }
        
        //instanciar as classes
        Classes.Dados.dadosclientepj dc = new Classes.Dados.dadosclientepj();
        Conexao conexao = new Conexao();
        Classes.Validacao valida = new Classes.Validacao();

        string identificacao = null;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        int verificar = 0;
        int clique = 0;

        public void Carregar()
        {
            ds = conexao.selecionarNomepj(txb_nome.Text);
            dt = ds.Tables["clientepj"];
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    txb_nome.Text = row["nome"].ToString();
                    txb_ie.Text = row["ie"].ToString();
                    txb_cnpj.Text = row["cnpj"].ToString();
                    txb_endereco.Text = row["endereco"].ToString();
                    txb_bairro.Text = row["bairro"].ToString();
                    txb_cidade.Text = row["cidade"].ToString();
                    txb_num.Text = row["numero"].ToString();
                    txb_complemento.Text = row["complemento"].ToString();
                    txb_cep.Text = row["cep"].ToString();
                    txb_uf.Text = row["uf"].ToString();
                    txb_tel.Text = row["telefone"].ToString();
                    txb_celular.Text = row["celular"].ToString();
                    txb_contato.Text = row["contato"].ToString();
                    txb_email.Text = row["email"].ToString();
                    txb_obs.Text = row["observacoes"].ToString();
                }
            }
            else
            {
                MessageBox.Show("CADASTRO NÃO ENCONTRADO");
            }
        }

        public void Habilitar()
        {
            txb_nome.Enabled = true;
            txb_ie.Enabled = true;
            txb_cnpj.Enabled = true;
            txb_endereco.Enabled = true;
            txb_bairro.Enabled = true;
            txb_cidade.Enabled = true;
            txb_num.Enabled = true;
            txb_complemento.Enabled = true;
            txb_cep.Enabled = true;
            txb_uf.Enabled = true;
            txb_tel.Enabled = true;
            txb_celular.Enabled = true;
            txb_contato.Enabled = true;
            txb_email.Enabled = true;
            txb_obs.Enabled = true;
        }

        public void limpar()
        {
            txb_nome.Text = "";
            txb_ie.Text = "";
            txb_cnpj.Text = "";
            txb_endereco.Text = "";
            txb_bairro.Text = "";
            txb_cidade.Text = "";
            txb_num.Text = "";
            txb_complemento.Text = "";
            txb_cep.Text = "";
            txb_uf.Text = "";
            txb_tel.Text = "";
            txb_celular.Text = "";
            txb_contato.Text = "";
            txb_email.Text = "";
            txb_obs.Text = "";
        }

        public void desabilitar()
        {
            txb_nome.Enabled = true;
            txb_ie.Enabled = false;
            txb_cnpj.Enabled = false;
            txb_endereco.Enabled = false;
            txb_bairro.Enabled = false;
            txb_cidade.Enabled = false;
            txb_num.Enabled = false;
            txb_complemento.Enabled = false;
            txb_cep.Enabled = false;
            txb_uf.Enabled = false;
            txb_tel.Enabled = false;
            txb_celular.Enabled = false;
            txb_contato.Enabled = false;
            txb_email.Enabled = false;
            txb_obs.Enabled = false;
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Frm_Clientepf cliente = new Frm_Clientepf(null);
            cliente.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (od.FileName != "")
            {
                this.foto = od.FileName;
                pb_foto.Load();
            }
        }

        private void Frm_Clientepj_Load(object sender, EventArgs e)
        {

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            Carregar();
            //Habilitar();
            verificar++;
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            limpar();
            desabilitar();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            txb_nome.Enabled = true;
            Habilitar();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (clique == 0)
            {
                txb_nome.Enabled = true;
                //btn_pesq.Enabled = true;
                clique++;
                limpar();
                desabilitar();
            }
            else
            {
                conexao.ExcluirCliente(txb_nome.Text);
                verificar = 0;
                MessageBox.Show("EXCLUIDO COM SUCESSO");
                limpar();
                desabilitar();
                clique = 0;
                limpar();
                desabilitar();
            }
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            string res = valida.validaclientepj(txb_nome.Text, txb_ie.Text, txb_cnpj.Text, txb_endereco.Text, txb_bairro.Text,
    txb_cidade.Text, txb_num.Text, txb_complemento.Text, txb_cep.Text, txb_uf.Text, txb_tel.Text,
    txb_celular.Text, txb_contato.Text, txb_email.Text, txb_obs.Text);

            dc.nome = txb_nome.Text;
            dc.ie = txb_ie.Text;
            dc.cnpj = txb_cnpj.Text;
            dc.endereco = txb_endereco.Text;
            dc.bairro = txb_bairro.Text;
            dc.cidade = txb_cidade.Text;
            dc.numero = txb_num.Text;
            dc.complemento = txb_complemento.Text;
            dc.cep = txb_cep.Text;
            dc.uf = txb_uf.Text;
            dc.tel = txb_tel.Text;
            dc.celular = txb_tel.Text;
            dc.contato = txb_contato.Text;
            dc.email = txb_email.Text;
            dc.obs = txb_obs.Text;

            if (res == null)
            {
                if (verificar == 0)
                {
                    conexao.inserirClientepj(dc, null);
                    MessageBox.Show("CADASTRADO COM SUCESSO");
                    limpar();
                    desabilitar();
                }
                else
                {
                    conexao.AlterarClientespj(dc, txb_nome.Text);
                    MessageBox.Show("ALTERADO COM SUCESSO");
                    limpar();
                    desabilitar();
                    verificar = 0;
                }

            }
            else
                MessageBox.Show(res);
        }
    }
}
