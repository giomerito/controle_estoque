using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;
using System.Data;

namespace BLL
{
    public class BLLParcelasVenda
    {
        private DALConexao conexao;

        public BLLParcelasVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloParcelasVenda modelo)
        {
            if (modelo.PveCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }
            if (modelo.PveValor <= 0)
            {
                throw new Exception("O valor da parcela é obrigatório");
            }
            DateTime data = DateTime.Now;
            if (modelo.PveDataVecto.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferior ao ano atual");
            }

            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloParcelasVenda modelo)
        {
            if (modelo.PveCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }
            if (modelo.PveValor <= 0)
            {
                throw new Exception("O valor da parcela é obrigatório");
            }
            DateTime data = DateTime.Now;
            if (modelo.PveDataVecto.Year < data.Year)
            {
                throw new Exception("Ano de vencimento inferior ao ano atual");
            }

            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }

            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(ModeloParcelasVenda modelo)
        {
            if (modelo.PveCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório");
            }

            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            DALobj.Excluir(modelo);
        }

        public void ExcluirTodasAsParcelas(int vencod)
        {           
            if (vencod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }

            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            DALobj.ExcluirTodasAsParcelas(vencod);
        }

        public DataTable Localizar(int vencod)
        {
            if (vencod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }

            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            return DALobj.Localizar(vencod);
        }

        public ModeloParcelasVenda CarregaModeloParcelasVenda(int PveCod, int VenCod)
        {
            if (PveCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório");
            }
            if (VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório");
            }

            DALParcelasVenda DALobj = new DALParcelasVenda(conexao);
            return DALobj.CarregaModeloParcelasVenda(PveCod, VenCod);
        }
    }
}
