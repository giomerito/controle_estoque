using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloSubCategoria
    {
        private int scat_cod;
        private String scat_nome;
        private int cat_cod;

        public int ScatCod 
        {
            get { return this.scat_cod; }
            set { this.scat_cod = value; }
        }

        public String ScatNome 
        {
            get { return this.scat_nome; }
            set { this.scat_nome = value; }
        }

        public int CatCod 
        {
            get { return this.cat_cod; }
            set { this.cat_cod = value; }
        }

        //Construtor sem parametros

        public ModeloSubCategoria() 
        {
            this.CatCod = 0;
            this.scat_cod = 0;
            this.scat_nome = "";
        }

        //contrutor com parametros

        public ModeloSubCategoria(int scatcod, int catcod, String scatnome) 
        {
            this.CatCod = catcod;
            this.scat_cod = scatcod;
            this.scat_nome = scatnome;
        }


    }
}
