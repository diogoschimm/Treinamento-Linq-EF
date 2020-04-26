using TreinamentoLinq.Data.Base;
using TreinamentoLinq.Domain;
using TreinamentoLinq.Domain.Contracts.Repositories;

namespace TreinamentoLinq.Data.Repositories
{
    public class PedidoPagamentoRepository : RepositoryBase<PedidoPagamento>, IPedidoPagamentoRepository
    {
        public PedidoPagamentoRepository(TreinamentoContext context) : base(context)
        {
        }
    }
}
