using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemones.SOLICITUDES_HTTPS
{
    internal class SolicitudesGet
    {
        public async Task MetodoGet()
        {
            string url = "https://pokeapi.co/api/v2/pokemon/ditto";
            using HttpClient HttpCliente = new HttpClient();

            // Realiza la solicitud GET
            var res = await HttpCliente.GetAsync(url);

            // Verifica si la solicitud fue exitosa
            if (res.IsSuccessStatusCode)
            {
                // Lee el contenido de la respuesta como cadena de texto
                var content = await res.Content.ReadAsStringAsync();

                // Aquí puedes procesar el contenido como JSON o mostrarlo
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine($"Error: {res.StatusCode}");
            }
        }

    }
}
