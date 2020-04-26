using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 
using TreinamentoLinq.Domain;

namespace TreinamentoLinq.Data.Mappings
{
    public class PedidoMapping : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedido");
            builder.HasKey(p => p.IdPedido).HasName("pk_pedido");
            builder.Property(p => p.IdPedido).ValueGeneratedOnAdd();

            builder.Property(p => p.IdPedido)
                .HasColumnName("idPedido")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.ValorTotalPedido)
                .HasColumnName("valorTotalPedido")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(p => p.ValorTotalDesconto)
                .HasColumnName("valorTotalDesconto")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(p => p.ValorFinalPedido)
                .HasColumnName("valorFinalPedido")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(p => p.DataPedido)
                .HasColumnName("dataPedido")
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(p => p.IsPago)
                .HasColumnName("isPago")
                .HasColumnType("bit")
                .IsRequired();

            builder.Property(p => p.ValorPagoMomento)
                .HasColumnName("valorPagoMomento")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(p => p.DataPrimeiroPagamento)
                .HasColumnName("dataPrimeiroPagamento")
                .HasColumnType("datetime");

            builder.Property(p => p.IdCliente)
                .HasColumnName("idCliente")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.IdEmpresa)
                .HasColumnName("idEmpresa")
                .HasColumnType("int")
                .IsRequired();
             
            builder.HasOne(p => p.Cliente)
                .WithMany(c => c.Pedidos)
                .HasForeignKey(p => p.IdCliente)
                .HasConstraintName("fk_pedido_cliente")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.Empresa)
                .WithMany(e => e.Pedidos)
                .HasForeignKey(p => p.IdEmpresa)
                .HasConstraintName("fk_pedido_empresa")
                .OnDelete(DeleteBehavior.NoAction); 
        }
    }
}
