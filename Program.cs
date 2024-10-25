using Npgsql;
using pokemones.CRUD;
using pokemones.ESTRUCTURE;
using pokemones.GENERICS;
using pokemones.Interfaces;
using pokemones.LINQ;
using pokemones.Models;
using pokemones.Models.modelos_para_probar_los_genericos;
using pokemones.MODELS;
using System.Globalization;
using static pokemones.LINQ.ConsultasLinQPokemones;

using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace pokemones
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ConsultasLinQPokemones consultas = new ConsultasLinQPokemones();
            //FiltrarPorTipoStrategy filtrarPorTipo = new FiltrarPorTipoStrategy("Fuego", consultas.pokemonService);
            //Console.WriteLine("Pokémones de tipo Fuego:");
            //IEnumerable<PokemonEspecifico> ListaDePokemones= consultas.TranformacionDeListaAIEnumerable(filtrarPorTipo);
            //consultas.MostrarPokemon(ListaDePokemones);




            //OrdenarPorPuntosDeSaludStrategy ordenarPorSalud = new OrdenarPorPuntosDeSaludStrategy(consultas.pokemonService);
            //Console.WriteLine("Pokémones de por puntos de salud:");
            //consultas.TranformacionDeListaAIEnumerable(ordenarPorSalud);

            FiltrarPokemones filtro = new FiltrarPokemones(consultas.pokemonService);
            Console.WriteLine("filtro dinamico");
            IEnumerable<PokemonEspecifico> ListaDePokemones = filtro.Filtrar(p => p.PuntosDeSalud == 100, consultas);
            consultas.MostrarPokemon(ListaDePokemones);

            //var estrategiaOrdenar = new LinQPokemones.ConsultasLinQPokemones.OrdenarPorPuntosDeSaludStrategy();
            //Console.WriteLine("Ordenar por puntos de salud:");
            //consultasPokemones.EjecutarEstrategia(estrategiaOrdenar);

            //var estrategiaAgrupar = new LinQPokemones.ConsultasLinQPokemones.AgruparPorTipo();
            //Console.WriteLine("Agrupar");
            //consultasPokemones.EjecutarEstrategia(estrategiaAgrupar);

            //    string apiUrl = "https://pokeapi.co/api/v2/berry/4";
            //    ApiHelper apiHelper = new ApiHelper();
            //    try
            //    {
            //        Berry berry = await apiHelper.GetFromApi<Berry>(apiUrl);

            //        if (berry != null)
            //        {
            //            Console.WriteLine($"ID: {berry.Id}, Name: {berry.Name}");
            //            Console.WriteLine($"Growth Time: {berry.Growth_Time}");
            //            Console.WriteLine($"Max Harvest: {berry.Max_Harvest}");
            //            Console.WriteLine($"Natural Gift Power: {berry.Natural_Gift_Power}");
            //            Console.WriteLine($"Size: {berry.Size}");
            //            Console.WriteLine($"Smoothness: {berry.Smoothness}");
            //            Console.WriteLine($"Soil Dryness: {berry.Soil_Dryness}");

            //            Console.WriteLine($"Firmness: {berry.Firmness.Name}");



            //            foreach (var flavor in berry.Flavors)
            //            {
            //                // Accedemos a la propiedad 'Flavor' dentro de cada 'flavor', y luego a 'Name'
            //                Console.WriteLine($"- Flavor: {flavor.Flavor.Name}, Potency: {flavor.Potency}");
            //            }


            //        }
            //        else
            //        {
            //            Console.WriteLine("No existe esa baya.");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Error: " + ex.Message);
            //    }
        }


    }
}
 