using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioEjercito
{
    public class Infanteria: IMilitable
    {
        public double Velocidad { get; set; } = 6;
        public double Blindaje { get; set; } = 0;
        public double PotenciaFuego { get; set; } = 7;
        public int Precio { get; set; } = 250;



    }
}