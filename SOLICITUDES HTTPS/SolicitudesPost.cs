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
    internal class SolicitudesPost
    {
        public async Task MetodoPOST()
        {
            string url = "https://pokeapi.co/api/v2/post";
           HttpClient HttpCliente = new HttpClient();

            Estructura estructura = new Estructura
            {
                Id = 12,
                Nombre = "Pikachu",
                PuntosDeSalud = 100,
                Imagen = "pikachu.png",
                Ataques = new List<string> { "Impactrueno", "Ataque Rápido" },
                TipoDePokemon = "Electrico"
            };
            ResistenciaPorTipoStrategy estrategiaResistencia = new ResistenciaPorTipoStrategy();
            PokemonEspecifico pokemon = new PokemonEspecifico(estructura, estrategiaResistencia);
            
            var data=JsonSerializer.Serialize<PokemonEspecifico>(pokemon);
             HttpContent content = new StringContent(data,System.Text.Encoding.UTF8,"application/json");
            var res=await HttpCliente.PostAsync(url, content);

            if (res.IsSuccessStatusCode)
            {
                var resullt= await res.Content.ReadAsStringAsync();
                var postresult=JsonSerializer.Deserialize<PokemonEspecifico>(resullt);

            }
        }
    }
}
