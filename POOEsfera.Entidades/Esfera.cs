using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOEsfera.Entidades
{
    public class Esfera
    {
        public double Radio { get; set; }

        public colorRelleno color { get; set; }

        public Lineas linea { get; set; }

        public double GetArea() => 4 * Math.PI * (int)Math.Pow(Radio, 2);
        public double GetVolumen()=> 4 / 3 * Math.PI * (int)Math.Pow(Radio, 3);


    }


    
   

    
   

}
