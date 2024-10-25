using pokemones.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemones.Models
{
    internal class ResistenciaPorTipoStrategy:IResistenciaStrategy
    {
        private readonly Dictionary<string, List<string>> resistenciaPorTipos = new()
        {
            { "Acero", new List<string> { "Normal", "Planta", "Hielo", "Psíquico", "Bicho", "Roca", "Dragón", "Acero", "Hada" }},
            { "Agua", new List<string> { "Fuego", "Agua", "Hielo", "Acero" }},
            { "Fuego", new List<string> { "Fuego", "Planta", "Hielo", "Bicho", "Acero", "Hada" }},
            { "Planta", new List<string> { "Agua", "Planta", "Eléctrico", "Tierra" }},
            { "Electrico", new List<string> { "Eléctrico", "Acero", "Volador" }},
            { "Bicho", new List<string> { "Planta", "Lucha", "Tierra" }},
            { "Hada", new List<string> { "Lucha", "Bicho", "Siniestro" }},
            { "Dragon", new List<string> { "Planta", "Fuego", "Agua","Eléctrico" }},
            { "Fantasma", new List<string> { "Veneno", "Bicho", "Siniestro" }},
            { "Hielo", new List<string> { "Hielo" }},
            { "Lucha", new List<string> { "Roca", "Bicho", "Siniestro" }},
            { "Normal", new List<string> { "Ninguno" }},
            { "Psiquico", new List<string> { "Lucha", "Psíquico" }},
            { "Roca", new List<string> { "Normal", "Fuego", "Veneno","Volador"}},
            { "Siniestro", new List<string> { "Fantasma", "Siniestro" }},
            { "Tierra", new List<string> { "Veneno", "Roca" }},
            { "Veneno", new List<string> { "Planta", "Lucha", "Veneno","Bicho","Hada" }},
            { "Volador", new List<string> { "Lucha", "Bicho", "Planta" }},

        };
        public List<string> AsignarResistencias(string tipoDePokemon) 
        { 
            return resistenciaPorTipos.ContainsKey(tipoDePokemon) ? resistenciaPorTipos[tipoDePokemon] : new List<string>();//busca en el diccionario el paramatro que le pasaste y te devuelve la lista de las resistencias
        }
    }
}
