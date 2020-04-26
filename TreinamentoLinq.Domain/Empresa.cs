using System.Collections.Generic;
using TreinamentoLinq.Domain.Base;

namespace TreinamentoLinq.Domain
{
    public class Empresa : Entity
    {
        public int IdEmpresa { get; private set; }
        public string CNPJ { get; private set; }
        public string RazaoSocial { get; private set; }
        public string NomeFantasia { get; private set; }

        public ICollection<Cliente> Clientes { get; private set; }
        public ICollection<ContaFinanceira> ContasFinanceiras { get; private set; }
        public ICollection<Pedido> Pedidos { get; private set; }
        public ICollection<TaxaBandeiraOperadoraCartao> TaxasBandeiraOperadoraCartao { get; private set; }
        public ICollection<Produto> Produtos { get; private set; }
    }
}
