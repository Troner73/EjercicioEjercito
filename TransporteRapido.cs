using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioEjercito
{
    public class TransporteRapido : IMilitable
    {
        public double Velocidad { get; set; } = 12;
        public double Blindaje { get; set; } = 0;
        public double PotenciaFuego { get; set; } = 0;
        public int Precio { get; set; } = 1600;
    }
}