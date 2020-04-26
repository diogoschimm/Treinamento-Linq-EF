using System.Collections.Generic;
using TreinamentoLinq.Domain.Base;

namespace TreinamentoLinq.Domain
{
    public class ContaFinanceira : Entity
    {
        public int IdContaFinanceira { get; private set; }
        public string NomeContaFinanceira { get; private set; }
        public bool IsContaCaixa { get; private set; }
        public string Agencia { get; private set; }
        public string NumeroConta { get; private set; }

        public string CodigoBanco { get; private set; }
        public Banco Banco { get; private set; }

        public int IdEmpresa { get; private set; }
        public Empresa Empresa { get; private set; }

        public ICollection<PedidoPagamento> PagamentosPedido { get; private set; }
    }
}
