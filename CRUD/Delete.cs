using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemones.CRUD
{
    internal class Delete
    {
        string connString = "Host=localhost;Port=5432;Username=postgres;Password=gisell;Database=pokemones";

        public void EliminarPokemon(int id) 
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string Quey = "DELETE FROM Pokemones WHERE Id=@id";
                using (var cmd= new NpgsqlCommand(Quey,conn)) 
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("Id", id);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("pokemon eliminado");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }


                    
                }
            }
        }
    }
}
