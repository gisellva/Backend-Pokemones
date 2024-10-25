using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemones.ESTRUCTURE
{
    public struct Estructura
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public int PuntosDeSalud { get; set; }
        public string TipoDePokemon { get; set; }
        public List<string> Ataques { get; set; }
        
    }
}
