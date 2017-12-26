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
    public class DALVenda
    {
        private DALConexao conexao;
        private SqlCommand cmd = new SqlCommand();
 
        public DALVenda(DALConexao cx) 
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloVenda modelo) 
        {            
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "insert into venda (ven_data, ven_nfiscal, ven_total, ven_nparcelas, ven_status, cli_cod, tpa_cod, ven_avista) "+
                "values (@data, @nfiscal, @total, @nparcelas, @status, @clicod, @tpacod, @venavista); select @@IDENTITY";

            //parametros
            cmd.Parameters.Add("@data", System.Data.SqlDbType.Date);
            cmd.Parameters["@data"].Value = modelo.VenData;

            cmd.Parameters.AddWithValue("@nfiscal", modelo.VenNfiscal);
            cmd.Parameters.AddWithValue("@total", modelo.VenTotal);
            cmd.Parameters.AddWithValue("@nparcelas", modelo.VenNparcelas);
            cmd.Parameters.AddWithValue("@status", modelo.VenStatus);
            cmd.Parameters.AddWithValue("@clicod", modelo.CliCod);
            cmd.Parameters.AddWithValue("@tpacod", modelo.TpaCod);
            cmd.Parameters.AddWithValue("@venavista", modelo.VenAvista);

            modelo.VenCod = Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void Alterar(ModeloVenda modelo) 
        {            
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "update venda set ven_data = @data, ven_nfiscal = @nfiscal, ven_total = @total, ven_nparcelas = @nparcelas, "+
                "ven_status = @status, cli_cod = @clicod, tpa_cod = @tpacod, ven_avista = @venavista "+
                "where ven_cod = @codigo";

            //parametros
            cmd.Parameters.Add("@data", System.Data.SqlDbType.Date);
            cmd.Parameters["@data"].Value = modelo.VenData;

            cmd.Parameters.AddWithValue("@nfiscal", modelo.VenNfiscal);
            cmd.Parameters.AddWithValue("@total", modelo.VenTotal);
            cmd.Parameters.AddWithValue("@nparcelas", modelo.VenNparcelas);
            cmd.Parameters.AddWithValue("@status", modelo.VenStatus);
            cmd.Parameters.AddWithValue("@clicod", modelo.CliCod);
            cmd.Parameters.AddWithValue("@tpacod", modelo.TpaCod);
            cmd.Parameters.AddWithValue("@venavista", modelo.VenAvista);
            cmd.Parameters.AddWithValue("@codigo", modelo.VenCod);

            cmd.ExecuteNonQuery();

        }

        public void Excluir(int codigo) 
        {
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "delete from venda where ven_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);

            cmd.ExecuteNonQuery();
        }

        //implementar cancelamento de venda
        public Boolean CancelarVenda(int codigo) 
        {
            Boolean retorno = true;

            //atualizar tabela venda
            cmd.Connection = conexao.ObjetoConexao;
            conexao.Conectar();
            conexao.IniciarTransacao();
            try
            {
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "update venda set ven_status = 'Cancelado' where ven_cod = @codigo";

                cmd.Parameters.AddWithValue("@codigo", codigo);

                cmd.ExecuteNonQuery();

                //substituir para o método do DALItensVenda
                //incrementar o estoque com os itens da venda cancelada            
                //localizar Itens da Venda
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select itv_cod, pro_cod, itv_qtde from itensvenda where ven_cod = " +
                codigo.ToString(), conexao.StringConexao);
                da.Fill(tabela);

                //alterar a quantidade do estoque
                ModeloProduto produto;
                DALProduto dalProduto = new DALProduto(conexao);
                DALProduto dalProduto1 = new DALProduto(conexao);

                //atualiza tabela de produto
                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    produto = dalProduto.CarregaModeloProduto(Convert.ToInt32(tabela.Rows[i]["pro_cod"]), true);
                    produto.ProQtde = produto.ProQtde + Convert.ToDouble(tabela.Rows[i]["itv_qtde"]);
                    dalProduto.Alterar(produto, true);
                }

                conexao.TerminarTrasacao();
                conexao.Desconectar();

            }
            catch 
            {
                conexao.CancelarTransacao();
                conexao.Desconectar();
                retorno = false;
            }

            return retorno;
            
        }

        public DataTable LocalizarPorCodigo(int codigo) 
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select v.ven_cod, v.ven_data, v.ven_nfiscal, v.ven_nparcelas, c.cli_nome, v.ven_status, v.cli_cod, v.tpa_cod, v.ven_avista, v.ven_total "+
            "from venda v inner join cliente c on v.cli_cod = c.cli_cod where c.cli_cod = " + codigo.ToString(), conexao.StringConexao);

            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorNome(String nome)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select v.ven_cod, v.ven_data, v.ven_nfiscal, v.ven_nparcelas, c.cli_nome, v.ven_status, v.cli_cod, v.tpa_cod, v.ven_avista, v.ven_total " +
            "from venda v inner join cliente c on v.cli_cod = c.cli_cod where c.cli_nome = like '%" + nome + "%'", conexao.StringConexao);

            da.Fill(tabela);
            return tabela;
        }
                
        public DataTable LocalizarTudo()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select v.ven_cod, v.ven_data, v.ven_nfiscal, v.ven_nparcelas, c.cli_nome, v.ven_status, v.cli_cod, v.tpa_cod, v.ven_avista, v.ven_total " +
            "from venda v inner join cliente c on v.cli_cod = c.cli_cod", conexao.StringConexao);

            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorParcelasEmAberto()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select distinct v.ven_cod, v.ven_data, v.ven_nfiscal, v.ven_nparcelas, c.cli_nome, v.ven_status, v.cli_cod, v.tpa_cod, v.ven_avista, v.ven_total " +
            "from venda v inner join cliente c on v.cli_cod = c.cli_cod "+ 
            "inner join parcelasvenda p on v.ven_cod = p.ven_cod "+
            "where p.pve_datapagto is null", conexao.StringConexao);

            da.Fill(tabela);
            return tabela;
        }

        public int QuantidadeParcelasNaoPagas(int codigo)
        {
            int qtde = 0;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            //cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "select count(ven_cod) from parcelasvenda where ven_cod = @vencod and pve_datapagto is NULL";
            cmd.Parameters.AddWithValue("@vencod", codigo);

            conexao.Conectar();
            qtde = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();

            return qtde;
        }

        public DataTable LocalizarPorData(DateTime inicial, DateTime final)
        {
            DataTable tabela = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "select v.ven_cod, v.ven_data, v.ven_nfiscal, v.ven_nparcelas, c.cli_nome, v.ven_status, v.cli_cod, v.tpa_cod, v.ven_avista, v.ven_total " +
            "from venda v inner join cliente c on v.cli_cod = c.cli_cod " +
            "where v.ven_data BETWEEN @dtinicial and @dtfinal";

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

        public ModeloVenda CarregaModeloVenda(int codigo)
        {
            ModeloVenda modelo = new ModeloVenda();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            //cmd.Transaction = conexao.ObjetoTransacao; 
            cmd.CommandText = "select * from venda where ven_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);

            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.VenCod = Convert.ToInt32(registro["ven_cod"]);
                modelo.VenData = Convert.ToDateTime(registro["ven_data"]);
                modelo.VenNfiscal = Convert.ToInt32(registro["ven_nfiscal"]);
                modelo.VenTotal = Convert.ToDouble(registro["ven_total"]);
                modelo.VenNparcelas = Convert.ToInt32(registro["ven_nparcelas"]);
                modelo.VenStatus = Convert.ToString(registro["ven_status"]);
                modelo.CliCod = Convert.ToInt32(registro["cli_cod"]);
                modelo.TpaCod = Convert.ToInt32(registro["tpa_cod"]);
                modelo.VenAvista = Convert.ToInt32(registro["ven_avista"]);

            }
            conexao.Desconectar();
            return modelo;
        }

    }
}
