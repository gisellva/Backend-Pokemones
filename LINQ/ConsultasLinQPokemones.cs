using pokemones.CRUD;
using pokemones.Errors;
using pokemones.Interfaces;
using pokemones.Models;
using pokemones.MODELS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace pokemones.LINQ
{
    public class ConsultasLinQPokemones
    {
        public PokemonService pokemonService;

        public ConsultasLinQPokemones()
        {
            pokemonService = new PokemonService();
        }

        public void MostrarPokemon<T>(IEnumerable<T> listaPokemones)
        {
            foreach (var item in listaPokemones)
            {
                if (item is PokemonEspecifico pokemon)
                {
                    Console.WriteLine($"{pokemon.Nombre} - Tipo: {pokemon.TipoDePokemon}");
                }
            }
        }

        public IEnumerable<PokemonEspecifico> TranformacionDeListaAIEnumerable(IPokemonStrategy estrategia)
        {
            IEnumerable<PokemonEspecifico> resultado = estrategia.EjecutarEstrategia(pokemonService.Pokemones);
            return resultado;
        }



    }
}

