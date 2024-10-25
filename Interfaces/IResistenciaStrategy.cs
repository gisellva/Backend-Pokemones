using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemones.Interfaces
{
    public interface IResistenciaStrategy
    {
        List<string> AsignarResistencias(string TipodePokemon);
        //El método AsignarResistencias recibe el tipo de Pokémon y devuelve la lista de resistencias correspondiente.
    }
}
