using pokemones.ESTRUCTURE;
using pokemones.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemones.MODELS
{
    public abstract class Pokemones
    {
      public int Id { get; set; }
      public string Nombre { get; set; }
      public string Imagen { get; set; }
      public int  PuntosDeSalud {  get; set; }
      public string TipoDePokemon { get; set; }
      public List<string> Ataques { get; set; }
      public List<string> TiposResistentes { get; set; }

      private readonly IResistenciaStrategy _resistenciaStrategy;

        public Pokemones(Estructura EstructuraDePokemones, IResistenciaStrategy resistenciaStrategy)
        {
 
            this.Id = EstructuraDePokemones.Id;
            this.Nombre = EstructuraDePokemones.Nombre;
            this.Imagen = EstructuraDePokemones.Imagen;
            this.PuntosDeSalud = EstructuraDePokemones.PuntosDeSalud;
            this.Ataques = EstructuraDePokemones.Ataques ?? new List<string>() ;
            this.TipoDePokemon = EstructuraDePokemones.TipoDePokemon;
            _resistenciaStrategy = resistenciaStrategy;
            TiposResistentes = _resistenciaStrategy.AsignarResistencias(TipoDePokemon);
        }
          public virtual String MostrarPokemon() // El modificador virtual en C# se usa para indicar que un método en una clase base puede ser sobrescrito por las clases derivadas.
          {
            return $"Id: {Id}, Nombre: {Nombre},TipoDePokemon:{TipoDePokemon}, Imagen: {Imagen}, PuntosDeSalud: {PuntosDeSalud}, " +
               $"Ataques: {string.Join(", ", Ataques)}, TiposResistentes: {string.Join(", ", TiposResistentes)}";
          }
        
       

    }
}
