using pokemones.Interfaces;
using pokemones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemones.LINQ
{
    public class AgruparPorTipo : IPokemonStrategy
    {
        private readonly PokemonService pokemonService;

        public AgruparPorTipo(PokemonService pokemonService)
        {
            this.pokemonService = pokemonService;
        }

        public IEnumerable<PokemonEspecifico> EjecutarEstrategia(List<PokemonEspecifico> _)
        {
            return pokemonService.Pokemones
                .GroupBy(p => p.TipoDePokemon)
                .SelectMany(grupo => grupo);
        }
    }
}
