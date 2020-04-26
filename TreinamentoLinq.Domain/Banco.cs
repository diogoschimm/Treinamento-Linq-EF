using System.Collections.Generic;
using TreinamentoLinq.Domain.Base;

namespace TreinamentoLinq.Domain
{
    public class Banco : Entity
    {
        public Banco(string codigoBanco, string nomeBanco)
        {
            this.CodigoBanco = codigoBanco;
            this.NomeBanco = nomeBanco;
        }
        protected Banco() { }

        public string CodigoBanco { get; private set; }
        public string NomeBanco { get; private set; }

        public ICollection<ContaFinanceira> ContasFinanceiras { get; private set; }

        public void ModificarNomeBanco(string novoNome)
        {
            this.NomeBanco = novoNome;
        }
    }
}
