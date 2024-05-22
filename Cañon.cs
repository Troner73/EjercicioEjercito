using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioEjercito
{
    public class Cañon: IMilitable
    {
        public double Velocidad { get; set; } = 0;
        public double Blindaje { get; set; } = 0;
        public double PotenciaFuego { get; set; } = 14;
        public int Precio { get; set; } = 1100;
    }
}