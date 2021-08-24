using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_razor.Models
{
    public class Material
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public int AlunoId { get; set; }
    }
}
