using pokemones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemones.Interfaces
{
    public interface IPokemonStrategy
    {
        IEnumerable<PokemonEspecifico> EjecutarEstrategia(List<PokemonEspecifico> pokemones);
    }
}
