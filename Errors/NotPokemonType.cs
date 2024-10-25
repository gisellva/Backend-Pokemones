using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemones.Errors
{
    internal class NotPokemonType : Exception
    {
        public NotPokemonType() : base() { }
        public NotPokemonType(string message) : base(message) { }
        public NotPokemonType(string message, Exception innerException) : base(message, innerException) { }
    }
}
