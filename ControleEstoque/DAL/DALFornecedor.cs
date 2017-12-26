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
    public class DALFornecedor
    {
        private DALConexao conexao;

        public DALFornecedor(DALConexao cx) 
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFornecedor modelo) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into fornecedor (for_nome, for_cnpj, for_ie, for_rsocial, for_cep, for_endereco, for_bairro, for_fone, for_cel, for_email, for_endnumero, for_cidade, for_estado) "+ 
                              "values(@nome, @cnpj, @ie, @rsocial, @cep, @endereco, @bairro, @fone, @cel, @email, @numero, @cidade, @estado) select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.ForNome);
            cmd.Parameters.AddWithValue("@cnpj", modelo.ForCnpj);
            cmd.Parameters.AddWithValue("@ie", modelo.ForIe);
            cmd.Parameters.AddWithValue("@rsocial", modelo.ForRsocial);            
            cmd.Parameters.AddWithValue("@cep", modelo.ForCep);
            cmd.Parameters.AddWithValue("@endereco", modelo.ForEndereco);
            cmd.Parameters.AddWithValue("@bairro", modelo.ForBairro);
            cmd.Parameters.AddWithValue("@fone", modelo.ForFone);
            cmd.Parameters.AddWithValue("@cel", modelo.ForCel);
            cmd.Parameters.AddWithValue("@email", modelo.ForEmail);
            cmd.Parameters.AddWithValue("@numero", modelo.ForEndnumero);
            cmd.Parameters.AddWithValue("@cidade", modelo.ForCidade);
            cmd.Parameters.AddWithValue("@estado", modelo.ForEstado);

            conexao.Conectar();
            modelo.ForCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
            
        }

        public void Alterar(ModeloFornecedor modelo) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update fornecedor set for_nome = @nome, for_cnpj = @cnpj, for_ie = @ie, for_rsocial = @rsocial, "+ 
                "for_cep = @cep, for_endereco = @endereco, for_bairro = @bairro, for_fone = @fone, for_cel = @cel, for_email = @email, for_endnumero = @numero, "+
                "for_cidade = @cidade, for_estado = @estado where for_cod = @codigo";
            cmd.Parameters.AddWithValue("@nome", modelo.ForNome);
            cmd.Parameters.AddWithValue("@cnpj", modelo.ForCnpj);
            cmd.Parameters.AddWithValue("@ie", modelo.ForIe);
            cmd.Parameters.AddWithValue("@rsocial", modelo.ForRsocial);            
            cmd.Parameters.AddWithValue("@cep", modelo.ForCep);
            cmd.Parameters.AddWithValue("@endereco", modelo.ForEndereco);
            cmd.Parameters.AddWithValue("@bairro", modelo.ForBairro);
            cmd.Parameters.AddWithValue("@fone", modelo.ForFone);
            cmd.Parameters.AddWithValue("@cel", modelo.ForCel);
            cmd.Parameters.AddWithValue("@email", modelo.ForEmail);
            cmd.Parameters.AddWithValue("@numero", modelo.ForEndnumero);
            cmd.Parameters.AddWithValue("@cidade", modelo.ForCidade);
            cmd.Parameters.AddWithValue("@estado", modelo.ForEstado);
            cmd.Parameters.AddWithValue("@codigo", modelo.ForCod);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from fornecedor where for_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor) 
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from fornecedor where for_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorNome(String valor)
        {            
            return Localizar(valor);
        }

        public DataTable LocalizarPorCNPJ(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from fornecedor where for_cnpj like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloFornecedor CarregaModeloFornecedor(int codigo) 
        {
            ModeloFornecedor modelo = new ModeloFornecedor();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from fornecedor where for_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);

            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows) 
            {
                registro.Read();
                modelo.ForCod = Convert.ToInt32(registro["for_cod"]);
                modelo.ForNome = Convert.ToString(registro["for_nome"]);
                modelo.ForCnpj = Convert.ToString(registro["for_cnpj"]);
                modelo.ForIe = Convert.ToString(registro["for_ie"]);
                modelo.ForRsocial = Convert.ToString(registro["for_rsocial"]);
                modelo.ForCep = Convert.ToString(registro["for_cep"]);
                modelo.ForEndereco = Convert.ToString(registro["for_endereco"]);
                modelo.ForBairro = Convert.ToString(registro["for_bairro"]);
                modelo.ForFone = Convert.ToString(registro["for_fone"]);
                modelo.ForCel = Convert.ToString(registro["for_cel"]);
                modelo.ForEmail = Convert.ToString(registro["for_email"]);
                modelo.ForEndnumero = Convert.ToString(registro["for_endnumero"]);
                modelo.ForCidade = Convert.ToString(registro["for_cidade"]);
                modelo.ForEstado = Convert.ToString(registro["for_estado"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        public ModeloFornecedor CarregaModeloFornecedor(string cnpj)
        {
            ModeloFornecedor modelo = new ModeloFornecedor();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from fornecedor where for_cnpj = @cnpj";
            cmd.Parameters.AddWithValue("@cnpj", cnpj);

            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.HasRows)
            {
                registro.Read();
                modelo.ForCod = Convert.ToInt32(registro["for_cod"]);
                modelo.ForNome = Convert.ToString(registro["for_nome"]);
                modelo.ForCnpj = Convert.ToString(registro["for_cnpj"]);
                modelo.ForIe = Convert.ToString(registro["for_ie"]);
                modelo.ForRsocial = Convert.ToString(registro["for_rsocial"]);
                modelo.ForCep = Convert.ToString(registro["for_cep"]);
                modelo.ForEndereco = Convert.ToString(registro["for_endereco"]);
                modelo.ForBairro = Convert.ToString(registro["for_bairro"]);
                modelo.ForFone = Convert.ToString(registro["for_fone"]);
                modelo.ForCel = Convert.ToString(registro["for_cel"]);
                modelo.ForEmail = Convert.ToString(registro["for_email"]);
                modelo.ForEndnumero = Convert.ToString(registro["for_endnumero"]);
                modelo.ForCidade = Convert.ToString(registro["for_cidade"]);
                modelo.ForEstado = Convert.ToString(registro["for_estado"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
