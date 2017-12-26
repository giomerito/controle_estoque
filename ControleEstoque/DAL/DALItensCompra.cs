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
    public class DALItensCompra
    {
        private DALConexao conexao;

        public DALItensCompra(DALConexao cx) 
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloItensCompra modelo) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "insert into itenscompra (itc_cod, itc_qtde, itc_valor, com_cod, pro_cod) values (@cod, @qtde, @valor, @comcod, @procod)"; 
            cmd.Parameters.AddWithValue("@cod", modelo.ItcCod);
            cmd.Parameters.AddWithValue("@qtde", modelo.ItcQtde);
            cmd.Parameters.AddWithValue("@valor", modelo.ItcValor);
            cmd.Parameters.AddWithValue("@comcod", modelo.ComCod);
            cmd.Parameters.AddWithValue("@procod", modelo.ProCod);

            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        public void Alterar(ModeloItensCompra modelo) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "update itenscompra set itc_qtde = @qtde, itc_valor = @valor, "+
            "where itc_cod = @cod and com_cod = @comcod and pro_cod = @procod)";
            cmd.Parameters.AddWithValue("@cod", modelo.ItcCod);
            cmd.Parameters.AddWithValue("@qtde", modelo.ItcQtde);
            cmd.Parameters.AddWithValue("@valor", modelo.ItcValor);
            cmd.Parameters.AddWithValue("@comcod", modelo.ComCod);
            cmd.Parameters.AddWithValue("@procod", modelo.ProCod);

            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        public void Excluir(ModeloItensCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "delete from itenscompra " +
            "where itc_cod = @cod and com_cod = @comcod and pro_cod = @procod";
            cmd.Parameters.AddWithValue("@cod", modelo.ItcCod);            
            cmd.Parameters.AddWithValue("@comcod", modelo.ComCod);
            cmd.Parameters.AddWithValue("@procod", modelo.ProCod);

            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        public void ExcluirTodosOsItens(int comcod)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "delete from itenscompra " +
            "where com_cod = @comcod";
            cmd.Parameters.AddWithValue("@comcod", comcod);
     

            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }

        public DataTable Localizar(int comcod) 
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select  i.com_cod, i.itc_cod, i.pro_cod, p.pro_nome, i.itc_qtde, i.itc_valor " +
            "from itenscompra i inner join produto p on p.pro_cod = i.pro_cod "+ 
            "where i.com_cod ="+comcod.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloItensCompra CarregaModeloItensCompra(int ItcCod, int ComCod, int ProCod) 
        {
            ModeloItensCompra modelo = new ModeloItensCompra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            //cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "select * from itenscompra where itc_cod = @cod and com_cod = @comcod and pro_cod = @procod";
            cmd.Parameters.AddWithValue("@cod", ItcCod);
            cmd.Parameters.AddWithValue("@comcod", ComCod);
            cmd.Parameters.AddWithValue("@procod", ProCod);

            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if(registro.HasRows)
            {
                registro.Read();
                modelo.ItcCod = ItcCod;
                modelo.ComCod = ComCod;
                modelo.ProCod = ProCod;
                modelo.ItcQtde = Convert.ToDouble(registro["itc_qtde"]);
                modelo.ItcValor = Convert.ToDouble(registro["itc_valor"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
