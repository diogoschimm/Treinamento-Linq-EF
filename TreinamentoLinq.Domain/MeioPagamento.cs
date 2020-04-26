using System.Collections.Generic;
using TreinamentoLinq.Domain.Base;

namespace TreinamentoLinq.Domain
{
    public class MeioPagamento : Entity
    {
        public int IdMeioPagamento { get; private set; }
        public string NomeMeioPagamento { get; private set; }

        public ICollection<PedidoPagamento> PagamentosPedido { get; private set; }
    }
}
