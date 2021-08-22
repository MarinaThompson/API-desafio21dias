using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Administradores.ModelViews
{
    public record AdmLoginView
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
