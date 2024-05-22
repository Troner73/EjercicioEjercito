using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioEjercito
{
    public class Transporte: IMilitable
    {

        public double Velocidad { get; set; } = 4.5;
        public double Blindaje { get; set; } = 1.4;
        public double PotenciaFuego { get; set; } = 0;
        public int Precio { get; set; } = 4200;
    }
}
