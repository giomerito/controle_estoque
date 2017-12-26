using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCategoria
    {
        private int cat_cod;
        private String cat_nome;

        public int CatCod 
        {
            get { return this.cat_cod; }
            set { this.cat_cod = value; }
        }

        public String CatNome 
        {
            get { return this.cat_nome; }
            set { this.cat_nome = value; }
        }

        public ModeloCategoria() 
        {
            this.cat_cod = 0;
            this.cat_nome = "";
        }

        public ModeloCategoria(int catcod, String catnome) 
        {
            this.cat_cod = catcod;
            this.cat_nome = catnome;
        }

    }
}
