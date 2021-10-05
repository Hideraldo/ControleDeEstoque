using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloUnidadeDeMedida
    {
        public ModeloUnidadeDeMedida()
        {
            this.UmedCod = 0;
            this.UmedNome = "";
        }

        public ModeloUnidadeDeMedida(int umedcod, string umednome)
        {
            this.UmedCod = umedcod;
            this.UmedNome = umednome;
        }

        public int UmedCod { get; set; }

        public String UmedNome { get; set; }
    }
}
