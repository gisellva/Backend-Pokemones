using Npgsql;
using pokemones.MODELS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemones.CRUD
{
    internal class Update
    {
        string connString = "Host=localhost;Port=5432;Username=postgres;Password=gisell;Database=pokemones";

        public void ActualizarPokemon(int id, string campoAActualizar, object nuevoValor) 
        {
            using (var conn= new NpgsqlConnection(connString)) //el objeto conn contiene la información y el estado de la conexión a la base de datos, como la dirección del servidor, credenciales, y la base de datos con la que estás trabajando.
            {
             conn.Open();
                string query = $"UPDATE pokemones SET {campoAActualizar} = @nuevoValor WHERE Id = @id";
                using (var cmd =new NpgsqlCommand(query,conn))//el objeto cmd contiene la consulta SQL que quieres ejecutar, los parámetros de esa consulta, y la referencia a la conexión (conn) que se usará para enviar la consulta a la base de datos.
                {
                    try {
                        /*/Parameters es como una lista de espacios vacíos que se crea automáticamente en el objeto cmd cuando preparas una consulta SQL que incluye parámetros (como @id, @nombre, etc.).
                        y luego, cuando usas AddWithValue(), estás diciendo: “Este espacio vacío que 
                        se llama @id (u otro parámetro), ahora va a tener el valor que te voy a dar”/*/

                        cmd.Parameters.AddWithValue("id", id);  // El Id del Pokémon a actualizar
                        cmd.Parameters.AddWithValue("nuevoValor", nuevoValor);  // El nuevo valor para el campo específico

                        int filasAfectadas = cmd.ExecuteNonQuery();//este motodo ejecuta la query en la base de datos y devuelve un numetro entero mayor a 0
                        if (filasAfectadas > 0)
                        {
                            Console.WriteLine($"{campoAActualizar}  fue actualizado con el valor {nuevoValor}.");
                        }
                        else
                        {
                            Console.WriteLine("No se puedo actualizar el pokemon");
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
