using System.Collections.Generic;
using TreinamentoLinq.Domain.Base;

namespace TreinamentoLinq.Domain
{
    public class BandeiraCartao : Entity
    {
        public int IdBandeiraCartao { get; private set; }
        public string NomeBandeira { get; private set; }

        public ICollection<PedidoPagamento> PagamentosPedido { get; private set; }
        public ICollection<TaxaBandeiraOperadoraCartao> TaxasBandeiraOperadoraCartao { get; private set; }
    }
}
