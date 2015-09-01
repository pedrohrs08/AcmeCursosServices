using System.Data.Entity;
using AcmeCursos.Models;

namespace AcmeCursosServices.DAL
{
    public class AppDbContext : DbContext
    {
        public static AppDbContext db = new AppDbContext();
       
        public AppDbContext() : base("DefaultConnection")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Estudante> Estudantes { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Inscricao> Inscricoes { get; set; }
    }
}