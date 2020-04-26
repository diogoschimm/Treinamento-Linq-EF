using TreinamentoLinq.Data.Base;
using TreinamentoLinq.Domain;
using TreinamentoLinq.Domain.Contracts.Repositories;

namespace TreinamentoLinq.Data.Repositories
{
    public class EmpresaRepository : RepositoryBase<Empresa>, IEmpresaRepository
    {
        public EmpresaRepository(TreinamentoContext context) : base(context)
        {
        }
    }
}
