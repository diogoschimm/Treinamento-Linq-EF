using TreinamentoLinq.Data.Base;
using TreinamentoLinq.Domain;
using TreinamentoLinq.Domain.Contracts.Repositories;

namespace TreinamentoLinq.Data.Repositories
{
    public class TaxaBandeiraOperadoraCartaoRepository : RepositoryBase<TaxaBandeiraOperadoraCartao>, ITaxaBandeiraOperadoraCartaoRepository
    {
        public TaxaBandeiraOperadoraCartaoRepository(TreinamentoContext context) : base(context)
        {
        }
    }
}
