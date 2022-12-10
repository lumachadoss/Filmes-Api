using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api1.Modelos
{
    public class Filmes
    {
        public int Id { get; internal set; }
        [Required (ErrorMessage =  "O campo não pode estar vazio")]
        public string Titulo {get; set;}
        [Required(ErrorMessage = "O campo não pode estar vazio")]
        public string Diretor {get; set;}
        public string Genero {get; set;}
        [Range(1,80, ErrorMessage =  "O valor de tempo não é válido")]
        public int Duracao {get; set;}
    
    }
}
