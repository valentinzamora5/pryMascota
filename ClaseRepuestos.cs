using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryMascota
{
    public class ClaseRepuestos
    {
        //propiedades
        public int Codigo { get; set; }
        public string Nombre { get; set; }
         
        public string Marca { get; set; }
        public decimal Precio { get; set; }
        public bool origen { get; set; }

        //método

        public string ConsultarRepuestos()
        {
            return Nombre + "" + Marca + "" + Codigo + "" + Precio +"" + origen;
        }
          void ActualizarPrecio()
        {
            if (origen == false)
            {
                //importado
            }
                else
                    {
                //nacional
                    }
        }
    
    }
}
