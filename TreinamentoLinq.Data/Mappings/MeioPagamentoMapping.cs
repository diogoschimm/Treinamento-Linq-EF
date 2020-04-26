using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TreinamentoLinq.Domain;

namespace TreinamentoLinq.Data.Mappings
{
    public class MeioPagamentoMapping : IEntityTypeConfiguration<MeioPagamento>
    {
        public void Configure(EntityTypeBuilder<MeioPagamento> builder)
        {
            builder.ToTable("MeioPagamento");
            builder.HasKey(m => m.IdMeioPagamento).HasName("pk_meioPagamento");
            builder.Property(m => m.IdMeioPagamento).ValueGeneratedOnAdd();

            builder.Property(m => m.IdMeioPagamento)
                .HasColumnName("idMeioPagamento")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(m => m.NomeMeioPagamento)
                .HasColumnName("nomeMeioPagamento")
                .HasColumnType("varchar(100)")
                .IsRequired(); 
        }
    }
}
