using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioEjercito
{
    public class Antiaereo: IMilitable
    {
        public double Velocidad { get; set; } = 1;
        public double Blindaje { get; set; } = 0;
        public double PotenciaFuego { get; set; } = 22;
        public int Precio { get; set; } = 1100;
    }
}