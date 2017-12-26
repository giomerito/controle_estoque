using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloTipoPagamento
    {
        private int tpa_cod;
        private String tpa_nome;

        public int TpaCod 
        {
            get { return this.tpa_cod; }
            set { this.tpa_cod = value; }
        }

        public String TpaNome 
        {
            get { return this.tpa_nome; }
            set { this.tpa_nome = value; }
        }

        public ModeloTipoPagamento() 
        {
            this.tpa_cod = 0;
            this.tpa_nome = "";
        }

        public ModeloTipoPagamento(int tpacod, String tpanome) 
        {
            this.tpa_cod = tpacod;
            this.tpa_nome = tpanome;
        }
    }
}
