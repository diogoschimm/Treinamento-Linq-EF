using Microsoft.EntityFrameworkCore;
using TreinamentoLinq.Data.Mappings;
using TreinamentoLinq.Domain;

namespace TreinamentoLinq.Data
{
    public class TreinamentoContext : DbContext
    {

        public DbSet<Banco> Banco { get; set; }
        public DbSet<BandeiraCartao> BandeiraCartao { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<ContaFinanceira> ContaFinanceira { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<MeioPagamento> MeioPagamento { get; set; }
        public DbSet<OperadoraCartao> OperadoraCartcao { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<PedidoItem> PedidoItem { get; set; }
        public DbSet<PedidoPagamento> PedidoPagamento { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<TaxaBandeiraOperadoraCartao> TaxaBandeiraOperadoraCartao { get; set; }


        public TreinamentoContext(DbContextOptions<TreinamentoContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BancoMapping());
            modelBuilder.ApplyConfiguration(new BandeiraCartaoMapping());
            modelBuilder.ApplyConfiguration(new ClienteMapping());
            modelBuilder.ApplyConfiguration(new ContaFinanceiraMapping());
            modelBuilder.ApplyConfiguration(new EmpresaMapping());
            modelBuilder.ApplyConfiguration(new MeioPagamentoMapping());
            modelBuilder.ApplyConfiguration(new OperadoraCartaoMapping());
            modelBuilder.ApplyConfiguration(new PedidoItemMapping ());
            modelBuilder.ApplyConfiguration(new PedidoMapping());
            modelBuilder.ApplyConfiguration(new PedidoPagamentoMapping());
            modelBuilder.ApplyConfiguration(new ProdutoMapping());
            modelBuilder.ApplyConfiguration(new TaxaBandeiraOperadoraCartaoMapping()); 
        }
    }
}
