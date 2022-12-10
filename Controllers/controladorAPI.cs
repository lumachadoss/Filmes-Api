using api1.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api1.Controllers
{
    [ApiController]
    [Route ("[controller]")]
    public class controladorAPI : ControllerBase
    {

        private static List<Filmes> filmes = new List<Filmes>();
        private static int Id = 1;

        [HttpPost]
        public void AdicionarFilmes([FromBody]Filmes filme)
        {
            filme.Id = Id++;
            filmes.Add(filme);
            Console.WriteLine(filme.Titulo);
        }

        [HttpGet]
        public IEnumerable<Filmes> RecuperarFilmes ()
        {
            return filmes;
        }

        [HttpGet ("{id}")]
        public Filmes RecuperarFilmesporId (int id)
        {
            foreach (Filmes filmes in filmes)
            {
                if (filmes.Id == id)
                {
                    return filmes;
                }
            }
            return null;   
        }
    }
}
