using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TreinamentoLinq.Domain;

namespace TreinamentoLinq.Data.Mappings
{
    public class EmpresaMapping : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("Empresa");
            builder.HasKey(e => e.IdEmpresa).HasName("pk_empresa");
            builder.Property(e => e.IdEmpresa).ValueGeneratedOnAdd();

            builder.Property(e => e.IdEmpresa)
                .HasColumnName("idEmpresa")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(e => e.CNPJ)
                .HasColumnName("CNPJ")
                .HasColumnType("varchar(14)") 
                .IsRequired();

            builder.Property(e => e.RazaoSocial)
                .HasColumnName("razaoSocial")
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(e => e.NomeFantasia)
                .HasColumnName("nomeFantasia")
                .HasColumnType("varchar(100)")
                .IsRequired();
        }
    }
}
