using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 
using TreinamentoLinq.Domain;

namespace TreinamentoLinq.Data.Mappings
{
    public class OperadoraCartaoMapping : IEntityTypeConfiguration<OperadoraCartao>
    {
        public void Configure(EntityTypeBuilder<OperadoraCartao> builder)
        {
            builder.ToTable("OperadoraCartao");
            builder.HasKey(o => o.IdOperadoraCartao).HasName("pk_operadoraCartao");
            builder.Property(o => o.IdOperadoraCartao).ValueGeneratedOnAdd();

            builder.Property(o => o.IdOperadoraCartao)
                .HasColumnName("idOperadoraCartao")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(o => o.NomeOperadoraCartao)
                .HasColumnName("nomeOperadoraCartao")
                .HasColumnType("varchar(100)")
                .IsRequired();
        }
    }
}
