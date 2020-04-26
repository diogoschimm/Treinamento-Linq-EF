using System.Collections.Generic;
using TreinamentoLinq.Domain.Base;

namespace TreinamentoLinq.Domain
{
    public class Cliente : Entity
    {
        public int IdCliente { get; private set; }
        public string NomeCliente { get; private set; }

        public int IdEmpresa { get; private set; }
        public Empresa Empresa { get; private set; }

        public ICollection<Pedido> Pedidos { get; private set; }
    }
}
