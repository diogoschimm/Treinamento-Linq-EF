using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TreinamentoLinq.Domain;

namespace TreinamentoLinq.Data.Mappings
{
    public class PedidoPagamentoMapping : IEntityTypeConfiguration<PedidoPagamento>
    {
        public void Configure(EntityTypeBuilder<PedidoPagamento> builder)
        {
            builder.ToTable("PedidoPagamento");
            builder.HasKey(pp => pp.IdPagamento).HasName("pk_pedidoPagamento");
            builder.Property(pp => pp.IdPagamento).ValueGeneratedOnAdd();

            builder.Property(pp => pp.IdPagamento)
                .HasColumnName("idPagamento")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(pp => pp.DataPagamento)
                .HasColumnName("dataPagamento")
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(pp => pp.ValorPagamento)
                .HasColumnName("valorPagamento")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(pp => pp.ValorJuros)
                .HasColumnName("valorJuros")
                .HasColumnType("decimal(18,2)") 
                .IsRequired();

            builder.Property(pp => pp.ValorMulta)
                .HasColumnName("valorMulta")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(pp => pp.ValorDescontoPagamento)
                .HasColumnName("valorDescontoPagamento")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(pp => pp.DataPrevistaCredito)
                .HasColumnName("dataPrevistaCredito")
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(pp => pp.NumeroParcela)
                .HasColumnName("numeroParcela")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(pp => pp.QuantidadeParcela)
                .HasColumnName("quantidadeParcela")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(pp => pp.CodigoPagamento)
                .HasColumnName("codigoPagamento")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(pp => pp.IdMeioPagamento)
                .HasColumnName("idMeioPagamento")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(pp => pp.IdBandeira)
                .HasColumnName("idBandeira")
                .HasColumnType("int");

            builder.Property(pp => pp.IdOperadoraCartao)
                .HasColumnName("idOperadoraCartao")
                .HasColumnType("int");

            builder.Property(pp => pp.IdContaFinanceira)
                .HasColumnName("idContaFinanceira")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(pp => pp.IdPedido)
                .HasColumnName("idPedido")
                .HasColumnType("int")
                .IsRequired();

            builder.HasOne(pp => pp.MeioPagamento)
                .WithMany(m => m.PagamentosPedido)
                .HasForeignKey(pp => pp.IdMeioPagamento)
                .HasConstraintName("fk_pedidoPagamento_meioPagamento")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(pp => pp.BandeiraCartao)
                .WithMany(b => b.PagamentosPedido)
                .HasForeignKey(pp => pp.IdBandeira)
                .HasConstraintName("fk_pedidoPagamento_bandeiraCartao")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(pp => pp.OperadoraCartao)
                .WithMany(o => o.PagamentosPedido)
                .HasForeignKey(pp => pp.IdOperadoraCartao)
                .HasConstraintName("fk_pedidoPagamento_operadoraCartao")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(pp => pp.ContaFinanceira)
                .WithMany(c => c.PagamentosPedido)
                .HasForeignKey(pp => pp.IdContaFinanceira)
                .HasConstraintName("fk_pedidoPagamento_contaFinanceira")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(pp => pp.Pedido)
                .WithMany(p => p.PagamentosPedido)
                .HasForeignKey(pp => pp.IdPedido)
                .HasConstraintName("fk_pedidoPagamento_pedido")
                .OnDelete(DeleteBehavior.NoAction); 
        }
    }
}
