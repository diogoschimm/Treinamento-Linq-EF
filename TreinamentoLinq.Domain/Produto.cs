using System.Collections.Generic;
using TreinamentoLinq.Domain.Base;

namespace TreinamentoLinq.Domain
{
    public class Produto : Entity
    {
        public int IdProduto { get; private set; }
        public string NomeProduto { get; private set; }
        public int QuantidadeEstoque { get; private set; }
        public decimal ValorVenda { get; private set; }
        public decimal? ValorPromocional { get; private set; }

        public int IdEmpresa { get; private set; }
        public Empresa Empresa { get; private set; }
         
        public ICollection<PedidoItem> ItemsPedido { get; private set; }
    }
}
