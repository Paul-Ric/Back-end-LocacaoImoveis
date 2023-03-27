using Locacao_imoveis.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Locacao_imoveis.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Username)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(u => u.Email)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(u => u.Password)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.HasMany(u => u.Locacoes)
                   .WithOne(l => l.Usuario)
                   .HasForeignKey(l => l.UsuarioId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new User { Id = 1, Username = "Admin", Email = "admin@imobiliaria.com", Password = "admin" },
                new User { Id = 2, Username = "Paulo", Email = "paulo@imobiliaria.com", Password = "paulo" }
            );
        }
    }
}
