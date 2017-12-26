using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCompra
    {
        private int com_cod;
        private DateTime com_data;
        private int com_nfiscal;
        private Double com_total;
        private int com_nparcelas;
        private String com_status;
        private int for_cod;
        private int tpa_cod;

        public int ComCod
        {
            get { return this.com_cod; }
            set { this.com_cod = value; }
        }       

        public DateTime ComData
        {
            get { return this.com_data; }
            set { this.com_data = value; }
        }       

        public int ComNfiscal
        {
            get { return this.com_nfiscal; }
            set { this.com_nfiscal = value; }
        }       

        public Double ComTotal
        {
            get { return this.com_total; }
            set { this.com_total = value; }
        }       

        public int ComNparcelas
        {
            get { return this.com_nparcelas; }
            set { this.com_nparcelas = value; }
        }       

        public String ComStatus
        {
            get { return this.com_status; }
            set { this.com_status = value; }
        }       

        public int ForCod
        {
            get { return this.for_cod; }
            set { this.for_cod = value; }
        }       

        public int TpaCod
        {
            get { return this.tpa_cod; }
            set { this.tpa_cod = value; }
        }

        //Construtor

        public ModeloCompra() 
        {
            this.ComCod = 0;
            this.ComData = DateTime.Now;
            this.ComNfiscal = 0;
            this.ComNparcelas = 0;
            this.ComStatus = "";
            this.ComTotal = 0;
            this.ForCod = 0;
            this.TpaCod = 0;
        }

        public ModeloCompra(int comCod, DateTime data, int nFiscal, Double total, int nparcelas, String status, int forCod, int tpaCod)
        {
            this.ComCod = comCod;
            this.ComData = data;
            this.ComNfiscal = nFiscal;
            this.ComNparcelas = nparcelas;
            this.ComStatus = status;
            this.ComTotal = total;
            this.ForCod = forCod;
            this.TpaCod = tpaCod;
        }
    }
}
