using TreinamentoLinq.Data.Base;
using TreinamentoLinq.Domain;
using TreinamentoLinq.Domain.Contracts.Repositories;

namespace TreinamentoLinq.Data.Repositories
{
    public class OperadoraCartaoRepository : RepositoryBase<OperadoraCartao>, IOperadoraCartaoRepository
    {
        public OperadoraCartaoRepository(TreinamentoContext context) : base(context)
        {
        }
    }
}
