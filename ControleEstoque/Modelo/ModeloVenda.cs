using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloVenda
    {
        private int ven_cod;
        private DateTime ven_data;
        private int ven_nfiscal;
        private Double ven_total;
        private int ven_nparcelas;
        private String ven_status;
        private int cli_cod;
        private int tpa_cod;
        private int ven_avista;

        //Encapsulamento dos dados

        public int VenCod 
        {
            get { return this.ven_cod; }
            set { this.ven_cod = value; }
        }

        public DateTime VenData 
        {
            get { return this.ven_data; }
            set { this.ven_data = value; }
        }

        public int VenNfiscal 
        {
            get { return this.ven_nfiscal; }
            set { this.ven_nfiscal = value; }
        }

        public Double VenTotal 
        {
            get { return this.ven_total; }
            set { this.ven_total = value; }
        }

        public int VenNparcelas 
        {
            get { return this.ven_nparcelas; }
            set { this.ven_nparcelas = value; }
        }

        public String VenStatus 
        {
            get { return this.ven_status; }
            set { this.ven_status = value; }
        }

        public int CliCod 
        {
            get { return this.cli_cod; }
            set { this.cli_cod = value; }
        }

        public int TpaCod 
        {
            get { return this.tpa_cod; }
            set { this.tpa_cod = value; }
        }

        public int VenAvista 
        {
            get { return this.ven_avista; }
            set { this.ven_avista = value; }
        }

        //construtor sem parametros
        public ModeloVenda() 
        {
            this.VenCod = 0;
            this.VenData = DateTime.Now;
            this.VenNfiscal = 0;
            this.VenTotal = 0;
            this.VenNparcelas = 0;
            this.VenStatus = "";
            this.CliCod = 0;
            this.TpaCod = 0;
            this.VenAvista = 1;
        }

        //construtor com parametros
        public ModeloVenda(int venCod, DateTime venData, int venNfiscal, Double venTotal, int venNparcelas, String venStatus, int cliCod, int tpaCod, int venAvista)
        {
            this.VenCod = venCod;
            this.VenData = venData;
            this.VenNfiscal = venNfiscal;
            this.VenTotal = venTotal;
            this.VenNparcelas = venNparcelas;
            this.VenStatus = venStatus;
            this.CliCod = cliCod;
            this.TpaCod = tpaCod;
            this.VenAvista = venAvista;
        } 
    }
}
