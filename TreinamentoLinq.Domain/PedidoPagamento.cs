using System;
using TreinamentoLinq.Domain.Base;

namespace TreinamentoLinq.Domain
{
    public class PedidoPagamento : Entity
    {
        public int IdPagamento { get; private set; }
        public DateTime DataPagamento { get; private set; }
        public decimal ValorPagamento { get; private set; }
        public decimal ValorJuros { get; private set; }
        public decimal ValorMulta { get; private set; }
        public decimal ValorDescontoPagamento { get; private set; }
        public DateTime DataPrevistaCredito { get; private set; }
        public int NumeroParcela { get; private set; }
        public int QuantidadeParcela { get; private set; }
        public string CodigoPagamento { get; private set; }
        
        public int IdMeioPagamento { get; private set; }
        public MeioPagamento MeioPagamento { get; private set; }

        public int? IdBandeira { get; private set; }
        public BandeiraCartao BandeiraCartao { get; private set; }

        public int? IdOperadoraCartao { get; private set; }
        public OperadoraCartao OperadoraCartao { get; private set; }

        public int IdContaFinanceira { get; private set; }
        public ContaFinanceira ContaFinanceira { get; private set; }

        public int IdPedido { get; private set; }
        public Pedido Pedido { get; private set; } 
    }
}
