using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TreinamentoLinq.Domain;

namespace TreinamentoLinq.Data.Mappings
{
    public class PedidoItemMapping : IEntityTypeConfiguration<PedidoItem>
    {
        public void Configure(EntityTypeBuilder<PedidoItem> builder)
        {
            builder.ToTable("PedidoItem");
            builder.HasKey(pi => pi.IdItemPedido).HasName("pk_pedidoItem");
            builder.Property(pi => pi.IdItemPedido).ValueGeneratedOnAdd();

            builder.Property(pi => pi.IdItemPedido)
                .HasColumnName("idItemPedido")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(pi => pi.Quantidade)
                .HasColumnName("quantidade")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(pi => pi.ValorUnitario)
                .HasColumnName("valorUnitario")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(pi => pi.ValorDesconto)
                .HasColumnName("valorDesconto")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(pi => pi.ValorFinal)
                .HasColumnName("valorFinal")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(pi => pi.IdProduto)
                .HasColumnName("idProduto")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(pi => pi.IdPedido)
                .HasColumnName("idPedido")
                .HasColumnType("int")
                .IsRequired();

            builder.HasOne(pi => pi.Produto)
                .WithMany(p => p.ItemsPedido)
                .HasForeignKey(pi => pi.IdProduto)
                .HasConstraintName("fk_pedidoItem_produto")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(pi => pi.Pedido)
                .WithMany(p => p.Items)
                .HasForeignKey(pi => pi.IdPedido)
                .HasConstraintName("fk_pedidoItem_pedido")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
