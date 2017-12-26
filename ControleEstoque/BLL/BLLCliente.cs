using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;
using System.Data;
using Ferramentas;
using System.Text.RegularExpressions;

namespace BLL
{
    public class BLLCliente
    {
        private DALConexao conexao;

        public BLLCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCliente modelo) 
        {
            if (modelo.CliNome.Trim().Length == 0) 
            {
                throw new Exception("O nome do cliente é obrigatório");
            }
            if (modelo.CliCpfCnpj.Trim().Length == 0)
            {
                throw new Exception("O CPF ou Cnpj do cliente é obrigatório");
            }

             //validação CPF e CNPJ
            if (modelo.CliTipo == "Fisica")
            {
                //cpf
                if (Validacao.IsCpf(modelo.CliCpfCnpj) == false)
                {
                    throw new Exception("O CPF é inválido");
                }
            }
            else
            {
                //cnpj
                if (Validacao.IsCnpj(modelo.CliCpfCnpj) == false)
                {
                    throw new Exception("O CNPJ é inválido");
                }
            }

                        
            //verificar Rg / Ie

            if (modelo.CliRgIe.Trim().Length == 0)
            {
                throw new Exception("O Rg ou Insc Estadual do cliente é obrigatório");
            }

            //Tipo = 0 -> fisica
            //Tipo = 1 -> juridica

            /*
            if (modelo.CliTipo <= 0)
            {
                throw new Exception("O tipo do cliente é obrigatório");
            }
            if (modelo.CliCep.Trim().Length == 0)
            {
                throw new Exception("O Cep do cliente é obrigatório");
            }
            if (modelo.CliEndereco.Trim().Length == 0)
            {
                throw new Exception("O endereço do cliente é obrigatório");
            }
            if (modelo.CliBairro.Trim().Length == 0)
            {
                throw new Exception("O bairro do cliente é obrigatório");
            }
            if (modelo.CliEndnumero.Trim().Length == 0)
            {
                throw new Exception("O numero do endereço do cliente é obrigatório");
            }
             */

            if (modelo.CliFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do cliente é obrigatório");
            }

            /*
            if (modelo.CliCel.Trim().Length == 0)
            {
                throw new Exception("O celular do cliente é obrigatório");
            }
            if (modelo.CliEmail.Trim().Length == 0)
            {
                throw new Exception("O email do cliente é obrigatório");
            }
            if (modelo.CliCidade.Trim().Length == 0)
            {
                throw new Exception("A cidade do cliente é obrigatório");
            }
            if (modelo.CliEstado.Trim().Length == 0)
            {
                throw new Exception("O Estado do cliente é obrigatório");
            }
            */

            //**********VALIDAÇÃO PARA EMAIL*****
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9}{1,3}" +
                "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\" +
                ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if(!re.IsMatch(modelo.CliEmail))
            {
                throw new Exception("Digite um email válido.");
            }
            //fim da validação do email

            //valida CEP
            //if (Validacao.ValidaCep(modelo.CliCep) == false)
            //{
            //    throw new Exception("O CEP é inválido");
            //}

            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloCliente modelo) 
        {
            if (modelo.CliNome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }
            if (modelo.CliCpfCnpj.Trim().Length == 0)
            {
                throw new Exception("O CPF ou Cnpj do cliente é obrigatório");
            }

            //verificar cpf / cnpj

            if (modelo.CliRgIe.Trim().Length == 0)
            {
                throw new Exception("O Rg ou Insc Estadual do cliente é obrigatório");
            }

            //Tipo = 0 -> fisica
            //Tipo = 1 -> juridica

            /*
            if (modelo.CliTipo <= 0)
            {
                throw new Exception("O tipo do cliente é obrigatório");
            }
            if (modelo.CliCep.Trim().Length == 0)
            {
                throw new Exception("O Cep do cliente é obrigatório");
            }
            if (modelo.CliEndereco.Trim().Length == 0)
            {
                throw new Exception("O endereço do cliente é obrigatório");
            }
            if (modelo.CliBairro.Trim().Length == 0)
            {
                throw new Exception("O bairro do cliente é obrigatório");
            }
            if (modelo.CliEndnumero.Trim().Length == 0)
            {
                throw new Exception("O numero do endereço do cliente é obrigatório");
            }
             */

            if (modelo.CliFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do cliente é obrigatório");
            }

            /*
            if (modelo.CliCel.Trim().Length == 0)
            {
                throw new Exception("O celular do cliente é obrigatório");
            }
            if (modelo.CliEmail.Trim().Length == 0)
            {
                throw new Exception("O email do cliente é obrigatório");
            }
            if (modelo.CliCidade.Trim().Length == 0)
            {
                throw new Exception("A cidade do cliente é obrigatório");
            }
            if (modelo.CliEstado.Trim().Length == 0)
            {
                throw new Exception("O Estado do cliente é obrigatório");
            }
            */

            //**********VALIDAÇÃO PARA EMAIL*****
            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9}{1,3}" +
                "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\" +
                ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if (!re.IsMatch(modelo.CliEmail))
            {
                throw new Exception("Digite um email válido.");
            }
            //fim da validação do email

            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo) 
        {
            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor) 
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.Localizar(valor);
        }

        public DataTable LocalizarPorNome(String valor)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.LocalizarPorNome(valor);
        }

        public DataTable LocalizarPorCPFCNPJ(String valor)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.LocalizarPorCPFCNPJ(valor);
        }

        public ModeloCliente CarregaModeloCliente(int codigo) 
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.CarregaModeloCliente(codigo);
        }

        public ModeloCliente CarregaModeloCliente(string cpfcnpj)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.CarregaModeloCliente(cpfcnpj);
        }

    }
}
