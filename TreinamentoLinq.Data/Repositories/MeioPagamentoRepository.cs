using TreinamentoLinq.Data.Base;
using TreinamentoLinq.Domain;
using TreinamentoLinq.Domain.Contracts.Repositories;

namespace TreinamentoLinq.Data.Repositories
{
    public class MeioPagamentoRepository : RepositoryBase<MeioPagamento>, IMeioPagamentoRepository
    {
        public MeioPagamentoRepository(TreinamentoContext context) : base(context)
        {
        }
    }
}
