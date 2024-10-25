using pokemones.GENERICS;
using pokemones.Models.modelos_para_probar_los_genericos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemones.Models.modelos_para_probar_los_genericos
{
   
        public class Berry
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Growth_Time { get; set; }
            public int Max_Harvest { get; set; }
            public int Natural_Gift_Power { get; set; }
            public int Size { get; set; }
            public int Smoothness { get; set; }
            public int Soil_Dryness { get; set; }

            // Relación con BerryFirmness (Firmeza de la baya)
            public BerryFirmness Firmness { get; set; }

            // Lista de sabores
            public List<BerryFlavor> Flavors { get; set; }

        }

        public class BerryFirmness
        {
            public string Name { get; set; }
            
        }

    public class BerryFlavor
    {
        public int Potency { get; set; }
        public FlavorDetail Flavor { get; set; } // Aquí definimos un objeto que contiene los detalles del sabor
    }

    public class FlavorDetail
    {
        public string Name { get; set; }
      
    }



}
/*/
string apiUrl = "";
ApiHelper apiHelper = new ApiHelper();
try
{
    Berry berry = await apiHelper.GetFromApi<Berry>(apiUrl);

    if (berry != null)
    {
        Console.WriteLine($"ID: {berry.Id}, Name: {berry.Name}");
        Console.WriteLine($"Growth Time: {berry.Growth_Time}");
        Console.WriteLine($"Max Harvest: {berry.Max_Harvest}");
        Console.WriteLine($"Natural Gift Power: {berry.Natural_Gift_Power}");
        Console.WriteLine($"Size: {berry.Size}");
        Console.WriteLine($"Smoothness: {berry.Smoothness}");
        Console.WriteLine($"Soil Dryness: {berry.Soil_Dryness}");

        Console.WriteLine($"Firmness: {berry.Firmness.Name}");



        foreach (var flavor in berry.Flavors)
        {
            // Accedemos a la propiedad 'Flavor' dentro de cada 'flavor', y luego a 'Name'
            Console.WriteLine($"- Flavor: {flavor.Flavor.Name}, Potency: {flavor.Potency}");
        }





    }
    else
    {
        Console.WriteLine("No existe esa baya.");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
        }/*/