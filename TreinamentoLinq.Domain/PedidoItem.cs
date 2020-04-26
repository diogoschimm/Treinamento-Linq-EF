using TreinamentoLinq.Domain.Base;

namespace TreinamentoLinq.Domain
{
    public class PedidoItem : Entity
    {
        public int IdItemPedido { get; private set; }
        public int Quantidade { get; private set; }
        public decimal ValorUnitario { get; private set; }
        public decimal ValorDesconto { get; private set; }
        public decimal ValorFinal { get; private set; }

        public int IdProduto { get; private set; }
        public Produto Produto { get; private set; }

        public int IdPedido { get; private set; }
        public Pedido Pedido { get; private set; }
    }
}
