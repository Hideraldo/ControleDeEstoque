using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloSubCategoria
    {
        public ModeloSubCategoria()
        {
            this.ScatCod = 0;
            this.ScadNome = "";
            this.CatCod = 0;
        }

        public ModeloSubCategoria(int scatcod, string snome, int catcod)
        {
            this.ScatCod = scatcod;
            this.ScadNome = snome;
            this.CatCod = catcod;
        }

        public int ScatCod { get; set; }
        public string ScadNome { get; set; }
        public int CatCod { get; set; }
    }
}
