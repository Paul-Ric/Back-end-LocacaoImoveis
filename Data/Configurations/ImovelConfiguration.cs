using Locacao_imoveis.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Locacao_imoveis.Data.Configurations
{
    public class ImovelConfiguration : IEntityTypeConfiguration<Imovel>
    {
        public void Configure(EntityTypeBuilder<Imovel> builder)
        {
            builder.ToTable("Imovel");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.Endereco)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(i => i.Valor)
                   .IsRequired();

            builder.Property(i => i.NumeroQuartos)
                   .IsRequired();

            builder.HasMany(i => i.Locacoes)
                   .WithOne(l => l.Imovel)
                   .HasForeignKey(l => l.ImovelId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
