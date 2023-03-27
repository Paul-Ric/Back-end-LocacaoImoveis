using Locacao_imoveis.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Locacao_imoveis.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;port=3306;database=locacaoimoveis;user=root;password=data7123;";
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }
         
        }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Imovel> Imoveis { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }
        public DbSet<Locatorio> Locatarios { get; set; }
        public DbSet<User> Users { get; set; }
    }

       

       

}
