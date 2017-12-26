using DAL;
using Ferramentas;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLFornecedor
    {
        private DALConexao conexao;

        public BLLFornecedor(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFornecedor modelo) 
        {
            if (modelo.ForNome.Trim().Length == 0) 
            {
                throw new Exception("O nome do fornecedor é obrigatório");
            }
            if (modelo.ForCnpj.Trim().Length == 0)
            {
                throw new Exception("O Cnpj do fornecedor é obrigatório");
            }
                         
                //cnpj
                if (Validacao.IsCnpj(modelo.ForCnpj) == false)
                {
                    throw new Exception("O CNPJ é inválido");
                }
                                    
            

            if (modelo.ForIe.Trim().Length == 0)
            {
                throw new Exception("A Insc Estadual do cliente é obrigatório");
            }

           

            if (modelo.ForFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do fornecedor é obrigatório");
            }
                       
            //**********VALIDAÇÃO PARA EMAIL*****
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9}{1,3}" +
                "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\" +
                ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if(!re.IsMatch(modelo.ForEmail))
            {
                throw new Exception("Digite um email válido.");
            }
            //fim da validação do email

            
            DALFornecedor DALobj = new DALFornecedor(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloFornecedor modelo) 
        {
            if (modelo.ForNome.Trim().Length == 0)
            {
                throw new Exception("O nome do fornecedor é obrigatório");
            }
            if (modelo.ForCnpj.Trim().Length == 0)
            {
                throw new Exception("O Cnpj do fornecedor é obrigatório");
            }

            //cnpj
            if (Validacao.IsCnpj(modelo.ForCnpj) == false)
            {
                throw new Exception("O CNPJ é inválido");
            }

            if (modelo.ForIe.Trim().Length == 0)
            {
                throw new Exception("A Insc Estadual do cliente é obrigatório");
            }

            if (modelo.ForFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do fornecedor é obrigatório");
            }

            //**********VALIDAÇÃO PARA EMAIL*****
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9}{1,3}" +
                "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\" +
                ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.ForEmail))
            {
                throw new Exception("Digite um email válido.");
            }
            //fim da validação do email


            DALFornecedor DALobj = new DALFornecedor(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo) 
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor) 
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.Localizar(valor);
        }

        public DataTable LocalizarPorNome(String valor)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.LocalizarPorNome(valor);
        }

        public DataTable LocalizarPorCNPJ(String valor)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.LocalizarPorCNPJ(valor);
        }

        public ModeloFornecedor CarregaModeloFornecedor(int codigo) 
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.CarregaModeloFornecedor(codigo);
        }

        public ModeloFornecedor CarregaModeloFornecedor(string cnpj)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.CarregaModeloFornecedor(cnpj);
        }

    }
}
