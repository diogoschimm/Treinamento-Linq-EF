namespace TreinamentoLinq.ApiDados.ViewModels
{
    public class BancoViewModel
    {
        public BancoViewModel(string codigoBanco, string nomeBanco)
        {
            this.CodigoBanco = codigoBanco;
            this.NomeBanco = nomeBanco;
        }

        public BancoViewModel() { }

        public string CodigoBanco { get; set; }
        public string NomeBanco { get; set; }
    }
}
