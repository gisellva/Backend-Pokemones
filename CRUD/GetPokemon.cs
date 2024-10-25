using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemones.CRUD
{
    internal class GetPokemon
    {
        string connString = "Host=localhost;Port=5432;Username=postgres;Password=gisell;Database=pokemones";

        public void TraerUnPokemon(int id)
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                // Consulta para obtener un Pokémon por su Id
                string query = "SELECT Nombre, PuntosDeSalud, Imagen, TipoDePokemon, Ataques, TiposResistentes FROM pokemones WHERE Id = @Id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    // Añadir el parámetro Id
                    cmd.Parameters.AddWithValue("Id", id);

                    try
                    {
                        // Ejecutar la consulta
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())  // Verificar si se obtuvo algún resultado de ese pokemon 
                            {
                                // Leer los valores de las columnas
                                string nombre = reader["Nombre"].ToString();
                                int puntosDeSalud = (int)reader["PuntosDeSalud"];
                                string imagen = reader["Imagen"].ToString();
                                string tipoDePokemon = reader["TipoDePokemon"].ToString();
                                
                                string[] ataques = (string[])reader["Ataques"];
                                string[] tiposResistentes = (string[])reader["TiposResistentes"];

                                // Imprimir los datos del Pokémon
                                Console.WriteLine($"Nombre: {nombre}");
                                Console.WriteLine($"Puntos de Salud: {puntosDeSalud}");
                                Console.WriteLine($"Imagen: {imagen}");
                                Console.WriteLine($"Tipo de Pokémon: {tipoDePokemon}");
                                Console.WriteLine($"Ataques: {string.Join(", ", ataques)}");
                                Console.WriteLine($"Tipos Resistentes: {string.Join(", ", tiposResistentes)}");
                            }
                            else
                            {
                                Console.WriteLine("No se encontró ningún Pokémon con el Id especificado.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al traer el Pokémon: {ex.Message}");
                    }
                }
            }
        }
    }
}
