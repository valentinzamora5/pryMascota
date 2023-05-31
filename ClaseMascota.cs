using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryMascota
{
    public class ClaseMascota
    {
        //propiedades
        public string Nombre { get; set;}
        public int Peso { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }

        //metodo
         public string ObtenerPropiedades()
        {
            return Nombre + "" + Sexo;
        }


    }
}
