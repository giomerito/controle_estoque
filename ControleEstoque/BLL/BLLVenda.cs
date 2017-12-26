using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLVenda
    {
        private DALConexao conexao;

        public BLLVenda(DALConexao cx) 
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloVenda modelo) 
        {
            if (modelo.VenNparcelas <= 0) 
            {
                throw new Exception("O número de parcelas deve ser maior do que zero");
            }

            if (modelo.CliCod <= 0) 
            {
                throw new Exception("O código do cliente deve ser informado");
            }

            if (modelo.VenTotal <= 0)
            {
                throw new Exception("O valor da venda deve ser informado");
            }

            if (modelo.VenNfiscal <= 0)
            {
                throw new Exception("O número da Nota Fiscal deve ser informado");
            }

            DALVenda DALobj = new DALVenda(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloVenda modelo)
        {
            if (modelo.VenNparcelas <= 0)
            {
                throw new Exception("O número de parcelas deve ser maior do que zero");
            }

            if (modelo.CliCod <= 0)
            {
                throw new Exception("O código do fornecedor deve ser informado");
            }

            if (modelo.VenTotal <= 0)
            {
                throw new Exception("O valor da venda deve ser informado");
            }

            if (modelo.VenNfiscal <= 0)
            {
                throw new Exception("O número da Nota Fiscal deve ser informado");
            }

            DALVenda DALobj = new DALVenda(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("O codigo da venda é obrigatório");
            }           

            DALVenda DALobj = new DALVenda(conexao);
            DALobj.Excluir(codigo);
        }

        public Boolean CancelarVenda(int codigo) 
        {
            if (codigo <= 0)
            {
                throw new Exception("O codigo da venda é obrigatório");
            }

            DALVenda DALobj = new DALVenda(conexao);
           return DALobj.CancelarVenda(codigo);
            
        }

        //localizar pelo código do cliente
        public DataTable LocalizarPorCodigo(int codigo)
        {
            DALVenda DALObj = new DALVenda(conexao);
            return DALObj.LocalizarPorCodigo(codigo);
        }

        public DataTable LocalizarPorNome(String nome) 
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.LocalizarPorNome(nome);
        }

        public DataTable LocalizarTudo()
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.LocalizarTudo();
        }

        public DataTable LocalizarParcelasEmAberto()
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.LocalizarPorParcelasEmAberto();
        }

        public int QuantidadeParcelasNaoPagas(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("O codigo da venda é obrigatório");
            }

            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.QuantidadeParcelasNaoPagas(codigo);
        }

        public DataTable LocalizarPorData(DateTime dtinicial, DateTime dtfinal) 
        {
            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.LocalizarPorData(dtinicial, dtfinal);
        }

        public ModeloVenda CarregaModeloVenda(int codigo) 
        {
            if (codigo <= 0)
            {
                throw new Exception("O codigo da venda é obrigatório");
            }

            DALVenda DALobj = new DALVenda(conexao);
            return DALobj.CarregaModeloVenda(codigo);
        }
    }
}
