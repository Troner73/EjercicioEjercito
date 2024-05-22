using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioEjercito
{
    public class FabricaMilitar
    {
        public static IMilitable CrearUnidad(string type)
        {
            switch (type) 
            {
                case "Ametrallador":
                    return new Ametrallador();
                case "Antiaereo":
                    return new Antiaereo();
                case "Cañon":
                    return new Cañon();
                case "Infanteria":
                    return new Infanteria();
                case "Sanitario":
                    return new Sanitario();
                case "TanqueAtaque":
                    return new TanqueAtaque();
                case "Torpedero":
                    return new Torpedero();
                case "Transporte":
                    return new Transporte();
                case "TransporteRapido":
                    return new TransporteRapido();
                default:
                    throw new ArgumentException("Tipo de unidad desconocida.");




            }

        }
    }
}