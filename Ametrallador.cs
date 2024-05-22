using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioEjercito
{
    public class Ametrallador: IMilitable
    {
        public double Velocidad { get; set; } = 4;
        public double Blindaje { get; set; } = 0;
        public double PotenciaFuego { get; set; } = 10;
        public int Precio { get; set; } = 400;
    }
}