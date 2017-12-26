using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloParcelasVenda
    {
        private int ven_cod;
        private double pve_valor;
        private DateTime pve_datapagto;
        private DateTime pve_datavecto;
        private int pve_cod;

        public int VenCod 
        {
            get { return this.ven_cod; }
            set { this.ven_cod = value; }
        }

        public double PveValor 
        {
            get { return this.pve_valor; }
            set { this.pve_valor = value; }
        }

        public DateTime PveDataPagto 
        {
            get { return this.pve_datapagto; }
            set { this.pve_datapagto = value; }
        }

        public DateTime PveDataVecto 
        {
            get { return this.pve_datavecto; }
            set { this.pve_datavecto = value; }
        }

        public int PveCod 
        {
            get { return this.pve_cod; }
            set { this.pve_cod = value; }
        }

        //construtor sem parametros
        public ModeloParcelasVenda() 
        {
            this.VenCod = 0;
            this.PveValor = 0;
            this.PveDataPagto = DateTime.Now;
            this.PveDataVecto = DateTime.Now;
            this.PveCod = 0;
        }

        //construtor com os parametros
        public ModeloParcelasVenda(int venCod, double pveValor, DateTime pveDataPagto, DateTime pveDataVecto, int pveCod)
        {
            this.VenCod = venCod;
            this.PveValor = pveValor;
            this.PveDataPagto = pveDataPagto;
            this.PveDataVecto = pveDataVecto;
            this.PveCod = pveCod;
        }
    }
}
