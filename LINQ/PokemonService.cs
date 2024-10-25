using pokemones.CRUD;
using pokemones.Interfaces;
using pokemones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemones.LINQ
{
    public class PokemonService
    {
        public IResistenciaStrategy ResistenciaStrategy { get; }
        public Get GestorDePokemones { get; }
        public List<PokemonEspecifico> Pokemones { get; }

        public PokemonService()
        {
           
            ResistenciaStrategy = new ResistenciaPorTipoStrategy();
            GestorDePokemones = new Get();
            Pokemones = GestorDePokemones.ListadoDePokemones(ResistenciaStrategy);
        }
    }
}
