using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCompra
    {
         private DALConexao conexao;

        public BLLCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCompra modelo)
        {
            if (modelo.ComTotal <= 0)
            {
                throw new Exception("O valor da compra deve ser informado");
            }

            if (modelo.ForCod <= 0)
            {
                throw new Exception("O código do fornecedor deve ser informado");
            }

            if (modelo.ComNparcelas <= 0)
            {
                throw new Exception("O número de parcelas deve ser maior do que zero");
            }

            //if (modelo.ComData != DateTime.Now)
            //{
            //    throw new Exception("O data da compra não correspode a data atual");
            //}
            

            DALCompra DALobj = new DALCompra(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código do fornecedor deve ser maior que zero");
            }

            if (modelo.ComTotal <= 0)
            {
                throw new Exception("O valor da compra deve ser informado");
            }

            if (modelo.ForCod <= 0)
            {
                throw new Exception("O código do fornecedor deve ser informado");
            }

            if (modelo.ComNparcelas <= 0)
            {
                throw new Exception("O número de parcelas deve ser maior do que zero");
            }

            //if (modelo.ComData != DateTime.Now)
            //{
            //    throw new Exception("O data da compra não correspode a data atual");
            //}


            DALCompra DALobj = new DALCompra(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCompra DALobj = new DALCompra(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable LocalizarPorCodigo(int codigo)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.LocalizarPorCodigo(codigo);
        }

        public DataTable LocalizarPorNome(String nome)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.LocalizarPorNome(nome);
        }

        public DataTable Localizar()
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.Localizar();
        }

        public DataTable LocalizarPorParcelasAberto()
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.LocalizarPorParcelasAberto();
        }

        public int QuantidadeParcelasNaoPagas(int codigo) 
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.QuantidadeParcelasNaoPagas(codigo);
        }

        public DataTable LocalizarPorData(DateTime inicial, DateTime final)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.LocalizarPorData(inicial, final);
        }

        public ModeloCompra CarregaModeloCompra(int codigo)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.CarregaModeloCompra(codigo);
        }
    }
}
