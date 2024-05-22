using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioEjercito
{
    public interface IMilitable
    {
        double Velocidad { get; set; }
        double Blindaje { get; set; }
        double PotenciaFuego { get; set; }
        int Precio { get; set; }
    }
}