using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DALParcelasCompra
    {
        private DALConexao conexao;

        public DALParcelasCompra(DALConexao cx) 
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloParcelasCompra modelo) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "insert into parcelascompra (pco_cod, pco_valor, com_cod, pco_datavecto) values (@cod, @valor, @comcod, @datavecto)"; 
            cmd.Parameters.AddWithValue("@cod", modelo.PcoCod);
            cmd.Parameters.AddWithValue("@valor", modelo.PcoValor);
            cmd.Parameters.AddWithValue("@comcod", modelo.ComCod);

            cmd.Parameters.Add("@datavecto", System.Data.SqlDbType.Date);
            if (modelo.PcoDataVecto == null)
            {
                cmd.Parameters["@datavecto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@datavecto"].Value = modelo.PcoDataVecto;
            }            

            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        public void EfetuaPagamentoParcela(int pcoCod, int comCod, DateTime pcoDatapagto) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update parcelascompra set pco_datapagto = @datapagto where com_cod = @comcod and pco_cod = @cod";

            cmd.Parameters.Add("@datapagto", System.Data.SqlDbType.Date);
            cmd.Parameters["@datapagto"].Value = pcoDatapagto;
            cmd.Parameters.AddWithValue("@comcod", comCod);
            cmd.Parameters.AddWithValue("@cod", pcoCod);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Alterar(ModeloParcelasCompra modelo) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "update parcelascompra set pco_valor = @valor, pco_datapagto = @datapagto, pco_datavecto = @datavecto "+
            "where pco_cod = @cod and com_cod = @comcod)";
            cmd.Parameters.AddWithValue("@cod", modelo.PcoCod);
            cmd.Parameters.AddWithValue("@valor", modelo.PcoValor);           
            cmd.Parameters.AddWithValue("@comcod", modelo.ComCod);
            
            cmd.Parameters.Add("@datapagto", System.Data.SqlDbType.Date);            
            if (modelo.PcoDataPagto == null)
            {
                cmd.Parameters["@datapagto"].Value = DBNull.Value;
            }
            else 
            {
                cmd.Parameters["@datapagto"].Value = modelo.PcoDataPagto;
            }

            cmd.Parameters.Add("@datavecto", System.Data.SqlDbType.Date);
            cmd.Parameters["@datavecto"].Value = modelo.PcoDataVecto;
            
            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        public void Excluir(ModeloParcelasCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "delete from parcelascompra " +
            "where pco_cod = @cod and com_cod = @comcod";
            cmd.Parameters.AddWithValue("@cod", modelo.PcoCod);            
            cmd.Parameters.AddWithValue("@comcod", modelo.ComCod);
            
            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        public void ExcluirTodasAsParcelas(int comcod)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "delete from parcelascompra where com_cod = @comcod";            
            cmd.Parameters.AddWithValue("@comcod", comcod);

            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        public DataTable Localizar(int comcod) 
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from parcelascompra where com_cod ="+comcod.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloParcelasCompra CarregaModeloParcelasCompra(int PcoCod, int ComCod) 
        {
            ModeloParcelasCompra modelo = new ModeloParcelasCompra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            //cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "select * from parcelascompra where pco_cod = @cod and com_cod = @comcod";
            cmd.Parameters.AddWithValue("@cod", PcoCod);
            cmd.Parameters.AddWithValue("@comcod", ComCod);
            
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if(registro.HasRows)
            {
                registro.Read();
                modelo.PcoCod = PcoCod;
                modelo.ComCod = ComCod;                
                modelo.PcoValor = Convert.ToDouble(registro["pco_valor"]);
                modelo.PcoDataVecto = Convert.ToDateTime(registro["pco_datavecto"]);
                modelo.PcoDataPagto = Convert.ToDateTime(registro["pco_datapagto"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
