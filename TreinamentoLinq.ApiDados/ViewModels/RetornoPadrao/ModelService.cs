namespace TreinamentoLinq.ApiDados.ViewModels.RetornoPadrao
{
    public class ModelService<TViewModel> : ModelPadrao where TViewModel : class 
    {
        public TViewModel Model { get; set; }
    }
}
