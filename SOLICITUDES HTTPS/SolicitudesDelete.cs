using pokemones.ESTRUCTURE;
using pokemones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace pokemones.SOLICITUDES_HTTPS
{
    internal class SolicitudesDelete
    {
        public async Task MetodoDelete()
        {
            string url = "https://pokeapi.co/api/v2/pos/4";
            HttpClient HttpCliente = new HttpClient();

           

          
            var res = await HttpCliente.DeleteAsync(url);

            if (res.IsSuccessStatusCode)
            {
                var resullt = await res.Content.ReadAsStringAsync();
               

            }
        }
    }
}
