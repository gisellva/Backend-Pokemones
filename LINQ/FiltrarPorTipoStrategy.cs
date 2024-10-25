using pokemones.Errors;
using pokemones.Interfaces;
using pokemones.Models;
using pokemones.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemones.LINQ
{
  
        public class FiltrarPorTipoStrategy : IPokemonStrategy
        {
            private readonly string tipo;
            private readonly PokemonService pokemonService;

            public FiltrarPorTipoStrategy(string tipo, PokemonService pokemonService)
            {
                this.tipo = tipo;
                this.pokemonService = pokemonService;
            }

            public string Tipo => tipo;

            public IEnumerable<PokemonEspecifico> EjecutarEstrategia(List<PokemonEspecifico> _)
            {
            IEnumerable<PokemonEspecifico> pokemonesFiltrados = pokemonService.Pokemones.Where(p => p.TipoDePokemon == tipo);
                if (!pokemonesFiltrados.Any())
                {
                    throw new NotPokemonType("Ese tipo de Pokémon no existe, prueba con otro tipo");
                }
                return pokemonesFiltrados;
            }
        }
}

