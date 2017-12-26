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
    public class DALItensVenda
    {
        private DALConexao conexao;

        public DALItensVenda(DALConexao cx) 
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloItensVenda modelo) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "insert into itensvenda (itv_cod, itv_qtde, itv_valor, ven_cod, pro_cod) values (@cod, @qtde, @valor, @vencod, @procod)"; 
            cmd.Parameters.AddWithValue("@cod", modelo.ItvCod);
            cmd.Parameters.AddWithValue("@qtde", modelo.ItvQtde);
            cmd.Parameters.AddWithValue("@valor", modelo.ItvValor);
            cmd.Parameters.AddWithValue("@vencod", modelo.VenCod);
            cmd.Parameters.AddWithValue("@procod", modelo.ProCod);

            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        public void Alterar(ModeloItensVenda modelo) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "update itensvenda set itv_qtde = @qtde, itv_valor = @valor, "+
            "where itv_cod = @cod and ven_cod = @vencod and pro_cod = @procod)";
            cmd.Parameters.AddWithValue("@cod", modelo.ItvCod);
            cmd.Parameters.AddWithValue("@qtde", modelo.ItvQtde);
            cmd.Parameters.AddWithValue("@valor", modelo.ItvValor);
            cmd.Parameters.AddWithValue("@vencod", modelo.VenCod);
            cmd.Parameters.AddWithValue("@procod", modelo.ProCod);

            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        public void Excluir(ModeloItensVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "delete from itensvenda " +
            "where itv_cod = @cod and ven_cod = @vencod and pro_cod = @procod";
            cmd.Parameters.AddWithValue("@cod", modelo.ItvCod);            
            cmd.Parameters.AddWithValue("@vencod", modelo.VenCod);
            cmd.Parameters.AddWithValue("@procod", modelo.ProCod);

            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        public void ExcluirTodosOsItens(int vencod)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "delete from itensvenda " +
            "where ven_cod = @vencod";
            cmd.Parameters.AddWithValue("@vencod", vencod);
     

            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        public DataTable Localizar(int vencod) 
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select  i.ven_cod, i.itv_cod, i.pro_cod, p.pro_nome, i.itv_qtde, i.itv_valor " +
            "from itensvenda i inner join produto p on p.pro_cod = i.pro_cod "+ 
            "where i.ven_cod ="+vencod.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloItensVenda CarregaModeloItensVenda(int ItvCod, int VenCod, int ProCod) 
        {
            ModeloItensVenda modelo = new ModeloItensVenda();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            //cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "select * from itensvenda where itv_cod = @cod and ven_cod = @vencod and pro_cod = @procod";
            cmd.Parameters.AddWithValue("@cod", ItvCod);
            cmd.Parameters.AddWithValue("@vencod", VenCod);
            cmd.Parameters.AddWithValue("@procod", ProCod);

            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if(registro.HasRows)
            {
                registro.Read();
                modelo.ItvCod = ItvCod;
                modelo.VenCod = VenCod;
                modelo.ProCod = ProCod;
                modelo.ItvQtde = Convert.ToDouble(registro["itv_qtde"]);
                modelo.ItvValor = Convert.ToDouble(registro["itv_valor"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
