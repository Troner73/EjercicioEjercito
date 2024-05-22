using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioEjercito
{
    public class Sanitario: IMilitable
    {
        public double Velocidad { get; set; } = 7;
        public double Blindaje { get; set; } = 5;
        public double PotenciaFuego { get; set; } = 0;
        public int Precio { get; set; } = 500;

    }
}