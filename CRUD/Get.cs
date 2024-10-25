using Npgsql;
using pokemones.ESTRUCTURE;
using pokemones.Interfaces;
using pokemones.Models;
using pokemones.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemones.CRUD
{
    public class Get
    {
        string connString = "Host=localhost;Port=5432;Username=postgres;Password=gisell;Database=pokemones";

        // Este método es para leer todos los pokemones
        public List<PokemonEspecifico> ListadoDePokemones(IResistenciaStrategy resistenciaStrategy)
        {
            List<PokemonEspecifico> pokemones = new List<PokemonEspecifico>();
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                // Modifica la consulta para no traer TiposResistentes directamente
                using (var cmd = new NpgsqlCommand("SELECT Id, Nombre, PuntosDeSalud, Imagen,TipoDePokemon, Ataques  FROM Pokemones", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Leer el ID, Nombre, PuntosDeSalud, Imagen y TipoDePokemon
                            int id = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            int puntosDeSalud = reader.GetInt32(2);
                            string imagen = reader.GetString(3);
                            string tipodePokemon = reader.GetString(4);
                           
                            // Leer el array de Ataques (PostgreSQL text[])
                            string[] ataquesArray = reader.GetFieldValue<string[]>(5);
                            List<string> ataques = ataquesArray.ToList(); // Convertir a List<string>

                            // Crear la estructura del Pokémon
                            Estructura estructura = new Estructura
                            {
                                Id = id,
                                Nombre = nombre,
                                PuntosDeSalud = puntosDeSalud,
                                Imagen = imagen,
                       
                                TipoDePokemon = tipodePokemon,
                                Ataques = ataques,
                            };

                            // Crear una instancia del Pokémon usando el constructor que acepta estrategia
                            PokemonEspecifico pokemon = new PokemonEspecifico(estructura, resistenciaStrategy);

                            pokemones.Add(pokemon);
                        }
                    }
                }
            }

            return pokemones;
        }
    }
}