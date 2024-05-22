using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioEjercito
{
    public class Torpedero : IMilitable
    {
        public double Velocidad { get; set; } = 3;
        public double Blindaje { get; set; } = 2;
        public double PotenciaFuego { get; set; } = 19;
        public int Precio { get; set; } = 1350;


    }
}