using System;
using System.Collections.Generic;
using TreinamentoLinq.Domain.Base;

namespace TreinamentoLinq.Domain
{
    public class Pedido : Entity
    {
        public int IdPedido { get; private set; }
        public decimal ValorTotalPedido { get; private set; }
        public decimal ValorTotalDesconto { get; private set; }
        public decimal ValorFinalPedido { get; private set; }
        public DateTime DataPedido { get; private set; }

        public bool IsPago { get; private set; }
        public decimal ValorPagoMomento { get; private set; }
        public DateTime? DataPrimeiroPagamento { get; private set; }

        public int IdCliente { get; private set; }
        public Cliente Cliente { get; private set; }

        public int IdEmpresa { get; private set; }
        public Empresa Empresa { get; private set; }

        public ICollection<PedidoItem> Items { get; private set; }
        public ICollection<PedidoPagamento> PagamentosPedido { get; private set; }
    }
}
