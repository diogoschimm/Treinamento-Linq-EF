using TreinamentoLinq.Domain.Base;

namespace TreinamentoLinq.Domain
{
    public class TaxaBandeiraOperadoraCartao : Entity
    {
        public int IdEmpresa { get; private set; }
        public Empresa Empresa { get; private set; }

        public int IdBandeiraCartao { get; private set; }
        public BandeiraCartao BandeiraCartao { get; private set; }

        public int IdOperadoraCartao { get; private set; }
        public OperadoraCartao OperadoraCartao { get; private set; }

        public decimal PercentualTaxaCartao { get; private set; }
    }
}
