using TreinamentoLinq.Data.Base;
using TreinamentoLinq.Domain;
using TreinamentoLinq.Domain.Contracts.Repositories;

namespace TreinamentoLinq.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public ProdutoRepository(TreinamentoContext context) : base(context)
        {
        }
    }
}
