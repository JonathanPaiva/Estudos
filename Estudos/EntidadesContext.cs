using Microsoft.EntityFrameworkCore;

namespace Estudos
{
    public class EntidadesContext : DbContext
    {
        public DbSet<Entidades.Produto> Produtos { get; set; } /* Caso haja declaração da entidade referente a um relacionamento, 
         * não precisaria criar o DbSet referente a esta entidade */
        public DbSet<Entidades.Categoria> Categorias { get; set; }

        public DbSet<Entidades.Aluno> Alunos { get; set; }

        public DbSet<Entidades.Equipamento> Equipamentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source = localhost\\sqlexpress; Initial Catalog = " +
                                        "EstudosDB;Persist Security Info=True;User ID=sa;Password=qaz@123");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            /*//Inclusão de Produtos
            modelBuilder.Entity<Entidades.Produto>().HasData(new Entidades.Produto
            { 
                ID = 20,
                NomeItem = "COMPASSO",
                PrecoItem = 8.99,
                IDGrupo = 0,
            });

            //Inclusão de Categorias
            modelBuilder.Entity<Entidades.Categoria>().HasData(new Entidades.Categoria
            {
                ID = 20,
                NomeGrupo = "Teste",

            });*/

            //modelBuilder.SeedDatabase();

        }

    }
}
