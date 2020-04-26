using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 
using TreinamentoLinq.Domain;

namespace TreinamentoLinq.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey(p => p.IdProduto).HasName("pk_produto");
            builder.Property(p => p.IdProduto).ValueGeneratedOnAdd();

            builder.Property(p => p.IdProduto)
                .HasColumnName("idProduto")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.NomeProduto)
                .HasColumnName("nomeProduto")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(p => p.QuantidadeEstoque)
                .HasColumnName("quantidadeEstoque")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.ValorVenda)
                .HasColumnName("valorVenda")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(p => p.ValorPromocional)
                .HasColumnName("valorPromocional")
                .HasColumnType("decimal(18,2)");

            builder.Property(p => p.IdEmpresa)
                .HasColumnName("idEmpresa")
                .HasColumnType("int")
                .IsRequired();

            builder.HasOne(p => p.Empresa)
                .WithMany(e => e.Produtos)
                .HasForeignKey(p => p.IdEmpresa)
                .HasConstraintName("fk_produto_empresa")
                .OnDelete(DeleteBehavior.NoAction); 
        }
    }
}
