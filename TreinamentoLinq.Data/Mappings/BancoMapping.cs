using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TreinamentoLinq.Domain;

namespace TreinamentoLinq.Data.Mappings
{
    public class BancoMapping : IEntityTypeConfiguration<Banco>
    {
        public void Configure(EntityTypeBuilder<Banco> builder)
        {
            builder.ToTable("Banco");
            builder.HasKey(b => b.CodigoBanco).HasName("pk_banco");

            builder.Property(b => b.CodigoBanco)
                .HasColumnName("codigoBanco")
                .HasColumnType("varchar(3)")
                .IsRequired();

            builder.Property(b => b.NomeBanco)
                .HasColumnName("nomeBanco")
                .HasColumnType("varchar(100)")
                .IsRequired();
        }   
    }
}
