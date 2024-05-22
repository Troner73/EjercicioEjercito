using EjercicioEjercito;

class Program 
{
   static void Main() {
    List<IMilitable> Ejercito1 = new List<IMilitable>();

        Ejercito1.Add(FabricaMilitar.CrearUnidad("Antiaereo"));
        Ejercito1.Add(FabricaMilitar.CrearUnidad("Cañon"));
        Ejercito1.Add(FabricaMilitar.CrearUnidad("Sanitario"));
        Ejercito1.Add(FabricaMilitar.CrearUnidad("Torpedero"));
    
    
    }

} 

