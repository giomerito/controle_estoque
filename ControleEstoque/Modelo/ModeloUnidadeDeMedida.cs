using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class ModeloUnidadeDeMedida
    {
        private int umed_cod;
        private String umed_nome;

        public int UmedCod 
        {
            get { return this.umed_cod; }
            set { this.umed_cod = value; }
        }

        public String UmedNome 
        {
            get { return this.umed_nome; }
            set { this.umed_nome = value; }
        }

        public ModeloUnidadeDeMedida() 
        {
            this.umed_cod = 0;
            this.umed_nome = "";
        }

        public ModeloUnidadeDeMedida(int cod, String nome) 
        {
            this.umed_cod = cod;
            this.umed_nome = nome;
        }
    }
}
