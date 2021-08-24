using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_razor.Models
{
    public class Aluno
    {
       
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Matricula { get; set; }

        [Required]
        public string Notas { get; set; }
    }
}
