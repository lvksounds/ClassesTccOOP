using Microsoft.EntityFrameworkCore;
using Waise.Portal.Models.Academico;

namespace Waise.Portal.Data
{
    public class WaiseAcademicoContext : DbContext
    {
        public WaiseAcademicoContext(DbContextOptions<WaiseAcademicoContext> options) : base(options) { }

        public DbSet<Instituicao> Instituicoes { get; set; }
        public DbSet<Curso> Cursos { get; set; }
    }
}
