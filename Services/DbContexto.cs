using aec_webapi_ef.Models;
using Microsoft.EntityFrameworkCore;

namespace aec_webapi_ef.Services 
{
    public class DbContexto : DbContext 
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder){

            modelBuilder.Entity<Candidato>().HasIndex(u => u.Cpf).IsUnique();

        }
        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Profissao> Profissoes { get; set; }

    }
}