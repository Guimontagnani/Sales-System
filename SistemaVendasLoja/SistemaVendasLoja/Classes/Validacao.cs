using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendasLoja.Classes
{
    class Validacao
    {
        //validacao dos campos de cadastro de clientepf
        public string validaclientepf(string nome, string rg, string cpf, string endereco, string bairro, string cidade,
            string numero, string complemento, string cep, string uf, string tel, string celular, string contato,
            string email, string nascimento, string obs)
        {
            //variaveis
            string res = null;
            //condicoes para as validacoes
            if (nome.Length > 30 || nome.Length == 0)//o campo nome nao pode ser vazio
                res = res + "Campo NOME: Máximo de Caracteres = 30 \n";
            if (rg.Length < 9)
                res = res + "Campo RG: Não é permitido campo em branco \n";
            if (cpf.Length < 11)//devido ao componente maskTextBox ja inserir dados no banco de dados
                res = res + "Campo CPF: Não é permitido campo em branco \n";
            if (endereco.Length > 20 || endereco.Length == 0)
                res = res + "Campo ENDEREÇO: Excesso de caracteres \n";
            if (bairro.Length > 10 || bairro.Length == 0)
                res = res + "Campo BAIRRO: Excesso de caracteres \n";
            if (cidade.Length > 15 || cidade.Length == 0)
                res = res + "Campo CIDADE: Excessode caracteres \n";
            if (numero.Length > 5 || numero.Length == 0)
                res = res + "Campo NÚMERO: Excesso de caracteres \n";
            if (complemento.Length > 20 || complemento.Length == 0)
                res = res + "Campo Complemento: Excesso de caracteres \n";
            if (cep.Length > 8 || cep.Length == 0)
                res = res + "Campo Cep: Exxcesso de Caracteres";
            if (uf.Length > 2 || uf.Length == 0)
                res = res + "Campo UF: Excesso de caracteres \n";
            if (tel.Length < 10)
                res = res + "Campo TELEFONE: Não é permitido campo em branco \n";
            if (celular.Length < 11)
                res = res + "Campo Celular: Não é permitido campo em branco \n";
            if (contato.Length > 15 || contato.Length == 0)
                res = res + "Campo Contato Preenchido de forma incorreta \n";
            if (email.Length > 30)//o campo email pode ser vazio
                res = res + "Campo EMAIL: Excesso de caracteres \n";
            if (obs.Length > 100 || obs.Length == 0)
                res = res + "Campo observação excedeu 100 caracteres";
            if (res != null)
                res = "Erro nos campos: \n\n" + res;
            return res;
        }
        //validacao dos campos de cadastro de clientepj
        public string validaclientepj(string nome, string ie, string cnpj, string endereco, string bairro, string cidade,
            string complemento, string numero, string cep, string uf, string tel, string celular, string contato,
            string email, string obs)
        {
            //variaveis
            string res = null;
            //condicoes para as validacoes
            if (nome.Length > 30 || nome.Length == 0)//o campo nome nao pode ser vazio
                res = res + "Campo NOME: Máximo de Caracteres = 30 \n";
            if (ie.Length < 9)
                res = res + "Campo IE: Não é permitido campo em branco \n";
            if (cnpj.Length < 11)//devido ao componente maskTextBox ja inserir dados no banco de dados
                res = res + "Campo CNPJ: Não é permitido campo em branco \n";
            if (endereco.Length > 20 || endereco.Length == 0)
                res = res + "Campo ENDEREÇO: Excesso de caracteres \n";
            if (bairro.Length > 10 || bairro.Length == 0)
                res = res + "Campo BAIRRO: Excesso de caracteres \n";
            if (cidade.Length > 15 || cidade.Length == 0)
                res = res + "Campo CIDADE: Excessode caracteres \n";
            if (complemento.Length > 20 || complemento.Length == 0)
                res = res + "Campo Complemento: Excesso de caracteres \n";
            if (numero.Length > 5 || numero.Length == 0)
                res = res + "Campo NÚMERO: Excesso de caracteres \n";
            if (cep.Length > 8 || cep.Length == 0)
                res = res + "Campo Cep: Exxcesso de Caracteres";
            if (uf.Length > 2 || uf.Length == 0)
                res = res + "Campo UF: Excesso de caracteres \n";
            if (tel.Length < 10)
                res = res + "Campo TELEFONE: Não é permitido campo em branco \n";
            if (celular.Length < 11)
                res = res + "Campo Celular: Não é permitido campo em branco \n";
            if (contato.Length > 15 || contato.Length == 0)
                res = res + "Campo Contato Preenchido de forma incorreta \n";
            if (email.Length > 30)//o campo email pode ser vazio
                res = res + "Campo EMAIL: Excesso de caracteres \n";
            if (obs.Length > 100 || obs.Length == 0)
                res = res + "Campo observação excedeu 100 caracteres";
            if (res != null)
                res = "Erro nos campos: \n\n" + res;
            return res;
        }

    }
}
