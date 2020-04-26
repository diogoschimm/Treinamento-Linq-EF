using TreinamentoLinq.Data.Base;
using TreinamentoLinq.Domain;
using TreinamentoLinq.Domain.Contracts.Repositories;

namespace TreinamentoLinq.Data.Repositories
{
    public class PedidoRepository : RepositoryBase<Pedido>, IPedidoRepository
    {
        public PedidoRepository(TreinamentoContext context) : base(context)
        {
        }
    }
}
