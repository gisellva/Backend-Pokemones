using Npgsql;
using pokemones.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemones.CRUD
{
    internal class Create
    {
        string connString = "Host=localhost;Port=5432;Username=postgres;Password=gisell;Database=pokemones";

        public void CrearPokemon(Pokemones pokemon)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string Query  = "INSERT INTO pokemones (Id, Nombre, PuntosDeSalud, Imagen, TipoDePokemon, Ataques, TiposResistentes) " +
                               "VALUES (@id, @nombre, @puntosDeSalud, @imagen, @tipoDePokemon, @ataques, @tiposResistentes)";
                ;
                using (var cmd = new NpgsqlCommand(Query, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("id", pokemon.Id);
                        cmd.Parameters.AddWithValue("nombre", pokemon.Nombre);
                        cmd.Parameters.AddWithValue("puntosDeSalud", pokemon.PuntosDeSalud);
                        cmd.Parameters.AddWithValue("imagen", pokemon.Imagen);
                        cmd.Parameters.AddWithValue("tipoDePokemon", pokemon.TipoDePokemon);
                        cmd.Parameters.AddWithValue("ataques", pokemon.Ataques.ToArray());  // Convertir a array
                        cmd.Parameters.AddWithValue("tiposResistentes", pokemon.TiposResistentes.ToArray());  // Convertir a array
                        int filasAfectadas = cmd.ExecuteNonQuery();//ESTO ES SUPER NECESARIO YA QUE ES EL QUE EJECUTA LA CONSULTA DE INSERCION EN LA BASE DE DATOS 
                        if (filasAfectadas > 0)
                        {
                            Console.WriteLine("Pokémon creado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("No se pudo insertar el Pokémon.");
                        }
                    }
                    catch (Exception ex) 
                    {
                        Console.WriteLine(ex.Message);
                    }
                    
                 
                }
            }
          
        }
    }
}

