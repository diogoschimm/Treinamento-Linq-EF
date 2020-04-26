using TreinamentoLinq.Data.Base;
using TreinamentoLinq.Domain;
using TreinamentoLinq.Domain.Contracts.Repositories;

namespace TreinamentoLinq.Data.Repositories
{
    public class ContaFinanceiraRepository : RepositoryBase<ContaFinanceira>, IContaFinanceiraRepository
    {
        public ContaFinanceiraRepository(TreinamentoContext context) : base(context)
        {
        }
    }
}
