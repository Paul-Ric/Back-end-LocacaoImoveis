using Locacao_imoveis.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Locacao_imoveis.Data.Configurations
{
    public class LocacaoConfiguration : IEntityTypeConfiguration<Locacao>
    {
        public void Configure(EntityTypeBuilder<Locacao> builder)
        {
            builder.ToTable("Locacao");

            builder.HasKey(l => l.Id);

            builder.Property(l => l.DataInicio)
                   .IsRequired();

            builder.Property(l => l.DataFim)
                   .IsRequired();

            builder.Property(l => l.ValorMensal)
                   .IsRequired();

            builder.HasOne(l => l.Imovel)
                   .WithMany(i => i.Locacoes)
                   .HasForeignKey(l => l.ImovelId)
                   .OnDelete(DeleteBehavior.Restrict);

            
        }
    }
}
