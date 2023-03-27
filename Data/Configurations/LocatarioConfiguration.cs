using Locacao_imoveis.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Locacao_imoveis.Data.Configurations
{
    public class LocatarioConfiguration : IEntityTypeConfiguration<Locatorio>
    {
        public void Configure(EntityTypeBuilder<Locatorio> builder)
        {
            builder.ToTable("Locatorio");

            builder.HasKey(l => l.Id);

            builder.Property(l => l.Nome)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(l => l.Cpf)
                   .IsRequired()
                   .HasMaxLength(11);

            builder.Property(l => l.Rg)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(l => l.Telefone)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(l => l.Email)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(l => l.Profissao)
                   .IsRequired()
                   .HasMaxLength(50);
        }
    }
}
