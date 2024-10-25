using pokemones.Interfaces;
using pokemones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemones.LINQ
{
    public class FiltrarPokemones
    {
        private readonly PokemonService pokemonService;

        public FiltrarPokemones(PokemonService service)
        {
            pokemonService = service;
        }


        public delegate bool FiltroPokemon(PokemonEspecifico pokemon);


        public IEnumerable<PokemonEspecifico> Filtrar(FiltroPokemon criterio, ConsultasLinQPokemones consultas)
        {
            try
            {
                var pokemonesFiltrados = pokemonService.Pokemones.Where(p => criterio(p));

                return pokemonesFiltrados;
                //  CustomStrategy estrategia = new CustomStrategy(pokemonesFiltrados); 

            }
            catch (Exception ex)
            {
               Console.WriteLine($"Error al filtrar Pokémon: {ex.Message}");
                return new List<PokemonEspecifico>();
            }

        }


        //    private class CustomStrategy : IPokemonStrategy
        //    {
        //        private readonly IEnumerable<PokemonEspecifico> pokemones;

        //        public CustomStrategy(IEnumerable<PokemonEspecifico> pokemones)
        //        {
        //            this.pokemones = pokemones; 
        //        }

        //        public IEnumerable<PokemonEspecifico> EjecutarEstrategia(List<PokemonEspecifico> _)
        //        {
        //            return pokemones; 
        //        }
        //    }
        //}
    }
}
