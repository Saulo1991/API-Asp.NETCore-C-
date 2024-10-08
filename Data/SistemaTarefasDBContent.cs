using Microsoft.EntityFrameworkCore;
using MyNewApi.Models;

namespace SistemaDeTarefas.Data 
{
    public class SistemaDeTarefasDBContex : DbContext
    {
        public SistemaDeTarefasDBContex(DbContextOptions<SistemaDeTarefasDBContex> options)
        : base(options)
        {

        }
        public DbSet<UsuarioModel> Usuarios { get; set; }

        public DbSet<TarefaModel> Tarefas { get; set ;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}