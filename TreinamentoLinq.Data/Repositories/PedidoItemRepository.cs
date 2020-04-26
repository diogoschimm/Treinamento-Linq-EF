using TreinamentoLinq.Data.Base;
using TreinamentoLinq.Domain;
using TreinamentoLinq.Domain.Contracts.Repositories;

namespace TreinamentoLinq.Data.Repositories
{
    public class PedidoItemRepository : RepositoryBase<PedidoItem>, IPedidoItemRepository
    {
        public PedidoItemRepository(TreinamentoContext context) : base(context)
        {
        }
    }
}
