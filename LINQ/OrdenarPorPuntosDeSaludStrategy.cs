using pokemones.Interfaces;
using pokemones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemones.LINQ
{
    public class OrdenarPorPuntosDeSaludStrategy : IPokemonStrategy
    {
        private readonly PokemonService pokemonService;

        public OrdenarPorPuntosDeSaludStrategy(PokemonService pokemonService)
        {
            this.pokemonService = pokemonService;
        }

        public IEnumerable<PokemonEspecifico> EjecutarEstrategia(List<PokemonEspecifico> _)
        {
            return pokemonService.Pokemones.OrderByDescending(p => p.PuntosDeSalud);
        }
    }
}
