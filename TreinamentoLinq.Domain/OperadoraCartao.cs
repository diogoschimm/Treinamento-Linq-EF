using System.Collections.Generic;
using TreinamentoLinq.Domain.Base;

namespace TreinamentoLinq.Domain
{
    public class OperadoraCartao : Entity
    {
        public int IdOperadoraCartao { get; private set; }
        public string NomeOperadoraCartao { get; private set; }

        public ICollection<PedidoPagamento> PagamentosPedido { get; private set; }
        public ICollection<TaxaBandeiraOperadoraCartao> TaxasBandeiraOperadoraCartao { get; private set; }
    }
}
