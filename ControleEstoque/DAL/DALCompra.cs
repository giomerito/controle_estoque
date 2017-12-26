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
    public class DALCompra
    {
        private DALConexao conexao;

        public DALCompra(DALConexao cx) 
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCompra modelo) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "insert into compra (com_data, com_nfiscal, com_total, com_nparcelas, com_status, for_cod, tpa_cod) values (@data, @nfiscal, @total, @nparcelas, @status, @forcod, @tpacod); select @@IDENTITY;";
            
            //quando o valor for uma data 
            cmd.Parameters.Add("@data", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@data"].Value = modelo.ComData;
            //para dados primitivos
            cmd.Parameters.AddWithValue("@nfiscal", modelo.ComNfiscal);
            cmd.Parameters.AddWithValue("@total", modelo.ComTotal);
            cmd.Parameters.AddWithValue("@nparcelas", modelo.ComNparcelas);
            cmd.Parameters.AddWithValue("@status", modelo.ComStatus);
            cmd.Parameters.AddWithValue("@forcod", modelo.ForCod);
            cmd.Parameters.AddWithValue("@tpacod", modelo.TpaCod);


            //conexao.Conectar();
            modelo.ComCod = Convert.ToInt32(cmd.ExecuteScalar());
            //conexao.Desconectar();
        }

        public void Alterar(ModeloCompra modelo) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "update compra set com_data = @data, com_nfiscal = @nfiscal, com_total = @total, com_nparcelas = @nparcelas, com_status = @status, for_cod = @forcod, tpa_cod = @tpacod where com_cod = @codigo";

            //quando o valor for uma data 
            cmd.Parameters.Add("@data", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@data"].Value = modelo.ComData;
            //para dados primitivos
            cmd.Parameters.AddWithValue("@nfiscal", modelo.ComNfiscal);
            cmd.Parameters.AddWithValue("@total", modelo.ComTotal);
            cmd.Parameters.AddWithValue("@nparcelas", modelo.ComNparcelas);
            cmd.Parameters.AddWithValue("@status", modelo.ComStatus);
            cmd.Parameters.AddWithValue("@forcod", modelo.ForCod);
            cmd.Parameters.AddWithValue("@tpacod", modelo.TpaCod);
            cmd.Parameters.AddWithValue("@codigo", modelo.ComCod);

            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "delete from compra where com_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);

            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        /*
        public void ExcluirTodasAsParcelas(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from compra where com_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
         */
        
        //localizar pelo código do fornecedor
        public DataTable LocalizarPorCodigo(int codigo) 
        {
            DataTable tabela = new DataTable();            
            SqlDataAdapter da = new SqlDataAdapter("select c.com_cod, c.com_data, c.com_nfiscal, c.com_nparcelas, c.com_total, c.com_status, c.for_cod, c.tpa_cod, f.for_nome from compra c inner join fornecedor f on c.for_cod = f.for_cod " +
           "where f.for_cod =" +codigo.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //localizar por nome do fornecedor
        public DataTable LocalizarPorNome(String nome)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select c.com_cod, c.com_data, c.com_nfiscal, c.com_nparcelas, c.com_total, c.com_status, c.for_cod, c.tpa_cod, f.for_nome from compra c inner join fornecedor f on c.for_cod = f.for_cod "+
            "where f.for_nome = like '%" + nome + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //localizar por data
        public DataTable LocalizarPorData(DateTime inicial, DateTime final)
        {
            DataTable tabela = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "select c.com_cod, c.com_data, c.com_nfiscal, c.com_nparcelas, c.com_total, c.com_status, c.for_cod, c.tpa_cod, f.for_nome " +
            "from compra c inner join fornecedor f on c.for_cod = f.for_cod " +
            "where c.com_data BETWEEN @dtinicial and @dtfinal";

            cmd.Parameters.Add("@dtinicial", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@dtinicial"].Value = inicial;

            cmd.Parameters.Add("@dtfinal", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@dtfinal"].Value = final;

            //conexao.Conectar();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabela);
            return tabela;

            //conexao.Desconectar();
        }

        //localizar  
        public DataTable LocalizarPorParcelasAberto()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select distinct c.com_cod, c.com_data, c.com_nfiscal, c.com_nparcelas, c.com_total, c.com_status, c.for_cod, c.tpa_cod, f.for_nome "+ 
            "from compra c inner join fornecedor f on c.for_cod = f.for_cod inner join parcelascompra p on c.com_cod = p.com_cod "+
            "where p.pco_datapagto is null", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public int QuantidadeParcelasNaoPagas(int codigo) 
        {
            int qtde = 0;           

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            //cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "select count(com_cod) from parcelascompra where com_cod = @comcod and pco_datapagto is NULL";
            cmd.Parameters.AddWithValue("@comcod", codigo);

            conexao.Conectar();
            qtde = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();

            return qtde;
        }

        //localizar todas as compras pelo nome do fornecedor 
        public DataTable Localizar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select c.com_cod, c.com_data, c.com_nfiscal, c.com_nparcelas, c.com_total, c.com_status, c.for_cod, c.tpa_cod, f.for_nome from compra c inner join fornecedor f on c.for_cod = f.for_cod ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloCompra CarregaModeloCompra(int codigo) 
        {
            ModeloCompra modelo = new ModeloCompra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            //cmd.Transaction = conexao.ObjetoTransacao; 
            cmd.CommandText = "select * from compra where com_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);

            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if(registro.HasRows)
            {
                registro.Read();
                modelo.ComCod = Convert.ToInt32(registro["com_cod"]);
                modelo.ComData = Convert.ToDateTime(registro["com_data"]);
                modelo.ComNfiscal = Convert.ToInt32(registro["com_nfiscal"]);
                modelo.ComTotal = Convert.ToDouble(registro["com_total"]);
                modelo.ComNparcelas = Convert.ToInt32(registro["com_nparcelas"]);
                modelo.ComStatus = Convert.ToString(registro["com_status"]);
                modelo.ForCod = Convert.ToInt32(registro["for_cod"]);
                modelo.TpaCod = Convert.ToInt32(registro["tpa_cod"]);

            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
