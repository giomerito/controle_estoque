using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALParcelasVenda
    {
        private DALConexao conexao;

        public DALParcelasVenda(DALConexao cx) 
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloParcelasVenda modelo) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "insert into parcelasvenda (pve_cod, pve_valor, ven_cod, pve_datavecto) values (@cod, @valor, @vencod, @datavecto)"; 
            cmd.Parameters.AddWithValue("@cod", modelo.PveCod);
            cmd.Parameters.AddWithValue("@valor", modelo.PveValor);
            cmd.Parameters.AddWithValue("@vencod", modelo.VenCod);

            cmd.Parameters.Add("@datavecto", System.Data.SqlDbType.Date);
            if (modelo.PveDataVecto == null)
            {
                cmd.Parameters["@datavecto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@datavecto"].Value = modelo.PveDataVecto;
            }
            

            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        public void Alterar(ModeloParcelasVenda modelo) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "update parcelasvenda set pve_valor = @valor, pve_datapagto = @datapagto, pve_datavecto = @datavecto "+
            "where pve_cod = @cod and ven_cod = @vencod)";
            cmd.Parameters.AddWithValue("@cod", modelo.PveCod);
            cmd.Parameters.AddWithValue("@valor", modelo.PveValor);           
            cmd.Parameters.AddWithValue("@vencod", modelo.VenCod);
            
            cmd.Parameters.Add("@datapagto", System.Data.SqlDbType.Date);            
            if (modelo.PveDataPagto == null)
            {
                cmd.Parameters["@datapagto"].Value = DBNull.Value;
            }
            else 
            {
                cmd.Parameters["@datapagto"].Value = modelo.PveDataPagto;
            }

            cmd.Parameters.Add("@datavecto", System.Data.SqlDbType.Date);
            cmd.Parameters["@datavecto"].Value = modelo.PveDataVecto;
            
            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        public void Excluir(ModeloParcelasVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "delete from parcelasvenda " +
            "where pve_cod = @cod and ven_cod = @vencod)";
            cmd.Parameters.AddWithValue("@cod", modelo.PveCod);            
            cmd.Parameters.AddWithValue("@vencod", modelo.VenCod);
            
            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        public void ExcluirTodasAsParcelas(int vencod)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "delete from parcelasvenda " +
            "where ven_cod = @vencod)";            
            cmd.Parameters.AddWithValue("@vencod", vencod);

            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        public DataTable Localizar(int vencod) 
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from parcelasvenda where ven_cod ="+vencod.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloParcelasVenda CarregaModeloParcelasVenda(int PveCod, int VenCod) 
        {
            ModeloParcelasVenda modelo = new ModeloParcelasVenda();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from parcelasvenda where pve_cod = @cod and ven_cod = @vencod";
            cmd.Parameters.AddWithValue("@cod", PveCod);
            cmd.Parameters.AddWithValue("@vencod", VenCod);
            
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if(registro.HasRows)
            {
                registro.Read();
                modelo.PveCod = PveCod;
                modelo.VenCod = VenCod;                
                modelo.PveValor = Convert.ToDouble(registro["pve_valor"]);
                modelo.PveDataVecto = Convert.ToDateTime(registro["pve_datavecto"]);
                modelo.PveDataPagto = Convert.ToDateTime(registro["pve_datapagto"]);
            }
            conexao.Desconectar();
            return modelo;
        }

    }
}
