using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioEjercito
{
    public class TanqueAtaque : IMilitable
    {


        public double Velocidad { get; set; } = 7.3;
        public double Blindaje { get; set; } = 4.8;
        public double PotenciaFuego { get; set; } = 9.8;
        public int Precio { get; set; } = 15600;

    }
}