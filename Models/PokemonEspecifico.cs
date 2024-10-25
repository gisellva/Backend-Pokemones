using pokemones.ESTRUCTURE;
using pokemones.Interfaces;
using pokemones.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemones.Models
{
    public class PokemonEspecifico:Pokemones
    {
        public PokemonEspecifico(Estructura estructuraPokemon, IResistenciaStrategy resistenciaStrategy)
       : base(estructuraPokemon, resistenciaStrategy)
        {
        }
    }
}
