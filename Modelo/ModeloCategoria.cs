using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCategoria
    {
        public ModeloCategoria()
        {
            this.CatCod = 0;
            this.CatNome = "";
        }

        public ModeloCategoria(int catcod, string nome)
        {
            this.CatCod = catcod;
            this.CatNome = nome;
        }

        public int CatCod { get; set; }

        public String CatNome { get; set; }
    }
}
