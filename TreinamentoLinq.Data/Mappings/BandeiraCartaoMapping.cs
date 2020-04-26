using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 
using TreinamentoLinq.Domain;

namespace TreinamentoLinq.Data.Mappings
{
    public class BandeiraCartaoMapping : IEntityTypeConfiguration<BandeiraCartao>
    {
        public void Configure(EntityTypeBuilder<BandeiraCartao> builder)
        {
            builder.ToTable("BandeiraCartao");
            builder.HasKey(b => b.IdBandeiraCartao).HasName("pk_bandeiraCartao");
            builder.Property(b => b.IdBandeiraCartao).ValueGeneratedOnAdd();

            builder.Property(b => b.IdBandeiraCartao)
                .HasColumnName("idBandeiraCartao")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(b => b.NomeBandeira)
                .HasColumnName("nomeBandeira")
                .HasColumnType("varchar(100)")
                .IsRequired();

        }
    }
}
