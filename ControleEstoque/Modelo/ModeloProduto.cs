using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloProduto
    {
        //Atributos
        private int pro_cod;
        private String pro_nome;
        private String pro_descricao;
        private byte[] pro_foto;
        private Double pro_valorpago;
        private Double pro_valorvenda;
        private Double pro_qtde;
        private int umed_cod;
        private int cat_cod;
        private int scat_cod;

        //Encapsulamento dos atributos
        public int ProCod
        {
            get { return pro_cod; }
            set { pro_cod = value; }
        }       

        public String ProNome
        {
            get { return pro_nome; }
            set { pro_nome = value; }
        }        

        public String ProDescricao
        {
            get { return pro_descricao; }
            set { pro_descricao = value; }
        }       

        public byte[] ProFoto
        {
            get { return pro_foto; }
            set { pro_foto = value; }
        }        

        public Double ProValorPago
        {
            get { return pro_valorpago; }
            set { pro_valorpago = value; }
        }        

        public Double ProValorVenda
        {
            get { return pro_valorvenda; }
            set { pro_valorvenda = value; }
        }        

        public Double ProQtde
        {
            get { return pro_qtde; }
            set { pro_qtde = value; }
        }        

        public int UmedCod
        {
            get { return umed_cod; }
            set { umed_cod = value; }
        }       

        public int CatCod
        {
            get { return cat_cod; }
            set { cat_cod = value; }
        }        

        public int ScatCod
        {
            get { return scat_cod; }
            set { scat_cod = value; }
        }

        //Construtor sem parametros
        public ModeloProduto() 
        {
            this.ProCod = 0;
            this.ProNome = "";
            this.ProDescricao = "";
            //this.ProFoto = null o vetor não existe
            this.ProValorPago = 0;
            this.ProValorVenda = 0;
            this.ProQtde = 0;
            this.UmedCod = 0;
            this.CatCod = 0;
            this.ScatCod = 0;
        }

        //Construtor com parametros
        public ModeloProduto(int pro_cod, String pro_nome, String pro_descricao, String pro_foto, Double pro_valorpago,
        Double pro_valorvenda, Double pro_qtde, int umed_cod, int cat_cod, int scat_cod) 
        {
            this.ProCod = pro_cod;
            this.ProNome = pro_nome;
            this.ProDescricao = pro_descricao;
            this.CarregaImagem(pro_foto);
            this.ProValorPago = pro_valorpago;
            this.ProValorVenda = pro_valorvenda;
            this.ProQtde = pro_qtde;
            this.UmedCod = umed_cod;
            this.CatCod = cat_cod;
            this.ScatCod = scat_cod;
        }

        public ModeloProduto(int pro_cod, String pro_nome, String pro_descricao, Byte[] pro_foto, Double pro_valorpago,
        Double pro_valorvenda, Double pro_qtde, int umed_cod, int cat_cod, int scat_cod)
        {
            this.ProCod = pro_cod;
            this.ProNome = pro_nome;
            this.ProDescricao = pro_descricao;
            this.ProFoto = pro_foto;
            this.ProValorPago = pro_valorpago;
            this.ProValorVenda = pro_valorvenda;
            this.ProQtde = pro_qtde;
            this.UmedCod = umed_cod;
            this.CatCod = cat_cod;
            this.ScatCod = scat_cod;
        }

        public void CarregaImagem(String imgCaminho) 
        {
            try 
            {
                if (string.IsNullOrEmpty(imgCaminho))
                    return;
                //fornece propriedades e métodos de instância para criar, copiar
                //excluir, mover e abrir arquivos, e ajuda na criação de objetos FileStream
                FileInfo arqImagem = new FileInfo(imgCaminho);
                //Expõe um Stream ao redor de um arquivo de suporte
                //síncrono e assíncrono operações de leitura e gravar.
                FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);
                //aloca memoria para o vetor
                this.ProFoto = new byte[Convert.ToInt32(arqImagem.Length)];
                //Lê um bloco de bytes do fluxo e grava os dados em um buffer fornecido
                int iBytesRead = fs.Read(this.ProFoto, 0, Convert.ToInt32(arqImagem.Length));

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        
    }
}
