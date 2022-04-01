using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieFlix.Data.DTO
{
    public class MovieDTO
    {
        [Key]  // a chave do meu banco
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo é obrigatorio")]
        public string Name { get; set; }

        [StringLength(30, ErrorMessage = "O genero não pode passa de 30 caracteres")]
        [Required]  // é obrigatorio
        public string Genre { get; set; }

        [Range(1, 600)] // vai dura no minimo 1 maxino 600
        public int Duration { get; set; }

        public DateTime date { get; set; }
    }
}
