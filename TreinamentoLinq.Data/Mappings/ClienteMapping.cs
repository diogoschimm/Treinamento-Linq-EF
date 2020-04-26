using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TreinamentoLinq.Domain;

namespace TreinamentoLinq.Data.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");
            builder.HasKey(c => c.IdCliente).HasName("pk_cliente");
            builder.Property(c => c.IdCliente).ValueGeneratedOnAdd();

            builder.Property(c => c.IdCliente)
                .HasColumnName("idCliente")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(c => c.NomeCliente)
                .HasColumnName("nomeCliente")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(c => c.IdEmpresa)
                .HasColumnName("idEmpresa")
                .HasColumnType("int")
                .IsRequired();

            builder.HasOne(c => c.Empresa)
                .WithMany(e => e.Clientes)
                .HasForeignKey(c => c.IdEmpresa)
                .HasConstraintName("fk_cliente_empresa")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
