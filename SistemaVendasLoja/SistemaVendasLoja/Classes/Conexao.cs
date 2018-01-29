using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SistemaVendasLoja
{
    class Conexao
    {
        public SqlConnection con;
        public SqlCommand cSql;
        public SqlDataReader reader = null;
        public SqlDataAdapter adapter;
        DataSet ds = new DataSet();

        public string strSql = "";

        public void conecta()
        {
            string scon = "Data Source=GUI;Initial Catalog=SystemLoja;Integrated Security=True";
            con = new SqlConnection(scon);
            con.Open();
        }

        public void fechar()
        {
            con.Close();
        }

        //Comandos para table cliente Pessoa Fisica

        public string VerificaCodCliente(string nome)
        {
            conecta();
            string resp = "";
            strSql = "select nome from clientepf where nome = @nome";
            cSql = new SqlCommand(strSql, con);
            cSql.Parameters.AddWithValue("@nome", nome);
            reader = cSql.ExecuteReader();
            if (reader.Read())
                resp = reader["nome"].ToString();
            return resp;
        }

        public DataSet selecionarNome(string nome)
        {
            conecta();
            strSql = "select * from clientepf where nome = @nome";
            cSql = new SqlCommand(strSql, con);
            cSql.Parameters.AddWithValue("@nome", nome);
            adapter = new SqlDataAdapter(cSql);
            adapter.Fill(ds, "clientepf");
            fechar();
            return ds;
        }

        public void inserirCliente(Classes.Dados.dadosclientepf dc, string codigo)
        {
            conecta();
            if (codigo == null)
            {
                strSql = "insert into clientepf values (" + " @nome, @rg, @cpf, @endereco, @bairro, @cidade," +
                    "@complemento, @numero, @cep, @uf, @telefone, @celular, @contato, @email, @datanascimento, @observacoes)";
            }
            cSql = new SqlCommand(strSql, con);
            cSql.Parameters.AddWithValue("@nome", dc.nome);
            cSql.Parameters.AddWithValue("@rg", dc.rg);
            cSql.Parameters.AddWithValue("@cpf", dc.cpf);
            cSql.Parameters.AddWithValue("@endereco", dc.endereco);
            cSql.Parameters.AddWithValue("@bairro", dc.bairro);
            cSql.Parameters.AddWithValue("@cidade", dc.cidade);
            cSql.Parameters.AddWithValue("complemento", dc.complemento);
            cSql.Parameters.AddWithValue("@numero", dc.numero);
            cSql.Parameters.AddWithValue("@cep", dc.cep);
            cSql.Parameters.AddWithValue("@uf", dc.uf);
            cSql.Parameters.AddWithValue("@telefone", dc.tel);
            cSql.Parameters.AddWithValue("@celular", dc.celular);
            cSql.Parameters.AddWithValue("@contato", dc.contato);
            cSql.Parameters.AddWithValue("@email", dc.email);
            cSql.Parameters.AddWithValue("@datanascimento", dc.nascimento);
            cSql.Parameters.AddWithValue("@observacoes", dc.obs);

            cSql.ExecuteNonQuery();
            fechar();
        }

        public void AtualizarCliente()
        {
            conecta();
            strSql = "select nome from clientepf order by nome";
            cSql = new SqlCommand(strSql, con);
            reader = cSql.ExecuteReader();
        }


        public void ExcluirCliente(string nome)
        {
            conecta();
            strSql = "delete from clientepf where nome = @nome";
            cSql = new SqlCommand(strSql, con);
            cSql.Parameters.AddWithValue("@nome", nome);
            cSql.ExecuteNonQuery();
        }

        public void AlterarClientes(Classes.Dados.dadosclientepf dc, string nome)
        {
            conecta();
            strSql = "update Clientepf set nome = @nome, rg = @rg, cpf = @cpf, endereco = @endereco, bairro = @bairro, cidade = @cidade, complemento = @complemento," +
                "numero = @numero, cep = @cep, uf = @uf, telefone = @telefone, celular = @celular," +
                "contato = @contato, email = @email, datanascimento = @datanascimento, observacoes = @observacoes where nome = @nome";
            cSql = new SqlCommand(strSql, con);
            //cSql.Parameters.AddWithValue("@cod_cliente", "");
            cSql.Parameters.AddWithValue("@nome", dc.nome);
            cSql.Parameters.AddWithValue("@rg", dc.rg);
            cSql.Parameters.AddWithValue("@cpf", dc.cpf);
            cSql.Parameters.AddWithValue("@endereco", dc.endereco);
            cSql.Parameters.AddWithValue("@bairro", dc.bairro);
            cSql.Parameters.AddWithValue("@cidade", dc.cidade);
            cSql.Parameters.AddWithValue("@complemento", dc.complemento); 
            cSql.Parameters.AddWithValue("@numero", dc.complemento);
            cSql.Parameters.AddWithValue("@cep", dc.cep);
            cSql.Parameters.AddWithValue("@uf", dc.uf);
            cSql.Parameters.AddWithValue("@telefone", dc.tel);
            cSql.Parameters.AddWithValue("@celular", dc.celular);
            cSql.Parameters.AddWithValue("@contato", dc.contato);
            cSql.Parameters.AddWithValue("@email", dc.email);
            cSql.Parameters.AddWithValue("@datanascimento", dc.nascimento);
            cSql.Parameters.AddWithValue("@observacoes", dc.obs);
            
            cSql.ExecuteNonQuery();
            fechar();
        }
    
    //Comandos para Tabela Pessoa Juridica

    public string VerificaCodClientepj(string nome)
        {
            conecta();
            string resp = "";
            strSql = "select cod_cliente from clientepj where nome = @nome";
            cSql = new SqlCommand(strSql, con);
            cSql.Parameters.AddWithValue("@nome", nome);
            reader = cSql.ExecuteReader();
            if (reader.Read())
                resp = reader["cod_cliente"].ToString();
            return resp;
        }

        public DataSet selecionarNomepj(string nome)
        {
            conecta();
            strSql = "select * from clientepj where nome = @nome";
            cSql = new SqlCommand(strSql, con);
            cSql.Parameters.AddWithValue("@nome", nome);
            adapter = new SqlDataAdapter(cSql);
            adapter.Fill(ds, "clientepj");
            fechar();
            return ds;
        }

        public void inserirClientepj(Classes.Dados.dadosclientepj dc, string codigo)
        {
            conecta();
            if (codigo == null)
            {
                strSql = "insert into clientepj values (" + " @nome, @ie, @cnpj, @endereco, @bairro, @cidade," +
                    "@complemento, @numero, @cep, @uf, @telefone, @celular, @contato, @email, @observacoes)";
            }
            cSql = new SqlCommand(strSql, con);
            cSql.Parameters.AddWithValue("@nome", dc.nome);
            cSql.Parameters.AddWithValue("@ie", dc.ie);
            cSql.Parameters.AddWithValue("@cnpj", dc.cnpj);
            cSql.Parameters.AddWithValue("@endereco", dc.endereco);
            cSql.Parameters.AddWithValue("@bairro", dc.bairro);
            cSql.Parameters.AddWithValue("@cidade", dc.cidade);
            cSql.Parameters.AddWithValue("complemento", dc.complemento);
            cSql.Parameters.AddWithValue("@numero", dc.numero);
            cSql.Parameters.AddWithValue("@cep", dc.cep);
            cSql.Parameters.AddWithValue("@uf", dc.uf);
            cSql.Parameters.AddWithValue("@telefone", dc.tel);
            cSql.Parameters.AddWithValue("@celular", dc.celular);
            cSql.Parameters.AddWithValue("@contato", dc.contato);
            cSql.Parameters.AddWithValue("@email", dc.email);
            cSql.Parameters.AddWithValue("@observacoes", dc.obs);

            cSql.ExecuteNonQuery();
            fechar();
        }

        public void AtualizarClientepj()
        {
            conecta();
            strSql = "select nome from clientepj order by nome";
            cSql = new SqlCommand(strSql, con);
            reader = cSql.ExecuteReader();
        }


        public void ExcluirClientepj(string nome)
        {
            conecta();
            strSql = "delete from clientepj where nome = @nome";
            cSql = new SqlCommand(strSql, con);
            cSql.Parameters.AddWithValue("@nome", nome);
            cSql.ExecuteNonQuery();
        }

        public void AlterarClientespj(Classes.Dados.dadosclientepj dc, string codigo)
        {
            conecta();
            strSql = "update Clientepj set nome = @nome, ie = @ie, cnpj = @cnpj, endereco = @endereco, bairro = @bairro, cidade = @cidade, complemento = @complemento," +
                "numero = @numero, cep = @cep, uf = @uf, telefone = @telefone, celular = @celular," +
                "contato = @contato, email = @email, observacoes = @observacoes where nome = @nome";
            cSql = new SqlCommand(strSql, con);
            //cSql.Parameters.AddWithValue("@cod_cliente", codigo);
            cSql.Parameters.AddWithValue("@nome", dc.nome);
            cSql.Parameters.AddWithValue("@ie", dc.ie);
            cSql.Parameters.AddWithValue("@cnpj", dc.cnpj);
            cSql.Parameters.AddWithValue("@endereco", dc.endereco);
            cSql.Parameters.AddWithValue("@bairro", dc.bairro);
            cSql.Parameters.AddWithValue("@cidade", dc.cidade);
            cSql.Parameters.AddWithValue("@complemento", dc.complemento); 
            cSql.Parameters.AddWithValue("@numero", dc.complemento);
            cSql.Parameters.AddWithValue("@cep", dc.cep);
            cSql.Parameters.AddWithValue("@uf", dc.uf);
            cSql.Parameters.AddWithValue("@telefone", dc.tel);
            cSql.Parameters.AddWithValue("@celular", dc.celular);
            cSql.Parameters.AddWithValue("@contato", dc.contato);
            cSql.Parameters.AddWithValue("@email", dc.email);
            cSql.Parameters.AddWithValue("@observacoes", dc.obs);

            cSql.ExecuteNonQuery();
            fechar();
        }
        }
}
