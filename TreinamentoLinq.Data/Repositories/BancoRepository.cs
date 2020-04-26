using TreinamentoLinq.Data.Base;
using TreinamentoLinq.Domain;
using TreinamentoLinq.Domain.Contracts.Repositories;

namespace TreinamentoLinq.Data.Repositories
{
    public class BancoRepository : RepositoryBase<Banco>, IBancoRepository
    {
        public BancoRepository(TreinamentoContext context) : base(context)
        {
        }
    }
}
