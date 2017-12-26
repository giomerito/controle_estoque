using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloFornecedor
    {
        private int for_cod;
        private String for_nome;
        private String for_cnpj;
        private String for_ie;
        private String for_rsocial;
        private String for_tipo;       
        private String for_cep;
        private String for_endereco;
        private String for_bairro;
        private String for_fone;
        private String for_cel;
        private String for_email;
        private String for_endnumero;
        private String for_cidade;
        private String for_estado;

        public int ForCod
        {
            get { return this.for_cod; }
            set { this.for_cod = value; }
        }

        public String ForNome
        {
            get { return this.for_nome; }
            set { this.for_nome = value; }
        }

        public String ForCnpj
        {
            get { return this.for_cnpj; }
            set { this.for_cnpj = value; }
        }

        public String ForIe
        {
            get { return this.for_ie; }
            set { this.for_ie = value; }
        }

        public String ForRsocial
        {
            get { return for_rsocial; }
            set { for_rsocial = value; }
        }

        public String ForTipo
        {
            get { return for_tipo; }
            set { for_tipo = value; }
        }
       
        public String ForCep
        {
            get { return for_cep; }
            set { for_cep = value; }
        }
        

        public String ForEndereco
        {
            get { return for_endereco; }
            set { for_endereco = value; }
        }
        

        public String ForBairro
        {
            get { return for_bairro; }
            set { for_bairro = value; }
        }
       

        public String ForFone
        {
            get { return for_fone; }
            set { for_fone = value; }
        }
        

        public String ForCel
        {
            get { return for_cel; }
            set { for_cel = value; }
        }
        

        public String ForEmail
        {
            get { return for_email; }
            set { for_email = value; }
        }
        

        public String ForEndnumero
        {
            get { return for_endnumero; }
            set { for_endnumero = value; }
        }
       

        public String ForCidade
        {
            get { return for_cidade; }
            set { for_cidade = value; }
        }
       

        public String ForEstado
        {
            get { return for_estado; }
            set { for_estado = value; }
        }
               

        //Construtor sem parametros
        public ModeloFornecedor() 
        {
            this.ForNome = "";
            this.ForCnpj = "";
            this.ForIe = "";
            this.ForRsocial = "";
            this.ForTipo = "";
            this.ForCep = "";
            this.ForEndereco = "";
            this.ForBairro = "";
            this.ForFone = "";
            this.ForCel = "";
            this.ForEmail = "";
            this.ForEndnumero = "";
            this.ForCidade = "";
            this.ForEstado = "";
        }
        
        //Construtor com parametros
        public ModeloFornecedor(int for_cod, String for_nome, String for_cnpj, String for_rgie, String for_rsocial, 
            String for_tipo, String for_cep, String for_endereco, String for_bairro, String for_fone, String for_cel, String for_email, 
            String for_endnumero, String for_cidade, String for_estado)
        {
            this.ForCod = for_cod;
            this.ForNome = for_nome;
            this.ForCnpj = for_cnpj;
            this.ForIe = for_ie;
            this.ForRsocial = for_rsocial;
            this.ForTipo = for_tipo;
            this.ForCep = for_cep;
            this.ForEndereco = for_endereco;
            this.ForBairro = for_bairro;
            this.ForFone = for_fone;
            this.ForCel = for_cel;
            this.ForEmail = for_email;
            this.ForEndnumero = for_endnumero;
            this.ForCidade = for_cidade;
            this.ForEstado = for_estado;
        }
    }
}
