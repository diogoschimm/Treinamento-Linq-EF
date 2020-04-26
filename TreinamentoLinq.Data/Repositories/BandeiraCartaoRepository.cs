using TreinamentoLinq.Data.Base;
using TreinamentoLinq.Domain;
using TreinamentoLinq.Domain.Contracts.Repositories;

namespace TreinamentoLinq.Data.Repositories
{
    public class BandeiraCartaoRepository : RepositoryBase<BandeiraCartao>, IBandeiraCartaoRepository
    {
        public BandeiraCartaoRepository(TreinamentoContext context) : base(context)
        {
        }
    }
}
