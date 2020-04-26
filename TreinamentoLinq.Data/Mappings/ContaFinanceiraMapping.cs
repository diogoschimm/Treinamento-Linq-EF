using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TreinamentoLinq.Domain;

namespace TreinamentoLinq.Data.Mappings
{
    public class ContaFinanceiraMapping : IEntityTypeConfiguration<ContaFinanceira>
    {
        public void Configure(EntityTypeBuilder<ContaFinanceira> builder)
        {
            builder.ToTable("ContaFinanceira");
            builder.HasKey(c => c.IdContaFinanceira).HasName("pk_contaFinanceira");
            builder.Property(c => c.IdContaFinanceira).ValueGeneratedOnAdd();

            builder.Property(c => c.IdContaFinanceira)
                .HasColumnName("idContaFinanceira")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(c => c.NomeContaFinanceira)
                .HasColumnName("nomeContaFinanceira")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(c => c.IsContaCaixa)
                .HasColumnName("isContaCaixa")
                .HasColumnType("bit")
                .IsRequired();

            builder.Property(c => c.Agencia)
                .HasColumnName("agencia")
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.Property(c => c.NumeroConta)
                .HasColumnName("numeroConta")
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.Property(c => c.CodigoBanco)
                .HasColumnName("codigoBanco")
                .HasColumnType("varchar(3)");

            builder.Property(c => c.IdEmpresa)
                .HasColumnName("idEmpresa")
                .HasColumnType("int")
                .IsRequired();

            builder.HasOne(c => c.Banco)
                .WithMany(b => b.ContasFinanceiras)
                .HasForeignKey(c => c.CodigoBanco)
                .HasConstraintName("fk_contaFinanceira_banco")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(c => c.Empresa)
                .WithMany(e => e.ContasFinanceiras)
                .HasForeignKey(c => c.IdEmpresa)
                .HasConstraintName("fk_contaFinanceira_empresa")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
