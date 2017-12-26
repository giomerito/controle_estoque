using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCliente
    {
        private int cli_cod;
        private String cli_nome;
        private String cli_cpfcnpj;
        private String cli_rgie;
        private String cli_rsocial;
        private String cli_tipo;
        private String cli_cep;
        private String cli_endereco;
        private String cli_bairro;
        private String cli_fone;
        private String cli_cel;
        private String cli_email;
        private String cli_endnumero;
        private String cli_cidade;
        private String cli_estado;

        public int CliCod
        {
            get { return this.cli_cod; }
            set { this.cli_cod = value; }
        }

        public String CliNome
        {
            get { return this.cli_nome; }
            set { this.cli_nome = value; }
        }

        public String CliCpfCnpj
        {
            get { return this.cli_cpfcnpj; }
            set { this.cli_cpfcnpj = value; }
        }

        public String CliRgIe
        {
            get { return this.cli_rgie; }
            set { this.cli_rgie = value; }
        }

        public String CliRsocial
        {
            get { return cli_rsocial; }
            set { cli_rsocial = value; }
        }

        public String CliTipo
        {
            get { return cli_tipo; }
            set { cli_tipo = value; }
        }
        

        public String CliCep
        {
            get { return cli_cep; }
            set { cli_cep = value; }
        }
        

        public String CliEndereco
        {
            get { return cli_endereco; }
            set { cli_endereco = value; }
        }
        

        public String CliBairro
        {
            get { return cli_bairro; }
            set { cli_bairro = value; }
        }
       

        public String CliFone
        {
            get { return cli_fone; }
            set { cli_fone = value; }
        }
        

        public String CliCel
        {
            get { return cli_cel; }
            set { cli_cel = value; }
        }
        

        public String CliEmail
        {
            get { return cli_email; }
            set { cli_email = value; }
        }
        

        public String CliEndnumero
        {
            get { return cli_endnumero; }
            set { cli_endnumero = value; }
        }
       

        public String CliCidade
        {
            get { return cli_cidade; }
            set { cli_cidade = value; }
        }
       

        public String CliEstado
        {
            get { return cli_estado; }
            set { cli_estado = value; }
        }

       

        //Construtor sem parametros
        public ModeloCliente() 
        {
            this.CliCod = 0;
            this.CliNome = "";
            this.CliCpfCnpj = "";
            this.CliRgIe = "";
            this.CliRsocial = "";
            this.CliTipo = "Fisica";
            this.CliCep = "";
            this.CliEndereco = "";
            this.CliBairro = "";
            this.CliFone = "";
            this.CliCel = "";
            this.CliEmail = "";
            this.CliEndnumero = "";
            this.CliCidade = "";
            this.CliEstado = "";
        }
        
        //Construtor com parametros
        public ModeloCliente(int cli_cod, String cli_nome, String cli_cpfcnpj, String cli_rgie, String cli_rsocial, 
            String cli_tipo, String cli_cep, String cli_endereco, String cli_bairro, String cli_fone, String cli_cel, String cli_email, 
            String cli_endnumero, String cli_cidade, String cli_estado)
        {
            this.CliCod = cli_cod;
            this.CliNome = cli_nome;
            this.CliCpfCnpj = cli_cpfcnpj;
            this.CliRgIe = cli_rgie;
            this.CliRsocial = cli_rsocial;
            this.CliTipo = cli_tipo;
            this.CliCep = cli_cep;
            this.CliEndereco = cli_endereco;
            this.CliBairro = cli_bairro;
            this.CliFone = cli_fone;
            this.CliCel = cli_cel;
            this.CliEmail = cli_email;
            this.CliEndnumero = cli_endnumero;
            this.CliCidade = cli_cidade;
            this.CliEstado = cli_estado;
        }
    }
}
