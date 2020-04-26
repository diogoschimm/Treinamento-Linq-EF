using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TreinamentoLinq.Domain;

namespace TreinamentoLinq.Data.Mappings
{
    public class TaxaBandeiraOperadoraCartaoMapping : IEntityTypeConfiguration<TaxaBandeiraOperadoraCartao>
    {
        public void Configure(EntityTypeBuilder<TaxaBandeiraOperadoraCartao> builder)
        {
            builder.ToTable("TaxaBandeiraOperadoraCartao");
            builder.HasKey(t => new { t.IdEmpresa, t.IdBandeiraCartao, t.IdOperadoraCartao }).HasName("pk_taxaBandeiraOperadoraCartao");

            builder.Property(t => t.IdEmpresa)
                .HasColumnName("idEmpresa")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(t => t.IdBandeiraCartao)
                .HasColumnName("idBandeiraCartao")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(t => t.IdOperadoraCartao)
                .HasColumnName("idOperadoraCartao")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(t => t.PercentualTaxaCartao)
                .HasColumnName("percentualTaxaCartao")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.HasOne(t => t.Empresa)
                .WithMany(e => e.TaxasBandeiraOperadoraCartao)
                .HasForeignKey(t => t.IdEmpresa)
                .HasConstraintName("fk_taxaBandeiraOperadoraCartao_empresa")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(t => t.BandeiraCartao)
                .WithMany(b => b.TaxasBandeiraOperadoraCartao)
                .HasForeignKey(t => t.IdBandeiraCartao)
                .HasConstraintName("fk_taxaBandeiraOperadoraCartao_bandeiraCartao")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(t => t.OperadoraCartao)
                .WithMany(o => o.TaxasBandeiraOperadoraCartao)
                .HasForeignKey(t => t.IdOperadoraCartao)
                .HasConstraintName("fk_taxaBandeiraOperadoraCartao_operadoraCartao")
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
