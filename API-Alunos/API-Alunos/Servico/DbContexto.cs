using API_Alunos.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Alunos.Servico
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
